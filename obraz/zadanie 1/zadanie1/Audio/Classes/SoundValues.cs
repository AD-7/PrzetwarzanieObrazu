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

        public struct SoundPoint
        {
            public float Value;
            public long Time;
        }

        //TODO: Pominąć pierwszych kilkanaście/kilkadziesiąt wartości, ✔
        //TODO: zatrzymać po pierwszym powtórzeniu, ✔
        //TODO: wyciągnąć medianę,
        //TODO: dodać wymiary, ✔
        //TODO: podział na ramki,
        //TODO: jeżeli pierwsza odległość jest za mała to przerwać,
        //TODO: startowanie z kilku miejsc
        public double CalculateFrequency(int step, int start, int k, int size, float precision, int dimensions)
        {
            if (dimensions * k + start > Values.Count) return double.NegativeInfinity;
            if (dimensions * k + start > start + size) return double.NegativeInfinity;
            var valuesToTest = new List<List<SoundPoint>>();
            for (var i = dimensions * k + start; i < start + size; i += step)
            {
                var temp = new List<SoundPoint>();
                for (var j = 0; j < dimensions; j++)
                {
                    temp.Add(Values[i - j * k]);
                }

                valuesToTest.Add(temp);
            }

            var comparer = new SoundPointComparer(precision);
            var first = valuesToTest[0];
            var index = 15;
            var indices = new List<int>();
            for (; index < valuesToTest.Count; index++)
            {
                if (first.SequenceEqual(valuesToTest[index], comparer))
                    break;
            }
            if(index < valuesToTest.Count) indices.Add(index);
            for (; index < valuesToTest.Count; index++)
            {
                if (first.SequenceEqual(valuesToTest[index], comparer))
                    break;
            }
            if(index < valuesToTest.Count) indices.Add(index);
            for (; index < valuesToTest.Count; index++)
            {
                if (first.SequenceEqual(valuesToTest[index], comparer))
                    break;
            }
            if(index < valuesToTest.Count) indices.Add(index);
            var results = new List<double>();
            for (int i = 0; i < indices.Count; i++)
            {
                results.Add(-(1d / (first[0].Time - valuesToTest[indices[i]][0].Time)) * SampleRate);
            }
            
            if (results.Count == 0) return double.PositiveInfinity;
            return results.Average();
        }

        // public double CalculateFrequency(int step, int k, int size, float precision, int dimensions)
        // {
        //     var valuesToTest = new List<(SoundPoint x, SoundPoint y, SoundPoint z, SoundPoint w)>();
        //     for (var i = 4 * k; i < size; i += step)
        //     {
        //         valuesToTest.Add((Values[i], Values[i - k], Values[i - 2 * k], Values[i - 4 * k]));
        //     }
        //
        //     for (var i = 0; i < 4 * k; i += step)
        //     {
        //         valuesToTest.Add((Values[i], Values[Values.Count - k],
        //             Values[Values.Count - 2 * k],
        //             Values[Values.Count - 4 * k]));
        //     }
        //
        //     var comparer = new SoundPointComparer(precision, dimensions);
        //     var list = valuesToTest.GroupBy(g => (g.x.Value, g.y.Value, g.z.Value, g.w.Value), g => g, comparer)
        //         .Where(g => g.Count() > 1)
        //         .Select(g => g.ToList()).ToList();
        //
        //     var sumOfSum = new List<double>();
        //     foreach (var group in list)
        //     {
        //         var sum = new List<double>();
        //         for (var i = 0; i < group.Count - 1; i++)
        //         {
        //             switch (dimensions)
        //             {
        //                 case 2:
        //                     sum.Add(Math.Abs(group[i + 1].x.Time - group[i].x.Time));
        //                     sum.Add(Math.Abs(group[i + 1].y.Time - group[i].y.Time));
        //                     break;
        //                 case 3:
        //                     sum.Add(Math.Abs(group[i + 1].x.Time - group[i].x.Time));
        //                     sum.Add(Math.Abs(group[i + 1].y.Time - group[i].y.Time));
        //                     sum.Add(Math.Abs(group[i + 1].z.Time - group[i].z.Time));
        //                     break;
        //                 case 4:
        //                     sum.Add(Math.Abs(group[i + 1].x.Time - group[i].x.Time));
        //                     sum.Add(Math.Abs(group[i + 1].y.Time - group[i].y.Time));
        //                     sum.Add(Math.Abs(group[i + 1].z.Time - group[i].z.Time));
        //                     sum.Add(Math.Abs(group[i + 1].w.Time - group[i].w.Time));
        //                     break;
        //             }
        //         }
        //
        //         sumOfSum.Add(sum.Average());
        //     }
        //
        //     var r = 1 / (sumOfSum.CheckIfEmpty().Average() * 0.001);
        //     return r;
        // }
    }
}