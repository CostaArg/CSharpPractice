using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsTwoFighters
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }

    public class Kata
    {
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            do
            {
                if (fighter2.Health <= 0)
                    return fighter1.Name;
                else if (fighter1.Health <= 0)
                    return fighter2.Name;

                if (firstAttacker == fighter1.Name)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    firstAttacker = fighter2.Name;
                }
                else
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                    firstAttacker = fighter1.Name;
                }

            } while (true);
        }
    }
}
