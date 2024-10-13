using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classobjectmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select (Dog, Bird, Bear):");
            string animalType = Console.ReadLine();
            Animal animal;

            switch (animalType)
            {
                case "Dog":
                    animal = new Dog();
                    Console.WriteLine("Enter the name:");
                    animal.Name = Console.ReadLine();
                    Console.WriteLine("Enter the age:");
                    animal.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Does the dog have a tail?");
                    ((Dog)animal).HasTail = Console.ReadLine() == "yes";
                    break;


                case "Bird":
                    animal = new Bird();
                    Console.WriteLine("Enter the name:");
                    animal.Name = Console.ReadLine();
                    Console.WriteLine("Enter the age:");
                    animal.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Can the bird swim?");
                    ((Bird)animal).CanSwim = Console.ReadLine() == "yes";
                    break;


                case "Bear":
                    animal = new Bear();
                    Console.WriteLine("Enter the name:");
                    animal.Name = Console.ReadLine();
                    Console.WriteLine("Enter the age:");
                    animal.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Is the bear wild?");
                    ((Bear)animal).isWild = Console.ReadLine() == "yes";
                    break;

                default:
                    Console.WriteLine("Choose one of these animals");
                    return;
            }

            Console.WriteLine($"Animal type: {animalType}");
            Console.WriteLine($"Name: {animal.Name}");
            Console.WriteLine($"Age: {animal.Age}");
            animal.Eat();


            if (animal is Dog dog)
            {
                Console.WriteLine($"Has tail: {dog.HasTail}");
            }

            else if (animal is Bird bird)
            {
                Console.WriteLine($" Can swim: {bird.CanSwim}");
                bird.Fly();
            }

            else if (animal is Bear bear)
            {
                Console.WriteLine($" Is wild: {bear.isWild}");
            }

        }
    }
}
