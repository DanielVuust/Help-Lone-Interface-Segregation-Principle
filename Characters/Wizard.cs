﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Help_Lone_Interface_Segregation_Principle.Interfaces;
using Help_Lone_Interface_Segregation_Principle.Interfaces.CharacterInterfaces;

namespace Help_Lone_Interface_Segregation_Principle.Characters
{
    class Wizard : IFightingCharacter, IHealingCharacter, ITeleportingCharacter, IThrowFrostNovaCharacter, IThrowMagicMisileCharacter
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }


        public void ThrowMagicMisile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }

        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }

        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
    }
}
