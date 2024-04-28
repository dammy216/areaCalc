namespace areaCalc
{
    internal class Square : BaseArea
    {
        private double _length;
        public Square(double length)
        {
            _length = length;
        }

        public override string Name => "四角形";

        public override double AreaValue()
        {
            return _length * _length;
        }
    }
}
