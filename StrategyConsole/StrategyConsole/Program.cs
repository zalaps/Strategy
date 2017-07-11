using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Joe works for a company that makes a highly successful duck pond simulation game. 
             *  The game can show a large variety of duck species swimming and making quacking sounds. 
             *  The initial designers of the system used standard OO techniques. 
             *  They created one Duck superclass from which all other duck types inherit.
             */
            Method1();

            /*  In the last year, the company has been under increasing pressure from competitors. 
             *  The company executives think it’s time for a big innovation. 
             *  They need something really impressive to show at the upcoming shareholders meeting next week.
             *  They decided that flying ducks is just what required to blow away the other competitors.
             *  And of course Joe’s manager told them it’ll be no problem for Joe to just whip something up in a week. 
             *  “After all”, said Joe’s boss, “he’s an OO programmer... how hard can it be?”
             *  Just add fly behaviour to Duck class!
             */
            Method2();

            /*  Shareholder’s meeting failed miserably! 
             *  They just gave a demo and there were rubber duckies flying around the screen. 
             *  Now Joe is in fix! He failed to notice that not all subclasses of Duck should fly.
             *  He could always just override the fly() method in rubber duck.
             *  This help him to define custom behaviour for both fly & quack. 
             */
            Method3();

            /*  But then what happens when we add wooden ducks to the program? 
             *  They aren’t supposed to fly or quack. Override again?
             *  Joe realized that inheritance probably wasn’t the answer. 
             *  He knows the spec will keep changing and he’ll be forced to look at and possibly override 
             *  fly() and quack() for every new Duck subclass that’s ever added to the program.
             *  Forever... 
             *  We need a cleaner way to have only some (but not all) of the duck types fly or quack.
             *  How about using Interface?
             *  Joe could take the fly() out of the Duck superclass, and make a Flyable() interface with a fly() method. 
             *  That way, only the ducks that are supposed to fly will implement interface and have a fly() method.
             */
            Method4();

            /*  Not all subclasses should have flying or quacking behavior, so inheritance isn’t the right answer. 
             *  Use of interface solves part of the problem (no inappropriately flying rubber ducks), But...
             *  It completely destroys code reuse, so it just creates a different maintenance nightmare. 
             *  
             *  DP#1            
             *  Separate what changes from what stays the same.
             *  
             *  Now, to separate the “parts that change from those that stay the same”, 
             *  Create two sets of classes (apart from Duck), one for fly and one for quack. 
             *  Each set of classes will hold all the implementations of their respective behavior. 
             *  For instance, one class that implements quacking, another that implements squeaking, and another that implements silence.
             *  
             *  DP#2
             *  Program to an interface, not an implementation.
             */
            Method5();

            /*  What a shame to have dynamic ducks and not be using it!
             *  Imagine you want to set the duck’s behavior type through a setter method on the duck subclass, 
             *  rather than by instantiating it in the duck’s constructor.
             *  
             *  DP#3
             *  Favor composition over inheritance.
             *  
             *  The Strategy Pattern defines 
             *  A family of algorithms, encapsulates each one, and makes them interchangeable. 
             *  Strategy lets the algorithm vary independently from clients that use it.
             */
            Method6();
        }

        public static void Method1()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Step 1--------------------------------------");

            var redhead = new Step1.RedheadDuck();
            redhead.Display();
            redhead.Quack();
            redhead.Swim();            

            Console.WriteLine("--------------------------------------------");

            var white = new Step1.WhiteDuck();
            white.Display();
            white.Quack();
            white.Swim();            
        }

        public static void Method2()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Step 2--------------------------------------");

            var redhead = new Step2.RedheadDuck();
            redhead.Display();
            redhead.Quack();
            redhead.Swim();
            redhead.Fly(); // Newly added

            Console.WriteLine("--------------------------------------------");

            var white = new Step2.WhiteDuck();
            white.Display();
            white.Quack();
            white.Swim();
            white.Fly(); // Newly added

            Console.WriteLine("--------------------------------------------");

            var rubber = new Step2.RubberDuck();
            rubber.Display();
            rubber.Quack();
            rubber.Swim();
            rubber.Fly(); // Newly added
        }

        public static void Method3()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Step 3--------------------------------------");

            var redhead = new Step3.RedheadDuck();
            redhead.Display();
            redhead.Quack();
            redhead.Swim();
            redhead.Fly(); // Newly added

            Console.WriteLine("--------------------------------------------");

            var white = new Step3.WhiteDuck();
            white.Display();
            white.Quack();
            white.Swim();
            white.Fly(); // Newly added

            Console.WriteLine("--------------------------------------------");

            var rubber = new Step3.RubberDuck();
            rubber.Display();
            rubber.Quack();
            rubber.Swim();
            rubber.Fly(); // Newly added
        }

        public static void Method4()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Step 4--------------------------------------");

            var redhead = new Step4.RedheadDuck();
            redhead.Display();
            redhead.Quack(); // From Interface
            redhead.Swim();
            redhead.Fly(); // From Interface

            Console.WriteLine("--------------------------------------------");

            var white = new Step4.WhiteDuck();
            white.Display();
            white.Quack(); // From Interface
            white.Swim();
            white.Fly(); // From Interface

            Console.WriteLine("--------------------------------------------");

            var rubber = new Step4.RubberDuck();
            rubber.Display();
            rubber.Quack(); // From Interface
            rubber.Swim();
            //rubber.Fly(); // Not implemented

            Console.WriteLine("--------------------------------------------");

            var wooden = new Step4.WoodenDuck();
            wooden.Display();
            //wooden.Quack(); // Not implemented
            wooden.Swim();
            //wooden.Fly(); // Not implemented
        }

        public static void Method5()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Step 5--------------------------------------");

            var redhead = new Step5.RedheadDuck();
            redhead.Display();            
            redhead.Swim();
            redhead.PerformFly();
            redhead.PerformQuack();    

            Console.WriteLine("--------------------------------------------");

            var white = new Step5.WhiteDuck();
            white.Display();
            white.PerformQuack(); // From Interface
            white.Swim();
            white.PerformFly(); // From Interface

            Console.WriteLine("--------------------------------------------");

            var rubber = new Step5.RubberDuck();
            rubber.Display();
            rubber.PerformQuack(); // From Interface
            rubber.Swim();
            rubber.PerformFly(); // From Interface

            Console.WriteLine("--------------------------------------------");

            var wooden = new Step5.WoodenDuck();
            wooden.Display();
            wooden.PerformQuack(); // From Interface
            wooden.Swim();
            wooden.PerformFly(); // From Interface
        }

        public static void Method6()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Step 6--------------------------------------");

            //doing preset behaviours
            var random = new Step6.RandomDuck();
            random.Display();
            random.Swim();
            random.PerformFly();
            random.PerformQuack();

            Console.WriteLine("--------------------------------------------");

            //seting some random behaviour
            random.SetFlyBehaviour(new Step6.FlyWithWings());
            random.SetQuackBehaviour(new Step6.Squeak());
            random.PerformFly();
            random.PerformQuack();
        }
    }
}
