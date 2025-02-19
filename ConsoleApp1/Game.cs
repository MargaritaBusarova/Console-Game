using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        // Персонаж
        public User User { get; set; }

        // Уровни
        public List<Level> Levels { get; set; }

        // Текущий уровень
        public Level CurrentLevel { get; set; }
    }
}
