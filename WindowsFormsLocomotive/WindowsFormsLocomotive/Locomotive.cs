using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLocomotive
{
    /// <summary>
    /// Класс отрисовки локомотива
    /// </summary>
    class Locomotive
    {

        /// <summary>
        /// Левая координата отрисовки
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки локомотива
        /// </summary>
        private const int locWidth = 100;
        /// <summary>
        /// Высота отрисовки локомотива
        /// </summary>
        private const int locHeight = 60;
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { private set; get; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public Locomotive(int speed, Color mainColor, Color dopColor)
        {
            Speed = speed;
            MainColor = mainColor;
            DopColor = dopColor;
        }

        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }


        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = Speed / 20;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - locWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - locHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawLocomotive(Graphics g)
        {
          

            // теперь отрисуем основной кузов
         
            
            //колеса
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, _startPosX + 10, _startPosY + 67, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 30, _startPosY + 67, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 60, _startPosY + 67, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 77, _startPosY + 67, 15, 15);
            //кузов
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY + 10, 100, 60);
            // полоса
            br = new SolidBrush(DopColor);
            g.FillRectangle(br, _startPosX, _startPosY + 50, 100, 5);
            //стекла и дверь
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 60, _startPosY + 30, 15, 40);
            g.FillRectangle(brBlue, _startPosX + 10, _startPosY + 15, 30, 10);
            g.FillRectangle(brBlue, _startPosX + 50, _startPosY + 15, 30, 10);
            g.FillRectangle(brBlue, _startPosX + 85, _startPosY + 15, 15, 20);
            //токоприемник
            Pen pen = new Pen(Color.Red);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY , 15, 15);
            
           

        }

        
    }
}
