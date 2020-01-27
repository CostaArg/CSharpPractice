using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRoleplayVer1
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

            Monster polifimos;
            polifimos.name = "Polifimos";
            polifimos.race = "Cyclops";
            polifimos.life = 300;
            polifimos.strength = 300;
            polifimos.rage = 0;

            Monster medusa;
            medusa.name = "Medusa";
            medusa.race = "Serpent";
            medusa.life = 140;
            medusa.strength = 40;

            Hero odiseas;
            odiseas.name = "Odiseas";
            odiseas.race = "Human";
            odiseas.idiotita = "Archer";
            odiseas.life = 1000;
            odiseas.strength = 35;
            odiseas.ressurection = 1;
            odiseas.status = "alive";

            Hero thiseas;
            thiseas.name = "Thiseas";
            thiseas.race = "Human";
            thiseas.idiotita = "Shieldbearer";
            thiseas.life = 3000;
            thiseas.strength = 10;

            do
            {

                if (select == 1)
                {
                    Console.WriteLine("---It is now the turn of Polifimos---");

                    damage = polifimos.strength * 1;
                    critDamage = damage * 2;

                    polifimos.rage = polifimos.rage + 20;

                    crit = critFunction.Next(1, 5);

                    if (polifimos.rage >= 100)
                    {
                        damage = polifimos.strength * 4;
                        polifimos.rage = 0;
                        Console.WriteLine("Polifimos used Mortal Strike");
                    }

                    if (crit != 1)
                    {
                        odiseas.life = odiseas.life - damage;
                        Console.WriteLine("Polifimos dealt " + damage + " normal damage to Odiseas");
                    }
                    else
                    {
                        odiseas.life = odiseas.life - critDamage;
                        Console.WriteLine("Polifimos dealt " + critDamage + " !!CRITICAL!! damage to Odiseas");
                    }

                    if (odiseas.life > 0 && odiseas.ressurection == 1)
                        odiseas.status = "alive";
                    else if (odiseas.life > 0 && odiseas.ressurection == 0)
                        odiseas.status = "alive";
                    else if (odiseas.life <= 0 && odiseas.ressurection == 1)
                    {
                        odiseas.status = "alive";
                        odiseas.ressurection = odiseas.ressurection - 1;
                        Console.WriteLine("Odiseas died");
                        Console.WriteLine("Odiseas casted ressurection!");
                        odiseas.life = 1000;
                    }
                    else if (odiseas.life <= 0 && odiseas.ressurection == 0)
                    {
                        Console.WriteLine("Odiseas died");
                        odiseas.status = "dead";
                        break;
                    }

                    if (odiseas.status == "alive")
                    {
                        select = 2;
                    }

                }
                else if (select == 2 && odiseas.status == "alive")
                {
                    Console.WriteLine("---It is now the turn of Odiseas---");

                    damage = odiseas.strength * 1;
                    critDamage = damage * 2;

                    crit = critFunction.Next(1, 5);

                    if (crit != 1)
                    {
                        polifimos.life = polifimos.life - damage;
                        Console.WriteLine("Odiseas dealt " + damage + " normal damage to Polifimos");
                    }
                    else
                    {
                        polifimos.life = polifimos.life - critDamage;
                        Console.WriteLine("Odiseas dealt " + critDamage + " !!CRITICAL!! damage to Polifimos");
                    }

                    if (polifimos.life <= 0)
                    {
                        Console.WriteLine("Polifimos died");
                        break;
                    }
                    else
                        select = 1;
                }

            } while (polifimos.life > 0 && medusa.life > 0 && thiseas.life > 0 && odiseas.status == "alive");

        }
    }
}