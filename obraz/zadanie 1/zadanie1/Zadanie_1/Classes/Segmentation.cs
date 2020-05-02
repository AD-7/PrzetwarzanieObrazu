using System;
using System.Collections.Generic;
using System.Drawing;

namespace Zadanie_1.Classes
{
    public class Segmentation
    {
        private readonly struct PointColor
        {
            public readonly Color Color;
            public readonly int X;
            public readonly int Y;

            public PointColor(Color color, int x, int y)
            {
                Color = color;
                X = x;
                Y = y;
            }
        }

        private class RegionMask
        {
            private readonly int[,] _status;

            public RegionMask(int width, int height)
            {
                _status = new int[width, height];
                FillStatus();
            }

            public int GetStatus(int x, int y) => _status[x, y];

            public void SetStatus(int x, int y, int color) => _status[x, y] = color;

            private unsafe void FillStatus()
            {
                var length1 = _status.GetLength(0);
                var length2 = _status.GetLength(1);
                fixed (int* a = &_status[0, 0])
                {
                    var b = a;

                    for (var i = 0; i < length1; i++)
                    for (var j = 0; j < length2; j++)
                    {
                        *b++ = -10;
                    }
                }
            }
        }


        private int _threshold;

        public Image SourceImage;

        private readonly List<Point> _locations = new List<Point> {Point.Empty};
        private int _currentColor;

        public void ChangeLocation(int x, int y)
        {
            x = x < 0 ? 0 : x > SourceImage.Width ? SourceImage.Width - 1 : x;
            y = y < 0 ? 0 : y > SourceImage.Height ? SourceImage.Height - 1 : y;
            _locations[_currentColor] = new Point(x, y);
        }

        public void AddLocation()
        {
            _currentColor++;
            _locations.Add(Point.Empty);
        }

        public Segmentation()
        {
            _threshold = 10;
        }

        public int Threshold
        {
            set => _threshold = value < 1 ? 1 : value > 100 ? 100 : value;
        }

        public int CurrentColor => _currentColor;

        public Bitmap Process(Image originalImage, bool onlyMask = true)
        {
            var width = originalImage.Width;
            var height = originalImage.Height;

            var resultTemp = new Bitmap(originalImage);
            var empty = new Bitmap(width, height);
            var regionsMask = new FasterBitmap(empty);
            var result = new FasterBitmap(resultTemp);
            regionsMask.LockBits();
            result.LockBits();
            
            var seedPoints = PrepareSourcePoints(result);
            GrowRegions(result, regionsMask, seedPoints);
            ApplyMaskToResultImage(regionsMask, result);
            regionsMask.UnlockBits();
            result.UnlockBits();

            return onlyMask ? empty : resultTemp;
        }

        private void ApplyMaskToResultImage(FasterBitmap imageWithRegions, FasterBitmap result)
        {
            var width = result.Width;
            var height = result.Height;

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    if (_mask.GetStatus(x, y) >= 0)
                    {
                        result.SetPixel(x, y, imageWithRegions.GetPixel(x, y));
                    }
                }
            }
        }

        private PointColor[] PrepareSourcePoints(FasterBitmap image)
        {
            var sourcePoints = new PointColor[_currentColor + 1];

            for (var i = 0; i < _locations.Count; i++)
            {
                sourcePoints[i] = new PointColor(image.GetPixel(_locations[i].X, _locations[i].Y), _locations[i].X,
                    _locations[i].Y);
            }

            return sourcePoints;
        }

        private RegionMask _mask;

        private void GrowRegions(FasterBitmap original, FasterBitmap regionsMask, PointColor[] seeds)
        {
            var width = original.Width;
            var height = original.Height;
            var regions = 0;

            _mask = new RegionMask(width, height);

            foreach (var seed in seeds)
            {
                var min = seed.Color.GetGrayScale() - _threshold > 0 ? seed.Color.GetGrayScale() - _threshold : 0;
                var max = seed.Color.GetGrayScale() + _threshold < 255 ? seed.Color.GetGrayScale() + _threshold : 255;

                var stack = new Stack<PointColor>();

                if (_mask.GetStatus(seed.X, seed.Y) < 0)
                {
                    stack.Push(seed);

                    while (stack.Count > 0)
                    {
                        var fromStack = stack.Pop();
                        for (var x = -1; x < 2; x++)
                        {
                            for (var y = -1; y < 2; y++)
                            {
                                if (fromStack.X + x >= width || fromStack.X + x <= 0 ||
                                    fromStack.Y + y >= height || fromStack.Y + y <= 0)
                                {
                                    continue;
                                }
                                if (_mask.GetStatus(fromStack.X + x, fromStack.Y + y) >= 0)
                                {
                                    continue;
                                }

                                var fromNeighbourhood = new PointColor(
                                    regionsMask.GetPixel(fromStack.X + x, fromStack.Y + y), fromStack.X + x,
                                    fromStack.Y + y);

                                if (original.GetPixel(fromStack.X + x, fromStack.Y + y).GetGrayScale() <= max
                                    && original.GetPixel(fromStack.X + x, fromStack.Y + y).GetGrayScale() >= min)
                                {
                                    regionsMask.SetPixel(fromStack.X + x, fromStack.Y + y, original.GetPixel(seed.X, seed.Y));
                                    _mask.SetStatus(fromStack.X + x, fromStack.Y + y, Math.Abs(255 - regions));
                                    stack.Push(fromNeighbourhood);
                                }
                            }
                        }
                    }

                    regions++;
                }
            }
        }
    }
}