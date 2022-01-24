using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CourseworkBall
{
    public class Player : Figure
    {
        public int score; //Заработанные очки или пройденные стены
        private float gravityValue; //Коэффициент графитации?
        private bool isAlive;  //Жив или не жив

        //Конструктор с параметрами
        public Player(int x, int y) : base(x, y)
        {
            sizeX = 70;
            sizeY = 105;
            figureImage = new Bitmap("C:\\Users\\Николай\\Desktop\\Ballon.png");

            gravityValue = 0.1f;
            isAlive = true;
            score = 0;
        }
        public bool GetAlive()
        {
            return isAlive;
        }
        public void Flight(ref float gr)
        {
            if (isAlive)
            {
                gr = 0;
                gravityValue = -0.125f;
            }
        }

        public bool Collide(Figure let)
        {
            float X = (x + sizeX / 2) - (let.x + let.sizeX / 2); //Расстояние между шаром и препятсвием по Х
            float Y = (y + sizeY / 2) - (let.y + let.sizeY / 2); //Расстояние между шаром и препятсвием по У
            if (Math.Abs(X) <= sizeX / 2 + let.sizeX / 2 - 5)
            {
                if (Math.Abs(Y) <= sizeY / 2 + let.sizeY / 2 - 10)
                {
                    return true;   //В данном случае произойдет столкновения
                }
            }
            return false;
        }
        public bool Pop(Timer timer1)
        {
            isAlive = false;
            timer1.Stop();

            Form fff = Application.OpenForms[1];
            Form sss = Application.OpenForms[0];

            DialogResult vibor2 = MessageBox.Show("Счет: " + score + "\nХотите начать заново?", "Вы проиграли!", MessageBoxButtons.YesNo);
            if (vibor2 == DialogResult.No)
            {
                fff.Close();
                sss.Show();
                return false;
            }
            else
                return true;
        }

        public void Gravity(ref float gr)
        {
            if (gravityValue != 0.1f)
                gravityValue += 0.005f;

            gr += gravityValue;
            y += gr;
        }
    }
}
