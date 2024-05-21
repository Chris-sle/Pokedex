using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
     class Pikachu
    {
        public int _health;
        public int _level;

        public Pikachu()
        {
            _health = 50;
            _level = 21;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Pikachu har {_health} hp og er level {_level}");
        }
    }
}
