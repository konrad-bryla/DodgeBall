using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeBall
{
    class Ball
    {
        private Court courtClass;
        private int xValue;
        private int yValue;
        private Brush brush;
        private int min;

        public Ball(Court courtClass)
        {
            this.courtClass = courtClass;
            this.Position();
            this.BallMovement();
            this.brush = new SolidBrush(Color.DarkKhaki);
        }

        private void Position()
        {
            min = this.courtClass.Top + 1;
            this.Top = Court.rand.Next(min, this.courtClass.Bottom - 40);
            this.Left = (this.courtClass.Right - 40) - 1;
        }

        private void BallMovement()
        {
            this.xValue = -Court.rand.Next(1, 10);
            this.yValue = Court.rand.Next(-10, 10);
        }

        public bool Players(Player player) => ((this.Left <= player.Right) ? ((this.Right >= player.Left) ? ((this.Bottom >= player.Top) ? (this.Top <= player.Bottom) : false) : false) : false);

        public void DrawBall(Graphics graph)
        {
            graph.FillEllipse(this.brush, this.Left, this.Top, 40, 40);
        }

        public void Move()
        {
            this.Top += this.yValue;
            this.Left += this.xValue;
            if (this.Top < this.courtClass.Top)
            {
                this.yValue = Math.Abs(this.yValue);
            }
            else if (this.Bottom > this.courtClass.Bottom)
            {
                this.yValue = -Math.Abs(this.yValue);
            }
        }

        public bool HitLeftWall()
        {

            return (this.Left < this.courtClass.Left);

        }

        public int Top
        {
            get;
            set;

        }
        public int Left
        {
            get;
            set;
        }

        public int Right
        {
            get
            {
                return (this.Left + 50);
            }
        }
        public int Bottom
        {
            get
            {
                return (this.Top + 40);
            }
        }

    }
}
