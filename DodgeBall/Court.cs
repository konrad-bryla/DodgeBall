using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodgeBall
{
    public class Court
    {
        private Pen pen = new Pen(Color.DarkMagenta, 7f);


        public int distanceOfEdge = 60;
        public static Random rand = new Random();

        public Court(Form1 form)
        {
            Top = form.Top + 30;
            Bottom = form.Bottom - 80;
            Left = form.Left + 10;
            Right = form.Right - 30;
        }

        public void DrawPlayer(Graphics graph)
        {
            graph.DrawRectangle(pen, Left, Top, Right - Left, Bottom - Top);
        }

        public int Top
        {
            get;
            set;
        }
        public int Bottom
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
            get;
            set;
        }

    }
}
