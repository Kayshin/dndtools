using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public interface IWeapon: IItem
    {
        DamageType DamageType
        {
            get;
            set;
        }

        int ToHit
        {
            get;
            set;
        }

        Dice DamageDice
        {
            get;
            set;
        }

        int DamageDiceMod
        {
            get;
            set;
        }

        int ToHitMod
        {
            get;
            set;
        }
    }
}
