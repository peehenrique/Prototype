using Prototype;

var iphonePrototype = new IphonePrototype();

var iphoneNew = iphonePrototype.Clone();
iphoneNew.SetPrice(2300.0);

var iphoneUsed = iphonePrototype.Clone();
iphoneUsed.SetPrice(1700.0);

Console.WriteLine(iphoneNew.ShowInfo());

Console.WriteLine(iphoneUsed.ShowInfo());