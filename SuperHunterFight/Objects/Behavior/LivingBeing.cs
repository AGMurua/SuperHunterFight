using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHunterFight.Objects.Behavior
{
    public class LivingBeing 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Health
        {
            get { return _health; }
            set
            {
                if (value > _maxHealt)
                    _health = _maxHealt;
                else if (value < _minHealt)
                    _health = _minHealt;
                else
                    _health = value;
            }
        }

        private float _health;
        private readonly float _maxHealt = 150;
        private readonly float _minHealt = 20;

        public LivingBeing(string name, string description, float health)  
        {
            Name = name;
            Description = description;
            Health = health;
        }

        protected internal void TakeDamage(Weapon weapon)
        {
            _health -= weapon.Damage;
        }

        public bool IsAlive()
        {
            if (_health <= 0)
                return false;
            return true;
        }

    }
}
