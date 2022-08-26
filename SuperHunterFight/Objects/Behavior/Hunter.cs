using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHunterFight.Objects.Behavior
{
    public class Hunter 
    {
        public string Name { get; set; }
        public Hunter(string name)
        {
            Name = name;
        }

        
        public void Shoot(Weapon weapon, LivingBeing target)
        {
            target.TakeDamage(weapon);
        }
    }
}
