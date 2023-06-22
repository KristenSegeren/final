using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace final
{

    public partial class Form1 : Form
    {
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        int playerSpeed = 12;
        int ballXSpeed = 8;
        int ballYSpeed = 8;
        int block1value = 1;
        int block2value = 20;
        int block3value = 20;
        int block4value = 20;
        int block5value = 20;
        int block6value = 20;
        bool ballstart = false;

        Rectangle player2 = new Rectangle(250, 480, 40, 6);
        Rectangle ball = new Rectangle(0, 0, 10, 10);
        Rectangle block1 = new Rectangle(40, 70, 35, 35);
        Rectangle block2 = new Rectangle(220, 70, 35, 35);
        Rectangle block3 = new Rectangle(400, 70, 35, 35);
        Rectangle block4 = new Rectangle(130, 160, 35, 35);
        Rectangle block5 = new Rectangle(300, 160, 35, 35);
        Rectangle block6 = new Rectangle(220, 250, 35, 35);
        Rectangle block1Left = new Rectangle(40, 70, 1, 35);
        Rectangle block1Right = new Rectangle(75, 70, 1, 35);
        Rectangle block1top = new Rectangle(40, 70, 35, 1);
        Rectangle block1bot = new Rectangle(40, 105, 35, 1);

        Rectangle block2Left = new Rectangle(220, 70, 1, 35);
        Rectangle block2Right = new Rectangle(255, 70, 1, 35);
        Rectangle block2top = new Rectangle(220, 70, 35, 1);
        Rectangle block2bot = new Rectangle(220, 105, 35, 1);

        Rectangle block3Left = new Rectangle(400, 70, 1, 35);
        Rectangle block3Right = new Rectangle(435, 70, 1, 35);
        Rectangle block3top = new Rectangle(400, 70, 35, 1);
        Rectangle block3bot = new Rectangle(400, 105, 35, 1);

        Rectangle block4Left = new Rectangle(130, 160, 1, 35);
        Rectangle block4Right = new Rectangle(165, 160, 1, 35);
        Rectangle block4top = new Rectangle(130, 160, 35, 1);
        Rectangle block4bot = new Rectangle(130, 195, 35, 1);

        Rectangle block5Left = new Rectangle(300, 160, 1, 35);
        Rectangle block5Right = new Rectangle(335, 160, 1, 35);
        Rectangle block5top = new Rectangle(300, 160, 35, 1);
        Rectangle block5bot = new Rectangle(300, 195, 35, 1);

        Rectangle block6Left = new Rectangle(220, 250, 1, 35);
        Rectangle block6Right = new Rectangle(255, 250, 1, 35);
        Rectangle block6top = new Rectangle(220, 250, 35, 1);
        Rectangle block6bot = new Rectangle(220, 285, 35, 1);

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        List<Rectangle> block = new List<Rectangle>();
        List<int> index = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
        // private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.FillRectangle(blueBrush, player2);
        //    e.Graphics.FillRectangle(whiteBrush, ball);

        //    e.Graphics.FillRectangle(redBrush, block2);
        //    e.Graphics.FillRectangle(redBrush, block3);
        //    e.Graphics.FillRectangle(redBrush, block4);
        //    e.Graphics.FillRectangle(redBrush, block5);
        //    e.Graphics.FillRectangle(redBrush, block6);
        //    if (block1value > 0)
        //    {
        //        e.Graphics.FillRectangle(redBrush, block1); 
        //    }
        //    if (block2value > 0)
        //    {
        //        e.Graphics.FillRectangle(redBrush, block1);
        //    }

        //}
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        #region move
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    titleLabel.Visible = false;
                    ballstart = true;
                    break;
            }
        }
        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }
        #endregion

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region move ball 
            if (ballstart == true)
            {
                ball.X += ballXSpeed;
                ball.Y += ballYSpeed;
            }
            #endregion
            #region playerMove
            if (leftArrowDown == true && player2.X > 0)
            {
                player2.X -= playerSpeed;
            }

            if (rightArrowDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += playerSpeed;
            }
            #endregion
            #region intersection
            if (player2.IntersectsWith(ball))
            {
                ballYSpeed *= -1;

            }
            if (ball.Y < 0)
            {
                ballYSpeed *= -1;
            }

            if (ball.X < 0)
            {
                ballXSpeed *= -1;
            }
            if (ball.X > this.Width - 10)
            {
                ballXSpeed *= -1;
            }
            //block 1
            if (block1value > 0)
            {
                if (block1top.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block1value = block1value - 1;
                }
                else if (block1bot.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block1value = block1value - 1;
                }
                else if (block1Left.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block1value = block1value - 1;
                }
                else if (block1Right.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block1value = block1value - 1;
                }
            }
            //block2
            if (block2value > 0)
            {
                if (block2top.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block2value = block2value - 1;
                }
                else if (block2bot.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block2value = block2value - 1;
                }
                else if (block2Left.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block2value = block2value - 1;
                }
                else if (block2Right.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block2value = block2value - 1;
                }
            }
            //block3
            if (block3value > 0)
            {
                if (block3top.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block3value = block3value - 1;
                }
                else if (block3bot.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block3value = block3value - 1;
                }
                else if (block3Left.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block3value = block3value - 1;
                }
                else if (block3Right.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block3value = block3value - 1;
                }
            }
            //block4
            if (block4value > 0)
            {
                if (block4top.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block4value = block4value - 1;
                }
                else if (block4bot.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block4value = block4value - 1;
                }
                else if (block4Left.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block4value = block4value - 1;
                }
                else if (block4Right.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block4value = block4value - 1;
                }
            }
            //block5
            if (block5value > 0)
            {
                if (block5top.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block5value = block5value - 1;
                }
                else if (block5bot.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block5value = block5value - 1;
                }
                else if (block5Left.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block5value = block5value - 1;
                }
                else if (block5Right.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block5value = block5value - 1;
                }
            }
            //block6
            if (block6value > 0)
            {
                if (block6top.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block6value = block6value - 1;
                }
                else if (block6bot.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                    block6value = block6value - 1;
                }
                else if (block6Left.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block6value = block6value - 1;
                }
                else if (block6Right.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                    block6value = block6value - 1;
                }
            }
            #endregion
            #region valueLabel
            block1label.Text = $"{block1value}";
            block2Label.Text = $"{block2value}";
            block3Label.Text = $"{block3value}";
            block4Label.Text = $"{block4value}";
            block5Label.Text = $"{block5value}";
            block6Label.Text = $"{block6value}";
            #endregion
            #region blockBye
            if (block1value == 0)
            {
                block1label.Text = $" ";
                block1.X = -300;

            }
            if (block2value == 0)
            {
                block2Label.Text = $" ";
                block2.X = -300;
            }
            if (block3value == 0)
            {
                block3Label.Text = $" ";
                block3.X = -300;
            }
            if (block4value == 0)
            {
                block4Label.Text = $" ";
                block4.X = -300;
            }
            if (block5value == 0)
            {
                block5Label.Text = $" ";
                block5.X = -300;
            }
            if (block6value == 0)
            {
                block6Label.Text = $" ";
                block6.X = -300;
            }
            #endregion
            #region winLose
            if (block1value == 0 && block2value == 0 && block3value == 0 && block4value == 0 && block5value == 0 && block6value == 0)
            {
                titleLabel.Visible = true;
                titleLabel.Text = $"You Win!";
            }
            if (ball.Y > 549)
            {
                titleLabel.Visible = true;
                titleLabel.Text = $"You lose";
            }
            #endregion
            
            Refresh();
        }
       private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, ball);

            e.Graphics.FillRectangle(redBrush, block2);
            e.Graphics.FillRectangle(redBrush, block3);
            e.Graphics.FillRectangle(redBrush, block4);
            e.Graphics.FillRectangle(redBrush, block5);
            e.Graphics.FillRectangle(redBrush, block6);
            if (block1value > 0)
            {
                e.Graphics.FillRectangle(redBrush, block1);
            }
            if (block2value > 0)
            {
                e.Graphics.FillRectangle(redBrush, block1);
            }

        }
    }
}
