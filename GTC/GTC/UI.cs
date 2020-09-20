using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static GTC.Detective1;

namespace GTC
{
    public class UI
    {
        public void Run()
        {

            Detective1 detective = new Detective1() { };
            detective.Greeting(detective);
            detective.name = Console.ReadLine();
            Console.WriteLine($"\nDetective {detective.name} glade your here.");

            Rooms ParkingLot = new Rooms() { };
            Rooms Shed = new Rooms() { };
            Rooms School = new Rooms() { };
            
            
            ParkingLot.Room("Parkinglot", 1, null, null, School, Shed );
            
            Shed.Room("Shed", 1, null, null, ParkingLot, null);
           
            School.Room("school", 1, null, null, null, ParkingLot); 
            


            Rooms start = new Rooms();
            start.GoToRoom(ParkingLot, detective);
        }

        
    }
        
}
