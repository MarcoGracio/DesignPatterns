using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Cream(new Sugar(new Expresso(2))).GetDesc());
        }
    }

    abstract class Bevarage
    {
        public abstract string GetDesc();
    }

    class Expresso : Bevarage
    {
        public Expresso(int a)
        {
            int b = a + a;
        }

        public override string GetDesc()
        {
            return "Expresso";
        }
    }

    class Decafe : Bevarage
    {
        public override string GetDesc()
        {
            return "Decafe";
        }
    }


    abstract class AddonDecorator : Bevarage
    {
        protected Bevarage bevarage;
    }

    class Sugar : AddonDecorator
    {
        public Sugar(Bevarage bev)
        {
            this.bevarage = bev;
        }

        public override string GetDesc()
        {
            return this.bevarage.GetDesc() + "Sugar";
        }
    }
    class Cream : AddonDecorator
    {
        public Cream(Bevarage bev)
        {
            this.bevarage = bev;
        }

        public override string GetDesc()
        {
            return this.bevarage.GetDesc() + "Cream";
        }
    }
}
