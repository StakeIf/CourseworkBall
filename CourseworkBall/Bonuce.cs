using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CourseworkBall
{
    public class Bonuce : Figure
    {
        public Bonuce(float x, float y) : base(x, y)
        {
            sizeX = 50;
            sizeY = 50;
        }
        public void CreateNewBonuce(Bonuce bon, Player ball)
        {
            if (x < ball.x - 250 || ball.Collide(bon))
            {
                Random r = new Random();
                int x1, y1;
                x1 = r.Next(600, 800);
                y1 = r.Next(100, 400);

                bon.Set(x1, y1);
            }
        }
    }
}
