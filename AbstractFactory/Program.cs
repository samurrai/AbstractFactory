using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    public void Main()
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new Samsung());
        ClientMethod(new Ford());
        ClientMethod(new Dell());
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ClientMethod(new Nokia());
        ClientMethod(new Toyota());
        ClientMethod(new Sony());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        IAbstractProductA productA = factory.CreateProductA();
        IAbstractProductB productB = factory.CreateProductB();

        Console.WriteLine(productB.GetInfo());
    }
}

public interface IAbstractProductA
{
    string GetInfo();
}
public interface IAbstractProductB
{
    string GetInfo();
}

public class Nokia : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new NokiaDisplay();
    }

    public IAbstractProductB CreateProductB()
    {
        return new NokiaAccumulator();
    }
}

internal class NokiaAccumulator : IAbstractProductB
{
    public string GetInfo()
    {
        return "Nokia accumulator";
    }
}

public class SamsungDisplay : IAbstractProductA
{
    public string GetInfo()
    {
        return "Samsung display";
    }
}

public class NokiaDisplay : IAbstractProductA
{
    public string GetInfo()
    {
        return "Nokia display";
    }
}


public class Samsung : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new SamsungDisplay();
    }

    public IAbstractProductB CreateProductB()
    {
        return new SamsungAccumulator();
    }
}

internal class SamsungAccumulator : IAbstractProductB
{
    public string GetInfo()
    {
        return "Samsung accumulator";
    }
}

public class Toyota : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ToyotaEngine();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ToyotaBody();
    }
}

internal class ToyotaBody : IAbstractProductB
{
    public string GetInfo()
    {
        return "Toyota body";
    }
}

public class FordEngine : IAbstractProductA
{
    public string GetInfo()
    {
        return "Ford engine";
    }
}

public class ToyotaEngine : IAbstractProductA
{
    public string GetInfo()
    {
        return "Toyota engine";
    }
}


public class Ford : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new FordEngine();
    }

    public IAbstractProductB CreateProductB()
    {
        return new FordBody();
    }
}

internal class FordBody : IAbstractProductB
{
    public string GetInfo()
    {
        return "Ford body";
    }
}

public class Sony : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new SonyMainboard();
    }

    public IAbstractProductB CreateProductB()
    {
        return new SonyProcessor();
    }
}

internal class SonyProcessor : IAbstractProductB
{
    public string GetInfo()
    {
        return "Sony processor";
    }
}

public class DellMainboard : IAbstractProductA
{
    public string GetInfo()
    {
        return "Dell mainboard";
    }
}

public class SonyMainboard : IAbstractProductA
{
    public string GetInfo()
    {
        return "Sony mainboard";
    }
}


public class Dell : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new DellMainboard();
    }

    public IAbstractProductB CreateProductB()
    {
        return new DellProcessor();
    }
}

internal class DellProcessor : IAbstractProductB
{
    public string GetInfo()
    {
        return "Dell processor";
    }
}

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

class Program
{
    static void Main(string[] args)
    {
        new Client().Main();
    }
}