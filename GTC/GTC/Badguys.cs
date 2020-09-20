using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTC
{
    public class Badguys
    {
        public string name;
        public int Health;
        public int power;

        public void Guys(string _name, int _health, int _power)
        {
            name = _name;
            Health = _health;
            power = _power;
        }

        public void FoundBadGuys(Detective1 character, Rooms room, Badguys badguys)
        {
            Console.WriteLine("You have run into one of the robers. \n" +
                "Will you fight? yes/no");
            string fightResponse = Console.ReadLine().ToLower();
            if (fightResponse == "yes")
            {
                Console.WriteLine("Leave here and no gets hurt");
                Fight fight = new Fight();
                fight.Battle(character, room, badguys);
            }

            else if (fightResponse == "no")
            {
                Console.WriteLine("To day is your lucky day");
            }

            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
