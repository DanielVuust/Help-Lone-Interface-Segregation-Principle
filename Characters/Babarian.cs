using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Help_Lone_Interface_Segregation_Principle.Interfaces;
using Help_Lone_Interface_Segregation_Principle.Interfaces.CharacterInterfaces;

namespace Help_Lone_Interface_Segregation_Principle.Characters
{
    public class Babarian : IBabarian
    {
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }

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

        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
}
