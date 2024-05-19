
using System;

namespace InheritanceExample
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }
}
