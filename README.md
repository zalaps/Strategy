# Strategy
Implementation SImUDuck - Strategy Pattern Example. Image credits to HeadFirst series of O'REILLY

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
