using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new AfricaFactory();
            var animal = factory.CreateAnimal();
            Console.WriteLine("Nr: " + animal.NrAlive); 
        }
    }

    interface IFactory
    {
        WildAnimal CreateAnimal();
    }

    class AfricaFactory : IFactory
    {
        public WildAnimal CreateAnimal()
        {
            //imagine logic to achieve 1==2
            if (1==2)
            {
                WildAnimal animal = new Shark();
                //imagine very complex logic to calculate the NrAlive......
                animal.NrAlive = 2;
                return animal;
            }
            else
            {
                WildAnimal animal = new Lion();
                //imagine very complex logic to calculate the NrAlive......
                animal.NrAlive = 120;
                return animal;
            }
        }
    }

    class SouthAmericaFactory : IFactory
    {
        public WildAnimal CreateAnimal()
        {
            //imagine logic to achieve 1==1
            if (1==1)
            {
                WildAnimal animal = new Shark();
                //imagine very complex logic to calculate the NrAlive......
                animal.NrAlive = 0;
                return animal;
            }
            else
            {
                WildAnimal animal = new Lion();
                //imagine very complex logic to calculate the NrAlive......
                animal.NrAlive = 10;
                return animal;
            }
        }
    }

    abstract class WildAnimal
    {
        public int NrAlive { get; set; }
    }

    class Lion : WildAnimal
    {
    }

    class Shark : WildAnimal
    {
    }
}
