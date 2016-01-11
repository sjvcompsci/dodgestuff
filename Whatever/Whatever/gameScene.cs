using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    class gameScene : Scene
    {
       public gameScene() : base()
        {

            // Add 50 collectables in random locations to the Scene.
            for (int i = 0; i < 50; i++)
            {
                // Check out the Rand class for random generation!
                var x = Rand.Float();
                var y = Rand.Float();
                // Add the Collectable at the randomized position.
                //Add(new Collect(x, y));
            }
            Add(new Player(50,50));
        }
    }
}
