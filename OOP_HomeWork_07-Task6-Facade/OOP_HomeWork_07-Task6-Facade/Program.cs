public class Program
{
    public static void Main(string[] args)
    {
        Facade facade = new Facade();
        facade.Show1();
        facade.Show2();
        Console.ReadKey();
    }
}
public class HiddenOne
{
    public void FOne()
    {
        Console.WriteLine(" Hidden1");
    }
}
public class HiddenTwo
{
    public void FTwo()
    {
        Console.WriteLine(" Hidden2");
    }
}
public class HiddenThree
{
    public void FThree()
    {
        Console.WriteLine(" Hidden3");
    }
}
public class HiddenFour
{
    public void FFour()
    {
        Console.WriteLine(" Hidden4");
    }
}
public class Facade
{
    HiddenOne one;
    HiddenTwo two;
    HiddenThree three;
    HiddenFour four;
    public Facade()
    {
        one = new HiddenOne();
        two = new HiddenTwo();
        three = new HiddenThree();
        four = new HiddenFour();
    }
    public void Show1()
    {
        Console.WriteLine("Show1 ---- ");
        one.FOne();
        two.FTwo();
        four.FFour();
    }
    public void Show2()
    {
        Console.WriteLine("Show2 ---- ");
        two.FTwo();
        three.FThree();
    }
}