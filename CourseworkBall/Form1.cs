using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseworkBall
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game example = new Game();
            example.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pravila_Click(object sender, EventArgs e)
        {
            HowToPlay prav = new HowToPlay();
            prav.Show();
        }
    }
}
