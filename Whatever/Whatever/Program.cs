using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Game",900,600);
            game.MouseVisible = true;
            game.Start(new gameScene());
        }
    }
}
