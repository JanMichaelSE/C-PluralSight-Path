using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class PlayerCharacter
    {
        private readonly SpecialDefence specialDefence;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            this.specialDefence = specialDefence;
        }

        public string Name { get; set; }
        public int? Health { get; set; } = 100;


        public  void Hit(int damage)
        {

            Health -= specialDefence.CalculateDamageReduction(damage);

            Console.WriteLine($"{Name}  health is now reduced by {specialDefence.CalculateDamageReduction(damage)} to {Health}");
        }
    }
}
