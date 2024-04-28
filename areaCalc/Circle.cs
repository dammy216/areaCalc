using System;

namespace areaCalc
{
    internal class Circle : BaseArea
    {
        private double _length;

        public Circle(double length)
        {
            _length = length;
        }

        public override string Name => "円";

        public override double AreaValue()
        {
            return _length * _length * Math.PI;
        }
    }
}
