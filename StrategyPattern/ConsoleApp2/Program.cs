
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var duck = new NormalDuck();
            Console.WriteLine(duck.PerformQuack());

            duck.SetBehaviour(new QuackNone());
            Console.WriteLine(duck.PerformQuack());
            Console.ReadLine();
        }
    }
    class Duck
    {
        public QuackBehaviour quackBehaviour { get; set; }
        public string PerformQuack()
        {
            return quackBehaviour.Quack();
        }

        public void SetBehaviour(QuackBehaviour behaviour)
        {
            quackBehaviour = behaviour;
        }
    }

    class NormalDuck : Duck
    {
        public NormalDuck()
        {
            quackBehaviour = new QuackNormal();
        }
    }

    class WoodDuck : Duck
    {
        public WoodDuck()
        {
            quackBehaviour = new QuackNone();
        }

    }

    interface QuackBehaviour
    {
        public string Quack();
    }

    class QuackNormal : QuackBehaviour
    {
        public string Quack()
        {
            return "quack!!";
        }
    }

    class QuackNone : QuackBehaviour
    {
        public string Quack()
        {
            return "silence!";
        }
    }
}