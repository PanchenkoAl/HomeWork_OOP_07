using System;
namespace Decorator.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators
            ConcreteChristmasTree c = new ConcreteChristmasTree();
            ConcreteDecorator1 d1 = new ConcreteDecorator1();
            ConcreteDecorator2 d2 = new ConcreteDecorator2();
            // Link decorators
            d1.SetChristmasTree(c);
            d2.SetChristmasTree(d1);
            d2.Shine();
            Console.ReadKey();
        }
    }
    public abstract class ChristmasTree
    {
        public abstract void Shine();
    }
    public class ConcreteChristmasTree : ChristmasTree
    {
        public override void Shine()
        {
            Console.WriteLine("Shining");
        }
    }
    public abstract class Decorator : ChristmasTree
    {
        protected ChristmasTree christmasTree;
        public void SetChristmasTree(ChristmasTree christmasTree)
        {
            this.christmasTree = christmasTree;
        }
        public override void Shine()
        {
            if (christmasTree != null)
            {
                christmasTree.Shine();
            }
        }
    }
    public class ConcreteDecorator1 : Decorator
    {
        public override void Shine()
        {
            base.Shine();
            Console.WriteLine("Shine Dec1");
        }
    }
    public class ConcreteDecorator2 : Decorator
    {
        public override void Shine()
        {
            base.Shine();
            Console.WriteLine("Shine Dec2");
        }
    }
}
