using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeBall
{
    //Daniel Bueno and Konrad Bryla Assignment 9
    public partial class Form1 : Form
    {
        private Court courClass;
        private Player playerClass;
        private List<Ball> ballClass;


        public Form1()
        {
            InitializeComponent();
            this.courClass = new Court(this);
            this.playerClass = new Player(this.courClass);
            Reset();

        }

        private void Reset()
        {
            this.ballClass = new List<Ball>();
            this.ballClass.Add(new Ball(this.courClass));
            this.Current = 1;
            this.timer1.Enabled = false;

        }

        private void Start()
        {
            this.timer1.Start();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (Ball newBall in this.ballClass)
            {
                newBall.Move();
            }
            if (Court.rand.Next(0, 20) == 12)
            {
                this.ballClass.Add(new Ball(this.courClass));
                int actualScore = this.Current;
                this.Current = actualScore + 1;
            }
            this.ballClass.RemoveAll(balls => balls.HitLeftWall());
            foreach (Ball newBall2 in this.ballClass)
            {
                if (newBall2.Players(this.playerClass))
                {
                    this.Reset();
                    break;
                }
            }
            this.Refresh();

        }

        public int Current
        {
            get
            {
                return int.Parse(this.tsScore.Text);
            }
            set
            {
                this.tsScore.Text = value.ToString();
                if (value > this.High)
                {
                    this.High = value;
                }
            }
        }

        public int High
        {
            get
            {
                return int.Parse(this.tsHighScore.Text);
            }
            set
            {
                this.tsHighScore.Text = value.ToString();
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.playerClass.Draw(e.Graphics);
            foreach (Ball newBall in this.ballClass)
            {
                newBall.DrawBall(e.Graphics);
            }
            this.courClass.DrawPlayer(e.Graphics);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.playerClass.MoveU();
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.playerClass.MoveD();
            }
            else if (e.KeyCode == Keys.Right)
            {
                this.playerClass.MoveR();
            }
            else if (e.KeyCode == Keys.Left)
            {
                this.playerClass.MoveL();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.Start();
            }
            this.Refresh();

        }

        private void TsStart_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void TsPause_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
        }

        private void TsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
