using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            Console.WriteLine("1) Muestre los números impares");

            var oddNumbers = from x in numbers
                             where x % 2 == 1
                             select x;

            Console.WriteLine(string.Join(", ", oddNumbers));
            Console.WriteLine("-----------------");

            Console.WriteLine("2) Muestre los números impares con Lambda Expression");

            var oddNumbersLambda = numbers.Where(x => (x % 2 == 1));

            Console.WriteLine(string.Join(", ", oddNumbersLambda));
            Console.WriteLine("-----------------");

            List<Warrior> warriors = new List<Warrior>()
            {
                new Warrior(){Height=100},
                new Warrior(){Height=80},
                new Warrior(){Height=100},
                new Warrior(){Height=70},
            };

            Console.WriteLine("3) Muestre la altura de los guerreros con Lambda Expression");

            warriors.ForEach(x => Console.WriteLine(x.Height));

            Console.WriteLine("-----------------");
        }
    }
}
