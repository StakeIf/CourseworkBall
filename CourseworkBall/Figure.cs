using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CourseworkBall
{
    public class Figure
    {
        public float x; //Расположение по Х
        public float y; //Расположение по У

        public int sizeX; //Размер по Х
        public int sizeY; //Размер по У

        public Image figureImage; //Изображение - скин

        public Figure(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move()
        {
            x -= 3;
        }
    }
}
