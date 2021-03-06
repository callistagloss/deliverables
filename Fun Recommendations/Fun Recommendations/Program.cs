﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Recommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            int userMood;
            string mood;
            string activity;
            int userFriends;
            string vehicle;

            Console.WriteLine("Hello, what are you in the mood for?");
            Console.WriteLine("Here are your options:\n");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chilling");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food\n");
            userMood = Convert.ToInt32(Console.ReadLine());

            switch (userMood)
            {
                case 1:
                    mood = "action";
                    activity = "stock car racing";
                    break;
                case 2:
                    mood = "chilling";
                    activity = "hiking";
                    break;
                case 3:
                    mood = "danger";
                    activity = "skydiving";
                    break;
                case 4:
                    mood = "good food";
                    activity = "to Taco Bell";
                    break;
                default:
                    mood = "";
                    activity = "";
                    break;
            }

            if (mood == "" || activity == "")
            {
                Console.WriteLine("Invalid input!");

            }
            else
            {
                Console.WriteLine("How many people are you bringing with you?");
                userFriends = Convert.ToInt32(Console.ReadLine());

                if (userFriends == 0)
                {
                    vehicle = "sneakers";
                }
                else if (userFriends < 5)
                {
                    vehicle = "a sedan";
                }
                else if (userFriends < 11)
                {
                    vehicle = "a Volkswagen bus";
                }
                else if (userFriends >= 11)
                {
                    vehicle = "an airplane";
                }
                else
                {
                    vehicle = "";
                }

                if (vehicle != "")
                {
                    Console.WriteLine("Okay, if you're in the mood for " + mood + ", then you should go " + activity + " and travel in " + vehicle + "!");
                }
            }
            Console.Read();

            Console.WriteLine("Goodbye.");

            Console.Read();
        }
    }
}
