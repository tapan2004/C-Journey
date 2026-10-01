using System;

namespace OOPsLearning
{
    // Interface = contract
    interface IAnimal
    {
        void Sound();
    }

    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }

    class Program
    {
        // static void Main(string[] args)
        // {
        //     IAnimal[] animals = new IAnimal[] { new Dog(), new Cat() };

        //     foreach (IAnimal animal in animals)
        //     {
        //         animal.Sound();
        //     }
        // }
    }
}
