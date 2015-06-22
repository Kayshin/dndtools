using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolCore
{
    public class Sword : ISword
    {        
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public DamageType DamageType { get; set; }

        public int ToHit { get; set; }
        public int ToHitMod { get; set; }

        public Dice DamageDice { get; set; }
        public int DamageDiceMod { get; set; }

        public int Value { get; set; }
        
        public Sword()
        {
            this.Id = Guid.NewGuid();
            this.Name = "Sword";

            this.DamageType = DamageType.Slashing;

            this.ToHit = 0;
            this.ToHitMod = 0;

            this.DamageDice = Dice.D8;
            this.DamageDiceMod = 0;

            this.Value = 100;
        }

        public Sword(string name, DamageType damageType, int value = 0)
            : base()
        {
            this.Name = name;
            this.DamageType = damageType;
            this.Value = value;
        }
    }
}
