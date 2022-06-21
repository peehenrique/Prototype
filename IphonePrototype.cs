namespace Prototype;

public class IphonePrototype : SmartPhonePrototype
{
    protected IphonePrototype(IphonePrototype iphonePrototype)
    {
        _price = iphonePrototype.GetPrice();
    }

    public IphonePrototype()
    {
        _price = 0.0;
    }
    
    public override string ShowInfo()
    {
        return $"Modelo: Iphone 13 pro Max\nValor: R$ {GetPrice()}";
    }

    public override SmartPhonePrototype Clone()
    {
        return new IphonePrototype(this);
    }
}