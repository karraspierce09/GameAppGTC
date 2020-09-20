using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GTC.Detective1;

namespace GTC
{
   public class Detective1
    {
        public string name;
        public int Health = 1;
        public int power = 1;
        public bool clue = false;
        public bool gun = false;
        public bool knife = false;
        public bool ToFight = false;
        public enum Officer { empty, School, Shed}

        

        public void Greeting(Detective1 name)
        {
            Console.WriteLine("Hello Detective, we have a case for you. \n" +
                "Have you ever heard of the case of the stolen Golden Toilet? (y/n)");
            string response = Console.ReadLine().ToLower();
            if (response == "y")
            {
                Console.WriteLine("OH!, so you've heard that it's hidden somewhere at that school you used to go to. \n" +
                    "Go down there and find it... We've heard some real bad eggs are trying to find it.\n" +
                    "Press ENTER to continue!");
            }
            else if (response == "n")
            {
                Console.WriteLine("OH! Wanna hear some crazy shit? \n" +
                    "Go down there and find it... We've heard some real bad eggs are trying to find it. \n" +
                    "Press ENTER to continue!");

            }
            else
            {
                Console.WriteLine("Press y or n, you jabroni!");
            }
        }

        public Dictionary<string, int> inventory = new Dictionary<string, int>();


        public void character(string _name)
        {
            name = _name;
            
        }

        public class OfficerLuther
        {

            public void Officer(Detective1 character, Rooms room)
            {
                Console.WriteLine($"\n{character.name}, Officer Luther came to talk to you");
                Console.ReadLine();
               
                
                
                
            }
        }

    }
}
