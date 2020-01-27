using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRoleplayVer2
{
    class Program
    {
        public struct Monster
        {
            public string name;
            public string race;
            public float life;
            public float strength;
            public int rage;
        }
        public struct Hero
        {
            public string name;
            public string race;
            public string idiotita;
            public float life;
            public float strength;
            public int ressurection;
            public string status;
        }

        static void Main(string[] args)
        {
            Random selectFunction = new Random();
            Random critFunction = new Random();

            int select = selectFunction.Next(1, 3);
            int crit;

            float damage = 0, critDamage = 0;

            Monster polyphemus;
            polyphemus.name = "polyphemus";
            polyphemus.race = "Cyclops";
            polyphemus.life = 300;
            polyphemus.strength = 300;
            polyphemus.rage = 0;

            Monster medusa;
            medusa.name = "Medusa";
            medusa.race = "Serpent";
            medusa.life = 140;
            medusa.strength = 40;

            Hero odysseus;
            odysseus.name = "odysseus";
            odysseus.race = "Human";
            odysseus.idiotita = "Archer";
            odysseus.life = 1000;
            odysseus.strength = 35;
            odysseus.ressurection = 1;
            odysseus.status = "alive";

            Hero perseus;
            perseus.name = "perseus";
            perseus.race = "Human";
            perseus.idiotita = "Shieldbearer";
            perseus.life = 3000;
            perseus.strength = 10;

            do
            {

                if (select == 1)
                {
                    Console.WriteLine("---It is now the turn of polyphemus---");

                    damage = polyphemus.strength * 1;
                    critDamage = damage * 2;

                    polyphemus.rage = polyphemus.rage + 20;

                    crit = critFunction.Next(1, 5);

                    if (polyphemus.rage >= 100)
                    {
                        damage = polyphemus.strength * 4;
                        polyphemus.rage = 0;
                        Console.WriteLine("polyphemus used Mortal Strike");
                    }

                    if (crit != 1)
                    {
                        odysseus.life = odysseus.life - damage;
                        Console.WriteLine("polyphemus dealt --(O)=====> " + damage + " normal damage to odysseus");
                    }
                    else
                    {
                        odysseus.life = odysseus.life - critDamage;
                        Console.WriteLine("polyphemus dealt --(X)=====> " + critDamage + " !!CRITICAL!! damage to odysseus");
                    }

                    if (odysseus.life > 0 && odysseus.ressurection == 1)
                        odysseus.status = "alive";
                    else if (odysseus.life > 0 && odysseus.ressurection == 0)
                        odysseus.status = "alive";
                    else if (odysseus.life <= 0 && odysseus.ressurection == 1)
                    {
                        odysseus.status = "alive";
                        odysseus.ressurection = odysseus.ressurection - 1;
                        Console.WriteLine("odysseus died");
                        Console.WriteLine("odysseus casted ressurection!");
                        odysseus.life = 1000;
                    }
                    else if (odysseus.life <= 0 && odysseus.ressurection == 0)
                    {
                        Console.WriteLine("odysseus died");
                        odysseus.status = "dead";
                        break;
                    }

                    if (odysseus.status == "alive")
                    {
                        select = 2;
                    }

                }
                else if (select == 2 && odysseus.status == "alive")
                {
                    Console.WriteLine("---It is now the turn of odysseus---");

                    damage = odysseus.strength * 1;
                    critDamage = damage * 2;

                    crit = critFunction.Next(1, 5);

                    if (crit != 1)
                    {
                        polyphemus.life = polyphemus.life - damage;
                        Console.WriteLine("odysseus dealt --(O)=====> " + damage + " normal damage to polyphemus");
                    }
                    else
                    {
                        polyphemus.life = polyphemus.life - critDamage;
                        Console.WriteLine("odysseus dealt --(X)=====> " + critDamage + " !!CRITICAL!! damage to polyphemus");
                    }

                    if (polyphemus.life <= 0)
                    {
                        Console.WriteLine("polyphemus died");
                        break;
                    }
                    else
                        select = 1;
                }

            } while (polyphemus.life > 0 && medusa.life > 0 && perseus.life > 0 && odysseus.status == "alive");

            Console.ReadKey();
        }
    }
}