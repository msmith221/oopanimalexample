﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a tiger and a caracal
            Species tiger = new Species("Tiger","Panthera tigris");
            Species caracal = new Species("Caracal");
            Family felidae = new Family("Felidae");
            felidae.numberOfTeeth = 30;
            felidae.numberOfToes = 5;

            tiger.setAttributes(felidae);
            caracal.setAttributes(felidae);

            Console.WriteLine("What is the name of the species?");
            string newSpeciesName = Console.ReadLine();
            Console.WriteLine("How many legs does it have?");
            int numLegs = 0;

            try
            {
                numLegs = int.Parse(Console.ReadLine());
            } catch (Exception ex)
            {
                Console.WriteLine("Couldn't make a number out of that, please try again, error was" + ex.ToString());
                while (numLegs <= 0)
                {
                    Console.WriteLine("How many legs does it have?");
                    try
                    {
                        numLegs = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex2) { }
                }

            }

            Species newObj = new Species(newSpeciesName, numLegs);

            Console.ReadLine();



        }
    }
}
