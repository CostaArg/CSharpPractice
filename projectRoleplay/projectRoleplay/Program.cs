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
            polyphemus.name = "Polyphemus";
            polyphemus.race = "Cyclops";
            polyphemus.life = 300;
            polyphemus.strength = 1;
            polyphemus.rage = 0;

            Monster medusa;
            medusa.name = "Medusa";
            medusa.race = "Serpent";
            medusa.life = 140;
            medusa.strength = 15;

            Hero odysseus;
            odysseus.name = "Odysseus";
            odysseus.race = "Human";
            odysseus.idiotita = "Archer";
            odysseus.life = 1000;
            odysseus.strength = 1;
            odysseus.ressurection = 1;
            odysseus.status = "alive";

            Hero perseus;
            perseus.name = "Perseus";
            perseus.race = "Human";
            perseus.idiotita = "Shieldbearer";
            perseus.life = 3000;
            perseus.strength = 10;

            do
            {

                if (select == 1)
                {
                    Console.WriteLine("\n     ---It is now the turn of " + polyphemus.name + "---");

                    damage = polyphemus.strength * 1;
                    critDamage = damage * 2;

                    polyphemus.rage = polyphemus.rage + 20;

                    crit = critFunction.Next(1, 5);

                    if (polyphemus.rage >= 100)
                    {
                        damage = polyphemus.strength * 4;
                        polyphemus.rage = 0;
                        Console.WriteLine(polyphemus.name + " used Mortal Strike!");
                    }

                    if (crit != 1)
                    {
                        odysseus.life = odysseus.life - damage;
                        Console.WriteLine(polyphemus.name + " dealt --(O)=====> " + damage + " normal damage to " + odysseus.name);
                    }
                    else
                    {
                        odysseus.life = odysseus.life - critDamage;
                        Console.WriteLine(polyphemus.name + " dealt --(X)=====> " + critDamage + " !!CRITICAL!! damage to " + odysseus.name);
                    }

                    if (odysseus.life > 0 && odysseus.ressurection == 1)
                    {
                        odysseus.status = "alive";
                        Console.WriteLine(odysseus.name + " has " + odysseus.life + " hp");
                    }
                    else if (odysseus.life > 0 && odysseus.ressurection == 0)
                    {
                        odysseus.status = "alive";
                        Console.WriteLine(odysseus.name + " has " + odysseus.life + " hp");
                    }
                    else if (odysseus.life <= 0 && odysseus.ressurection == 1)
                    {
                        odysseus.status = "alive";
                        odysseus.ressurection = odysseus.ressurection - 1;
                        Console.WriteLine(odysseus.name + " died");
                        Console.WriteLine(odysseus.name + " casted ressurection!");
                        odysseus.life = 1000;
                        Console.WriteLine(odysseus.name + " has " + odysseus.life + " hp");
                    }
                    else if (odysseus.life <= 0 && odysseus.ressurection == 0)
                    {
                        Console.WriteLine(odysseus.name + " died!");
                        odysseus.status = "dead";
                        break;
                    }

                    Console.WriteLine("\n     ---It is now the turn of " + medusa.name + "---");

                    damage = medusa.strength * 1;
                        critDamage = damage * 2;

                        crit = critFunction.Next(1, 5);

                        if (crit != 1)
                        {
                            perseus.life = perseus.life - damage;
                            Console.WriteLine(medusa.name + " dealt --(O)=====> " + damage + " normal damage to " + perseus.name);
                        }
                        else
                        {
                            perseus.life = perseus.life - critDamage;
                            Console.WriteLine(medusa.name + " dealt --(X)=====> " + critDamage + " !!CRITICAL!! damage to " + perseus.name);
                        }

                        if (perseus.life <= 0)
                        {
                            Console.WriteLine(perseus.name + " died!");
                            break;
                        }
                        else
                        {
                        Console.WriteLine(perseus.name + " has " + perseus.life + " hp");
                        }

                    if (odysseus.life > 0 && perseus.life > 0)
                    {
                        select = 2;
                    }

                }
                else if (select == 2 && odysseus.status == "alive")
                {
                    Console.WriteLine("\n     ---It is now the turn of " + odysseus.name + "---");

                    damage = odysseus.strength * 1;
                    critDamage = damage * 2;

                    crit = critFunction.Next(1, 5);

                    if (crit != 1)
                    {
                        polyphemus.life = polyphemus.life - damage;
                        Console.WriteLine(odysseus.name + " dealt --(O)=====> " + damage + " normal damage to " + polyphemus.name);
                    }
                    else
                    {
                        polyphemus.life = polyphemus.life - critDamage;
                        Console.WriteLine(odysseus.name + " dealt --(X)=====> " + critDamage + " !!CRITICAL!! damage to " + polyphemus.name);
                    }

                    if (polyphemus.life <= 0)
                    {
                        Console.WriteLine(polyphemus.name + " died!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(polyphemus.name + " has " + polyphemus.life + " hp");
                    }

                    Console.WriteLine("\n     ---It is now the turn of " + perseus.name + "---");

                        damage = perseus.strength * 1;
                        critDamage = damage * 2;

                        crit = critFunction.Next(1, 5);

                        if (crit != 1)
                        {
                            medusa.life = medusa.life - damage;
                            Console.WriteLine(perseus.name + " dealt --(O)=====> " + damage + " normal damage to " + medusa.name);
                        }
                        else
                        {
                            medusa.life = medusa.life - critDamage;
                            Console.WriteLine(perseus.name + " dealt --(X)=====> " + critDamage + " !!CRITICAL!! damage to " + medusa.name);
                        }

                        if (medusa.life <= 0)
                        {
                            Console.WriteLine(medusa.name + " died!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(medusa.name + " has " + medusa.life + " hp");
                        }

                    if (polyphemus.life > 0 && medusa.life > 0)
                    {
                        select = 1;
                    }

                }

            } while (polyphemus.life > 0 && medusa.life > 0 && perseus.life > 0 && odysseus.status == "alive");

            Console.ReadKey();
        }
    }
}
