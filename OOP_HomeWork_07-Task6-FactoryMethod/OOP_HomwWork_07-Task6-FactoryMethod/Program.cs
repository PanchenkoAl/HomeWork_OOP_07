class MainApp
{

    static void Main()
    {
        ICreator[] creators = new ICreator[2];
        creators[0] = new ConcreteCreator1();
        creators[1] = new ConcreteCreator2();
        
        foreach (ICreator creator in creators)
        {
            IProduct product = creator.FactoryMethod();
            Console.WriteLine("Created {0}", product.GetType().Name);
        }
        Console.ReadKey();
    }
}

interface IProduct
{
}

class ConcreteProduct1 : IProduct
{
}

class ConcreteProduct2 : IProduct
{
}

interface ICreator
{
    public IProduct FactoryMethod();
}

class ConcreteCreator1 : ICreator
{
    public IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}

class ConcreteCreator2: ICreator
{
    public IProduct FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}