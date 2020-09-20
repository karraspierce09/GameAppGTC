using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTC
{
    class Fight
    {
        public void Battle(Detective1 character, Rooms room, Badguys badguys)
        {
            Console.WriteLine("Choose you weapon: \n");
            foreach (KeyValuePair<string, int> weapon in character.inventory)
            {
                if (weapon.Key == "gun" || weapon.Key == "gun")
                {
                    string item = Convert.ToString(weapon.Key).ToUpper();
                    Console.WriteLine(item);
                }
            }
        }
    }
}
