﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Lone_Interface_Segregation_Principle.Interfaces
{
    public interface IShieldCharacter : ICharacter, IFightingCharacter
    {
        void RaiseShield();
        void ShieldGlare();
    }
}
