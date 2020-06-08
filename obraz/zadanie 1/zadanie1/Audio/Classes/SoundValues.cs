using System;
using System.Collections.Generic;
using System.Linq;
using NAudio.Wave;

namespace Audio.Classes
{
    public class SoundValues
    {
        public List<SoundPoint> Values { get; }
        public double SampleRate { get; }

        public SoundValues(string filename)
        {
            using (var reader = new WaveFileReader(filename))
            {
                SampleRate = reader.WaveFormat.SampleRate;
                Values = new List<SoundPoint>();
                long index = 0;
                for (var i = 0; i < reader.Length / 2; i++)
                {
                    var v = reader.ReadNextSampleFrame();
                    Values.Add(new SoundPoint
                    {
                        Value = v[0],
                        Time = index++
                    });
                }
            }
        }

        public List<List<SoundPoint>> GetFrames(int size)
        {
            var list = new List<List<SoundPoint>>();

            for (var i = 0; i < Values.Count; i += size)
            {
                list.Add(Values.GetRange(i, Math.Min(size, Values.Count - i)));
            }

            return list;
        }

        public List<double> GetFrequenciesForFrames(int size, int k, float precision, int dimensions, bool useMedian,
            bool useRandom)
        {
            var frames = GetFrames(size);
            var frequencies = new List<double>();
            foreach (var frame in frames)
            {
                var result = CalculateFrequency(frame, 1, 0, k, size, precision, dimensions, useMedian, useRandom);
                if (result.succes)
                {
                    frequencies.Add(result.value);
                }
            }

            return frequencies;
        }


        private Random _random = new Random();

        private (bool success, long value) GetDistance(List<List<SoundPoint>> values, int startIndex,
            SoundPointComparer comparer)
        {
            if (startIndex >= values.Count) return (false, long.MaxValue);
            var first = values[startIndex];
            startIndex += 30;
            for (; startIndex < values.Count; startIndex++)
            {
                if (first.SequenceEqual(values[startIndex], comparer))
                    break;
            }

            if (startIndex >= values.Count) return (false, long.MaxValue);
            return (true, values[startIndex][0].Time - first[0].Time);
        }

        public static double GetMedian(List<long> values)
        {
            values.Sort();
            var mid = values.Count / 2;
            if (values.Count % 2 == 0)
            {
                return (values[mid] + values[mid - 1]) / 2d;
            }

            return values[mid];
        }

        public static double GetMedian(List<double> values)
        {
            values.Sort();
            var mid = values.Count / 2;
            if (values.Count % 2 == 0)
            {
                return (values[mid] + values[mid - 1]) / 2d;
            }

            return values[mid];
        }


        //TODO: Pominąć pierwszych kilkanaście/kilkadziesiąt wartości, ✔
        //TODO: zatrzymać po pierwszym powtórzeniu, ✔
        //TODO: wyciągnąć medianę,
        //TODO: dodać wymiary, ✔
        //TODO: podział na ramki,
        //TODO: jeżeli pierwsza odległość jest za mała to przerwać,
        //TODO: startowanie z kilku miejsc
        public (bool succes, double value) CalculateFrequency(int step, int start, int k, int size, float precision, int dimensions,
            bool useMedian, bool useRandomValues)
            => CalculateFrequency(Values, step, start, k, size, precision, dimensions, useMedian, useRandomValues);

        public (bool succes, double value) CalculateFrequency(List<SoundPoint> values, int step, int start, int k, int size, float precision,
            int dimensions, bool useMedian, bool useRandomValues)
        {
            if (dimensions * k + start > values.Count)
            {
                return (false, double.NegativeInfinity);
            }

            if (dimensions * k + start > start + size)
            {
                return (false, double.NegativeInfinity);
            }

            if (start + size > values.Count)
            {
                return (false, double.NegativeInfinity);
            }

            var valuesToTest = new List<List<SoundPoint>>();
            for (var i = dimensions * k + start; i < start + size; i += step)
            {
                var temp = new List<SoundPoint>();
                for (var j = 0; j < dimensions; j++)
                {
                    temp.Add(values[i - j * k]);
                }

                valuesToTest.Add(temp);
            }

            var comparer = new SoundPointComparer(precision);
            var distances = new List<long>();
            var indexForDistance = 0;
            for (var i = 0; i < 20; i++)
            {
                var index = useRandomValues ? _random.Next(0, Math.Min(100, valuesToTest.Count)) : indexForDistance;
                var distance = GetDistance(valuesToTest, index, comparer);
                if (distance.success)
                {
                    distances.Add(distance.value);
                }

                indexForDistance += 5;
            }

            if (distances.Count == 0) return (false, double.PositiveInfinity);
            var calculated = useMedian ? GetMedian(distances) : distances.Average();
            return (true, 1d / calculated * SampleRate);
        }
    }
}