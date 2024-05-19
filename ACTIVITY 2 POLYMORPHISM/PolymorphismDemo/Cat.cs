namespace PolymorphismDemo.Models
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows.");
        }
    }
}
