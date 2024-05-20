using System;

namespace areaCalc
{
    internal class Triangle : BaseArea, ILength
    {
        private double _length;


        public Triangle(double length)
        {
            _length = length;
        }

        public override string Name => "三角形";

        public double Length => _length;

        public override double AreaValue()
        {
            return (1.0 / 4) * Math.Sqrt(3) * _length * _length;
        }
    }
}
