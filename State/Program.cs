using State.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Andre Soares Gomes", 0);

            player.GetStatus();

            player.Feed();

            player.GetStatus();

            player.GetStarved();

            player.GetStatus();

            player.GetStarved();

            ReadKey();
        }
    }
}
