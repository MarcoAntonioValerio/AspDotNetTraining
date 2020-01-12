using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNet
{
    class Program
    {
        static void MultipleLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.legs *= 2;
            petClass.legs *= 2;

            Console.WriteLine("Internal Method - A " + petStruct.type +  " has " + petStruct.legs + " legs.");
            Console.WriteLine("Internal Method - B " + petClass.type  +  " has " + petClass.legs  + " legs.");


        }

        static void Main(string[] args)
        {
            int[] intArray = new int[6];
            string[] stringArray = new string[6];

            int[] populatedIntArray = new int[] { 0, 1, 2, 3, 4 };
            string[] populatedString = new string[] { "One", "Two", "Three" };

            intArray[0] = 5;
            intArray[1] = 15;

            int firstValue = intArray[0];

            int[,] multiInt = new int[2, 3];
            int[,] multiPopulatedInt = { { 1, 2 }, { 5, 6} };


            PetStruct dog = new PetStruct();
            dog.type = PetType.Dog;
            dog.hasFur = true;
            dog.legs = 4;
            dog.name = "Sushi";


            PetClass duck = new PetClass();
            duck.type = PetType.Duck;
            duck.hasFur = false;
            duck.legs = 2;
            duck.name = "Derpy";

            Console.WriteLine("A " + dog.type + " has " + dog.legs + " legs.");
            Console.WriteLine("A " + duck.type + " has " + duck.legs + " legs.");

            MultipleLegs(dog, duck);
            Console.WriteLine("A " + dog.type + " has " + dog.legs + " legs.");
            Console.WriteLine("A " + duck.type + " has " + duck.legs + " legs.");

            Console.ReadLine();



        }
    }

    class PetClass
    {
        public int legs;
        public PetType type;
        public string name;
        public bool hasFur;
    }

    struct PetStruct
    {
        public int legs;
        public PetType type;
        public string name;
        public bool hasFur;
    }

    enum PetType
    { 
        Dog,
        Duck
    }
}
