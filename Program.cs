using System;
using System.Collections.Generic;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human matt = new Human("matt", 3, 90, 3, 100);
            Human zoe = new Human("zoe", 3, 90, 3, 100);


            System.Console.WriteLine(matt.Name);
            System.Console.WriteLine(zoe.Name);
            System.Console.WriteLine(matt.Strength);
            System.Console.WriteLine(matt.Intelligence);
            System.Console.WriteLine(matt.Dexterity);
            System.Console.WriteLine(matt.health);



            matt.Attack(zoe);
            System.Console.WriteLine(zoe.health);


            zoe.TakeDmg(10);
            zoe.Attack(matt);


            System.Console.WriteLine(matt.health);
            System.Console.WriteLine(zoe.health);

        }
        class Human
        {
            // Fields for Human
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int Health;

            public int health
            {
                get { return Health; }
            }
            //get 
            public Human(string firstName, int str, int iq, int dex, int hp)
            {
                Name = firstName;
                Strength = str;
                Intelligence = iq;
                Dexterity = dex;
                Health = hp;


            }
            public int Attack(Human target)
            {
                if (target is Human)
                {
                    int dmg = 5 * Strength;
                    target.Health -= dmg;

                    Console.WriteLine($"{Name} attack {target.Name}");
                    return target.Health;
                }
                else
                {
                    throw new Exception("Attack");
                }
            }

            public int TakeDmg(int dmg)
            {
                Health -= dmg;

                Console.WriteLine($"{Name} dyinggg");
                return Health;
            }

        }
    }
}