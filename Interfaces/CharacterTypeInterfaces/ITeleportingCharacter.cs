using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Lone_Interface_Segregation_Principle.Interfaces
{
    interface ITeleportingCharacter : ICharacter
    {
        void Teleport(int x, int y);
    }
}
