using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLocomotive
{
    public partial class FormLocomotive : Form
    {
        private Locomotive locomotive;

        public FormLocomotive()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLoc.Width, pictureBoxLoc.Height);
            Graphics gr = Graphics.FromImage(bmp);
            locomotive.DrawLocomotive(gr);
            pictureBoxLoc.Image = bmp;
        }

        private void FormLocomotive_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            locomotive = new Locomotive(rnd.Next(100, 500), Color.Green, Color.Yellow);
            locomotive.SetPosition(rnd.Next(10, 500), rnd.Next(10, 300), pictureBoxLoc.Width, pictureBoxLoc.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "up":
                    locomotive.MoveTransport(Direction.Up);
                    break;
                case "down":
                    locomotive.MoveTransport(Direction.Down);
                    break;
                case "left":
                    locomotive.MoveTransport(Direction.Left);
                    break;
                case "right":
                    locomotive.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
