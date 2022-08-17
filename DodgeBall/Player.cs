using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeBall
{
    class Player
    {
        private Court courtClass;
        private Brush brush;

        public Player(Court courtClass)
        {
            this.courtClass = courtClass;
            this.brush = new SolidBrush(Color.Black);
            this.HeightAmount = 40;
            this.WidthAmount = 20;
            this.Top = ((courtClass.Bottom + courtClass.Top) / 2) - (HeightAmount / 2);
            this.Left = courtClass.Left + this.WidthAmount;
        }


        public void Draw(Graphics graph)
        {
            graph.FillRectangle(brush, Left, Top, WidthAmount, HeightAmount);
        }

        public void MoveD()
        {
            this.Top += 10;
            if (this.Bottom > this.courtClass.Bottom)
            {
                this.Top = this.courtClass.Bottom - this.HeightAmount;

            }
        }

        public void MoveL()
        {
            this.Left -= 10;
            if (this.Left < this.courtClass.Left)
            {
                this.Left = this.courtClass.Left;
            }
        }

        public void MoveR()
        {
            this.Left += 10;
            if (this.Right > this.courtClass.Right)
            {
                this.Left = this.courtClass.Right - this.WidthAmount;
            }
        }

        public void MoveU()
        {
            this.Top -= 10;
            if (this.Top < this.courtClass.Top)
            {
                this.Top = this.courtClass.Top;
            }
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

        public int WidthAmount
        {
            get;
            set;
        }

        public int HeightAmount
        {
            get;
            set;
        }

        public int Right
        {
            get
            {
                return (this.Left + this.WidthAmount);
            }
        }

        public int Bottom
        {
            get
            {
                return (this.Top + this.HeightAmount);
            }
        }

    }
}
