using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //1º scneario
            IBird bird = new Sparrow();
            bird.MakeSound();

            IToyDuck toyDuck = new PlasticToyDuck();
            toyDuck.Squeak();

            //Requirement: ToyDuck must MakeSound instead of Squeak wihtout changings
            //toyDuck.MakeSound();

            //solution: Create the BirdAdapter 
            toyDuck = new BirdAdapter(new Sparrow());
            toyDuck.Squeak(); //toy duck making sound!
        }
    }

    class BirdAdapter : IToyDuck
    {
        IBird Bird;
        public BirdAdapter(IBird bird)
        {
            Bird = bird;
        }
        public void Squeak()
        {
            Bird.MakeSound();
        }
    }

    interface IBird
    {
        public void Fly();
        public void MakeSound();
    }
    class Sparrow : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
        public void MakeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }

    interface IToyDuck
    {
        public void Squeak();
    }
    class PlasticToyDuck : IToyDuck
    {
        public void Squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
