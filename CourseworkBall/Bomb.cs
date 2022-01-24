using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CourseworkBall
{
    class Bomb : Bonuce
    {
        //Конструктор с параметрами
        public Bomb(int x, int y) : base(x, y)
        {
            figureImage = new Bitmap("C:\\Users\\Николай\\Desktop\\bomb.png");
        }
    }
}
