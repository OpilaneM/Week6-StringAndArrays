﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab mis puuvilja kasutaja s66b;

            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };

            // Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);

            //Console.WriteLine("Enter a number from 0 to 4:");
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}");



            Console.Read();
        }
    }
}
