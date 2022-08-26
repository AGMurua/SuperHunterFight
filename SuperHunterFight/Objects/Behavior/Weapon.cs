using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHunterFight.Objects.Behavior
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private float _damage;
        private readonly float _minDamage = 10;
        private readonly float _maxDamage = 100;
        public float Damage
        {
            get { return _damage; }
            set
            {
                if (value > _maxDamage)
                    _damage = _maxDamage;
                else if (value < _minDamage)
                    _damage = _minDamage;
                else
                    _damage = value;
            }
        }

        public Weapon(string name, string description, float damage)
        {
            Name = name;
            Description = description;
            Damage = damage;
        }
    }
}
