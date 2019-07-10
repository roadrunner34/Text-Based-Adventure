using System;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, and Welcome to the World!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("This is be an adventure for you to and a way for me to show what I learned.\n" +
                                "What we need to do first is get some information about you.\n"+
                                "What is your name?");
            string HeroName = Console.ReadLine();
            Console.WriteLine("Hello "+HeroName+", glad to have you with us on this journey.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Now we neeed to know a couple more things about you please choose a number from below for us to know what class you are.\n" +
                                "1. Rogue \n" +
                                "2. Knight \n" +
                                "3. Wizard \n" +
                                "4. Ranger"); 
            int HeroClass = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            if (HeroClass == 1)
            {
                Console.WriteLine("Ah, a wiley one are we?  We'll have to keep an eye on you Rogue "+HeroName);
            }
            else if(HeroClass == 2)
            {
                Console.WriteLine("Hello honorable one.  May your strengh keep us on task Knight "+HeroName);
            }
            else if(HeroClass == 3)
            {
                Console.WriteLine("Greetings Wizard "+HeroName+". May your magic guide us.");
            }
            else if(HeroClass==4)
            {
                Console.WriteLine("Oooh, you'll be great when adventuring out of towns.  Welcome Ranger "+HeroName);
            }
            else
            {
                Console.WriteLine("There were 4 options, and you couldn't even pick one?  Come on "+HeroName);
            }


        }
    }
}
