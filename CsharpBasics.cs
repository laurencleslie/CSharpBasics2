using System;

namespace Basics
{
    class Program
    {
        public static void Main()
        {
        byte sample1, sample2;
        sample1= 0x3A;
        sample2=58;

        int heartRate choice;
        heartRate=85;
        choice=2;

        double deposits, distance;
        deposits=135002796;
        distance= 129.763001;

        float mass;
        mass=14.6;

        bool lost, expensive;
        lost=true;
        expensive=true;
       
        char integral = \u222B;

        String greeting, name;
        greeting= "Hello";
        name="Karen";
        
        Program p=new Program();
        p.compare();
        p.heartRate();
        p.depos();
        p.force();
        p.bools();
        p.choices();
        p.integ();
        p.useLoop();
        }
        public void compare()
        {
            if(sample1==sample2)
            Console.WriteLine("The samples are equal");
            else
            {
                Console.WriteLine("The samples are not equal");
            }
        }
        public void heartRate()
        {
            if(heartRate>=40 && heartRate<=80)
                Console.WriteLine("Heart rate is normal");            
             else
             Console.WriteLine("Heart rate is not normal");
        }

        public void depos()
        {
            if(deposits>=100000000)
            Console.WriteLine("You are exceedingly wealthy");
            else
            Console.WriteLine("Sorr you are so poor");
        }
        public void force()
        {
            float force;
            force= mass*acceleration;
            Console.WriteLine("Force= ", force, "is the distance");
        }
        public void bools()
        {
           if(lost==true && expensive==true)
           {
               Console.WriteLine("I am really sorry! I will get the manager");
           }
           if(lost==true && expensive==false)
           {
               Console.WriteLine("Here is a coupon for 10% off");
           }
        }
        public void choices()
        {
            switch(choice)
            {
                case 1:
                Console.WriteLine("You chose  1");
                break;
                case 2:
                Console.WriteLine("You chose 2");
                break;
                case 3:
                Console.WriteLine("You chose 3");
                break;
                defalut:
                Console.WriteLine("You made an unknown choice");
                break;
            }
        }
        
        public void integ()
        {
          Console.Writeline(integral, "Is an integral");
        }
        public void useLoop()
        {
            for(int i=5; i<10; i++)
            {
               Console.WriteLine("i=",  i);
            }
            int age=0;

            while(age<6)
            {
                Console.WriteLine("age=", age);
                age++;
            }
        }
        public void Greet()
        {
            Console.WriteLine(greeting, name);
        }
    }
    
}
