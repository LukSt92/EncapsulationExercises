﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random= new Random();

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char input = Console.ReadKey(false).KeyChar;

                if (input !='0' && input !='1' && input !='2' && input !='3')
                {
                    return;
                }

                swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);

                if (input == '0')
                {
                    swordDamage.CalculateDamage();
                }
                if (input == '1' || input == '3')
                {
                    swordDamage.SetMagic(true);
                }
                if (input == '2' || input == '3')
                {
                    swordDamage.SetFlaming(true);
                }

                Console.WriteLine( "\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP\n");
            }
        }
    }
}
