using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokedex
{
    internal class Pokemon
    {
        private string _name;
        private int _health;
        private int _level;

        public Pokemon()
        {
            _name = "Magikarp";
            _health = 1;
            _level = 1;
        }

        public Pokemon(string name, int health, int level)
        {
            _name = name;
            _health = health;
            _level = level;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Your {_name} has {_health} hp and is level {_level}");
        }
    }

}
