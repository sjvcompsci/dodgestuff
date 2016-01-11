using System;
using Otter;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever
{
    enum Tags
    {
        Player,
        Collectable
    }

    class Player : Entity
    {
       
        Image p = Image.CreateCircle(7, Color.Red);
        int speed = 5;
        BoxCollider collider = new BoxCollider(30, 30);

        
    
    public Player(int x, int y) : base(x,y)
        {
            AddGraphic(p);
        // Add the collider. Must be added or it cant check for collision!
        AddCollider(collider);
        // Center the origin of the collider so it aligns with the image.
        collider.CenterOrigin();
        }
        public override void Update()
        {
            base.Update();

            if (Input.KeyDown(Key.W))
            {
                Y -= speed;
            }
            if (Input.KeyDown(Key.S))
            {
                Y += speed;
            }
            if (Input.KeyDown(Key.A))
            {
                X -= speed;
            }
            if (Input.KeyDown(Key.D))
            {
                X += speed;
            }
        }
        public override void Render()
        {
            base.Render();

            // Uncomment the following line to see the collider.
            //collider.Render();
        }
    }
    
}
