
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsole.Step6
{
    public abstract class Duck
    {
        public IFlyable FlyBehaviour { get; set; }

        public IQuackable QuackBehaviour { get; set; }

        public void Swim()
        {
            Console.WriteLine("I'm Duck and I can swim!");
        }

        public abstract void Display();

        //Programmed to interface. No Concrete implementation used.
        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        //Programmed to interface. No Concrete implementation used.
        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }

        //Setting beviours dynamically
        public void SetFlyBehaviour(IFlyable ifb)
        {
            FlyBehaviour = ifb;
        }

        //Setting beviours dynamically
        public void SetQuackBehaviour(IQuackable iqb)
        {
            QuackBehaviour = iqb;
        }
    }

    #region Fly Behaviour
    // New interface has been added which can be implemented by who ever wants it.
    public interface IFlyable
    {
        void Fly();
    }

    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I fly with wings!");
        }
    }

    public class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Noways, I can Fly!");
        }
    }
    #endregion

    #region Quack Behaviour
    // New interface has been added which can be implemented by who ever wants it.
    public interface IQuackable
    {
        void Quack();
    }

    public class Quack : IQuackable
    {
        void IQuackable.Quack()
        {
            Console.WriteLine("I can quack!");
        }
    }

    public class Squeak : IQuackable
    {
        void IQuackable.Quack()
        {
            Console.WriteLine("I can Squeak!");
        }
    }

    public class MuteQuack : IQuackable
    {
        void IQuackable.Quack()
        {
            Console.WriteLine("I have no speech!");
        }
    }
    #endregion

    public class RandomDuck : Duck
    {
        public RandomDuck()
        {
            base.FlyBehaviour = new FlyNoWay();
            base.QuackBehaviour = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I've a red head!");
        }     
    }    
}
