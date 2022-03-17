using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Help_Lone_Interface_Segregation_Principle.Interfaces;
using Help_Lone_Interface_Segregation_Principle.Interfaces.CharacterInterfaces;

namespace Help_Lone_Interface_Segregation_Principle.Characters
{
    public class Witch : IWitch
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
    }
}
