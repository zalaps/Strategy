
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsole.Step2
{
    public abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quack.. Quack.. from Duck!");
        }

        public void Swim()
        {
            Console.WriteLine("I'm Duck and I can swim!");
        }

        // New behaviuor added
        public void Fly()
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
    }
}
