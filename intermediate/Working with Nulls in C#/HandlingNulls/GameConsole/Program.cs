using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var players = new PlayerCharacter[3]
            {
                new PlayerCharacter(new DiamondSkinDefence()) {Name = "Dimontre" } ,
                new PlayerCharacter(new IronBonesDefence()) {Name = "Irontresti" },
                new PlayerCharacter(SpecialDefence.Null){Name = "Nulitry"}
            };

            foreach (var player in players)
            {
                player.Hit(10);
            }

         
            Console.ReadLine();

        }
    }
}
