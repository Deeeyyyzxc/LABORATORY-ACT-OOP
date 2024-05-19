using System;
using PolymorphismDemo.Models;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Animal objects
            Animal[] animals = new Animal[]
            {
                new Animal(),
                new Dog(),
                new Cat()
            };

            // Iterate through the array and call MakeSound on each object
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
