using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CourseworkBall
{
    public class TheWall : Figure
    {
        //Конструктор с параметрами
        public TheWall(int x, int y, bool isRotatedImage = false) : base(x, y)
        {
            sizeX = 80;
            sizeY = 400;
            figureImage = new Bitmap("C:\\Users\\Николай\\Desktop\\SingleWall.png");
            if (isRotatedImage)
                figureImage.RotateFlip(RotateFlipType.Rotate180FlipX);
        }

        public void CreateNewWall(TheWall up, TheWall low, Player ball)
        {
            if (x < ball.x - 300)
            {
                Random r = new Random();
                int y1;
                y1 = r.Next(-400, 000);

                up.Set(600, y1);
                low.Set(600, y1 + 600);
            }
        }
    }
}