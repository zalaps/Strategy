
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsole.Step4
{
    public abstract class Duck
    {       
        public void Swim()
        {
            Console.WriteLine("I'm Duck and I can swim!");
        }
        
        public abstract void Display();
    }

    // New interface has been added which can be implemented by who ever wants it.
    public interface IFlyable
    {
        void Fly();
    }

    // New interface has been added which can be implemented by who ever wants it.
    public interface IQuackable
    {
        void Quack();
    }

    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I've a red head!");
        }

        // IFlyable implementation
        public void Fly()
        {
            Console.WriteLine("I can fly normally!");
        }

        // IQuackable implementation
        public void Quack()
        {
            Console.WriteLine("I can quack normally!");
        }
    }

    public class WhiteDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I've a white feathers!");
        }

        // IFlyable implementation
        public void Fly()
        {
            Console.WriteLine("I can fly normally!");
        }

        // IQuackable implementation
        public void Quack()
        {
            Console.WriteLine("I can quack normally!");
        }
    }

    // Only IQuackable is implemented
    public class RubberDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I'm made up of rubber! I can not fly");
        }

        // IQuackable implementation
        public void Quack()
        {
            Console.WriteLine("I Rubber one so I'll squaek!");
        }
    }

    //No extra interface is implemented
    public class WoodenDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm made up of wood! I do not quack or fly!");
        }       
    }
}
