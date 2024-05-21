using areaCalc;

public class Concrete : BaseArea
{
    private string _name;
    private double _areaValue;
    private double _length;
    public Concrete(string name, double areaValue)
    {
        _name = name;
        _areaValue = areaValue;
    }
    public override string Name => _name;


    public override double AreaValue() => _areaValue;
}
