using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Добавить класс Точка для наследования координат

namespace CourseworkBall
{
    public partial class Game : Form
    {
        Player ball;
        TheWall upperWall;
        TheWall lowerWall;
      

        float gravity;

        //Конструктор
        public Game()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(Update);
            Init();
            Invalidate();
        }

        //Расстановка объектов на экране
        public void Init()
        {
            ball = new Player(200, 200);
            upperWall = new TheWall(650, -200);
            lowerWall = new TheWall(650, 400, true);
     

            gravity = 0;
            this.Text = "Flappy ball Score: 0";
            timer1.Start();
        }

        //Отрисовка объектов
        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(ball.figureImage, ball.x, ball.y, ball.sizeX, ball.sizeY);
            graphics.DrawImage(upperWall.figureImage, upperWall.x, upperWall.y, upperWall.sizeX, upperWall.sizeY);
            graphics.DrawImage(lowerWall.figureImage, lowerWall.x, lowerWall.y, lowerWall.sizeX, lowerWall.sizeY);
  
        }

        //Запуск игры заново
        private void Update(object sender, EventArgs e)
        {
            //Если шар упал ниже поля
            if (ball.y > 600)
            {
                if (ball.Pop(timer1))
                {
                    Thread.Sleep(1000);
                    Init();
                }
            }
            //Если шар врезался в стену
            if (ball.Collide(upperWall) || ball.Collide(lowerWall))
            {
                if (ball.Pop(timer1))
                {
                    Thread.Sleep(1000);
                    Init();
                }
            }

            ball.Gravity(ref gravity);

            if (ball.GetAlive())
                MoveWalls();

            Invalidate();
        }

        //Движение стен и монеты
        private void MoveWalls()
        {
            upperWall.Move();
            lowerWall.Move();
            upperWall.CreateNewWall(upperWall, lowerWall, ball);
        }

        //Нажатие на кнопку для полета
        private void button1_Click(object sender, EventArgs e)
        {
            ball.Flight(ref gravity);
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
