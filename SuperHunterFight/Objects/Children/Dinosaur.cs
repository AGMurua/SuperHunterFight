using SuperHunterFight.Objects.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHunterFight.Objects.Children
{
    public class Dinosaur : LivingBeing
    {
        public Dinosaur(string name, string description, float healt, float weight) : base(name, description, healt)
        {
            Weight = weight;
        }

        public float Weight { get; set; }
    }
}
