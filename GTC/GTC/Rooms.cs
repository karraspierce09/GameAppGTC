﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GTC.Detective1;

namespace GTC
{
   
    public class Rooms
    {
        public string name { get; set; }
       
        public int building { get; set; }
        public Rooms up { get; set; }
        public Rooms down { get; set; }
        public Rooms left { get; set; }
        public Rooms right { get; set; }

        public Officer officer { get; set; }


        public void Room(string _name, int _blg, Rooms _up, Rooms _down, Rooms _right, Rooms _left)
        {
            name = _name;
            building = _blg;
            up = _up;
            down = _down;
            right = _right;
            left = _left;
            //officer = _officer;


        }

        public void GoToRoom(Rooms room, Detective1 character)
        {
            bool up = false;
            bool down = false;
            bool right = false;
            bool left = false;

            Console.WriteLine($"\nYou are in Building {room.building} - {room.name}.");
            
            FoundItem items = new FoundItem();


            Console.WriteLine("\nYou can go:");
            if (room.up != null && room.up.building != room.building)
            {
                Console.WriteLine($"UP to Building {Convert.ToString(room.up.building)} - {Convert.ToString(room.up.name)}");
              
                up = true;
            }
            else if (room.up != null)
            {
                Console.WriteLine($"UP to {Convert.ToString(room.up.name)}");
               
                up = true;
            }

            if (room.down != null && room.down.building != room.building)
            {
                Console.WriteLine($"DOWN to Building {Convert.ToString(room.down.building)} - {Convert.ToString(room.down.name)}");
                
                down = true;
            }
            else if (room.down != null && room.down.building == room.building)
            {
                Console.WriteLine($"DOWN to {Convert.ToString(room.down.name)}");
                
                down = true;
            }


            if (room.right != null && room.right.building != room.building)
            {
                Console.WriteLine($"RIGHT to Building {Convert.ToString(room.right.building)} - {Convert.ToString(room.right.name)}");
                right = true;
            }
            else if (room.right != null)
            {
                Console.WriteLine($"RIGHT to {Convert.ToString(room.right.name)}");
                right = true;
            }

            if (room.left != null && room.left.building != room.building)
            {
                Console.WriteLine($"LEFT to Building {Convert.ToString(room.left.building)} - {Convert.ToString(room.left.name)}");
                left = true;
            }
            else if (room.left != null)
            {
                Console.WriteLine($"LEFT to {Convert.ToString(room.left.name)}");
                left = true;
            }

            string response = Console.ReadLine().ToLower();
            Console.Clear();
            switch (response)
            {
                case "up":
                    if (up)
                    {
                        room.GoToRoom(room.up, character);
                    }
                    break;
                case "down":
                    if (down)
                    {
                        room.GoToRoom(room.down, character);
                    }
                    break;
                case "right":
                    if (right)
                    {
                        room.GoToRoom(room.right, character);
                    }
                    break;
                case "left":
                    if (left)
                    {
                        room.GoToRoom(room.left, character);
                    }
                    break;
                default:
                    Console.WriteLine("Please choose a valid option...");
                    GoToRoom(room, character);
                    break;
            }
            Console.WriteLine("Please choose a valid option...");
            GoToRoom(room, character);
        }
    }
}
