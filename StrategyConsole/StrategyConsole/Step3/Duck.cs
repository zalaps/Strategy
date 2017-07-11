
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsole.Step3
{
    public abstract class Duck
    {
        // Method is virtual, sub class can have their version.
        public virtual void Quack()
        {
            Console.WriteLine("Quack.. Quack.. from Duck!");
        }

        public void Swim()
        {
            Console.WriteLine("I'm Duck and I can swim!");
        }

        // New behaviuor added
        // Method is virtual, sub class can have their version.
        public virtual void Fly()
        {
            Console.WriteLine("I'm Duck and I can Fly!");
        }

        public abstract void Display();
    }

    public class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I've a red head!");
        }
    }

    public class WhiteDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I've a white feathers!");
        }
    }

    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm made up of rubber!");
        }

        public override void Quack()
        {
            Console.WriteLine("Squeak.. Squeak.. from rubber duck!");
        }

        public override void Fly()
        {
            Console.WriteLine("Oops! I can't fly :(");
        }
    }
}
