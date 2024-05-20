namespace areaCalc
{
    internal class Square : BaseArea, ILength
    {
        private double _length;
        public Square(double length)
        {
            _length = length;
        }

        public override string Name => "四角形";

        public double Length => _length;

        public override double AreaValue()
        {
            return _length * _length;
        }
    }
}
