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
            using var reader = new WaveFileReader(filename);
            using var channelStream = new WaveChannel32(reader);
            SampleRate = reader.WaveFormat.SampleRate;
            Values = new List<SoundPoint>();
            var temp = new List<SoundPoint>();
            for (int i = 0; i < reader.Length / 2; i++)
            {
                var v = reader.ReadNextSampleFrame();
                Values.Add(new SoundPoint
                {
                    Value = v[0],
                    Time = reader.CurrentTime.TotalMilliseconds
                });
            }
        }

        public struct SoundPoint
        {
            public float Value;
            public double Time;
        }

        public double CalculateFrequency(int step, int k, int size, float precision)
        {
            var valuesToTest = new List<(SoundPoint x, SoundPoint y, SoundPoint z)>();
            for (var i = 2 * k; i < size; i += step)
            {
                valuesToTest.Add((Values[i], Values[i - k], Values[i - 2 * k]));
            }

            for (var i = 0; i < 2 * k; i += step)
            {
                valuesToTest.Add((Values[i], Values[Values.Count - k],
                    Values[Values.Count - 2 * k]));
            }
            var comparer = new SoundPointComparer(precision);
            var list = valuesToTest.GroupBy(g => (g.x.Value, g.y.Value, g.z.Value), g => g, comparer)
                .Where(g => g.Count() > 1)
                .Select(g => g.ToList()).ToList();

            var sumOfSum = new List<double>();
            foreach (var group in list)
            {
                var sum = new List<double>();
                for (var i = 0; i < group.Count - 1; i++)
                {
                    sum.Add(Math.Abs(group[i + 1].x.Time - group[i].x.Time));
                    sum.Add(Math.Abs(group[i + 1].y.Time - group[i].y.Time));
                    sum.Add(Math.Abs(group[i + 1].z.Time - group[i].z.Time));
                }
                sumOfSum.Add(sum.Average());
            }

            var r = 1 / (sumOfSum.CheckIfEmpty().Average() * 0.001);
            return r;
        }
    }
}