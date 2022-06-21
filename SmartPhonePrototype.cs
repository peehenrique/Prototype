namespace Prototype;

public abstract class SmartPhonePrototype
{
    protected double _price;

    public abstract string ShowInfo();
    public abstract SmartPhonePrototype Clone();

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }
}