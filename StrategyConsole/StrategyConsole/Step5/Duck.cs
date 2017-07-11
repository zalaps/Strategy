
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsole.Step5
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

    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            base.FlyBehaviour = new FlyWithWings();
            base.QuackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I've a red head!");
        }     
    }

    public class WhiteDuck : Duck
    {
        public WhiteDuck()
        {
            //code reutilization
            base.FlyBehaviour = new FlyWithWings();
            base.QuackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I've a white feathers!");
        }     
    }
    
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {                       
            base.QuackBehaviour = new Squeak();
            base.FlyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm made up of rubber! I can not fly");
        }
    }

    //No composition required at all
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            //code reutilization            
            base.QuackBehaviour = new MuteQuack();
            base.FlyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm made up of wood! I do not quack or fly!");
        }
    }
}
