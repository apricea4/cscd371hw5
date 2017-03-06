using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace priceacscd371hw5
{
    public partial class ticTacForm : Form
    {
        const int MARGIN = 50;
        const int PADDING = 30;
        public int spacesLeft = 9;
        Char[ , ] gameBoard = new Char[3 , 3];
        bool player1 = true;
        bool singlePlayer = false;
        bool isWon = false;
        bool start = false;
        public ticTacForm()
        {
            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Pen p = new Pen(Color.CornflowerBlue, 20);
            double d2 = 600.0 * (2.0/3.0);
            double d1 = 600.0 / 3.0;
            int  oneThird = (int)Math.Truncate(d1);
            int twoThird = (int)Math.Truncate(d2);
            oneThird += 50;
            twoThird += 50;
            graphic.DrawLine(p, oneThird, 50, oneThird, 650);//vertical left

            graphic.DrawLine(p, twoThird, 50, twoThird, 650);//vertical right
            graphic.DrawLine(p, 50, twoThird, 650, twoThird);//horizontal bottom
            graphic.DrawLine(p, 50, oneThird, 650, oneThird);//horizontal top
            p.Color = Color.DarkSeaGreen;
            p.Width = 15;
            graphic.DrawRectangle(p, 50, 50, 600, 600);
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j<3; j++ )
                {
                    if(gameBoard[i,j] == 'X')
                    {
                        Point[,] rectPoints = findRectangle(i, j);
                        graphic.DrawLine(p, rectPoints[0, 0], rectPoints[1, 1]);
                        graphic.DrawLine(p, rectPoints[1, 0], rectPoints[0, 1]);

                    }
                    if(gameBoard[i,j] == 'O')
                    {
                        Point[,] rectPoints = findRectangle(i, j);
                        graphic.DrawEllipse(p, rectPoints[0, 0].X, rectPoints[0, 0].Y, 130, 130);

                    }

                }

            }

            

            base.OnPaint(e);

        }


        public int  checkWin( bool player1)
        {
            this.Invalidate();
            if (gameBoard[0, 0] != '0')
            {



                if (gameBoard[0, 0].Equals(gameBoard[0, 1]) && gameBoard[0, 0].Equals(gameBoard[0, 2]))
                {

                    if (!player1)
                    {

                        lblWhoWon.Text = "Player 1 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 1;
                    }
                    else
                    {


                        lblWhoWon.Text = "Player 2 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 2;
                    }

                }


                if (gameBoard[0, 0].Equals(gameBoard[1, 0]) && gameBoard[0, 0].Equals(gameBoard[2, 0]))
                {


                    if (!player1)
                    {

                        lblWhoWon.Text = "Player 1 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 1;
                    }
                    else
                    {


                        lblWhoWon.Text = "Player 2 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 2;
                    }


                }

                if (gameBoard[0, 0].Equals(gameBoard[1, 1]) && gameBoard[0, 0].Equals(gameBoard[2, 2]))
                {

                   
                    if (!player1)
                    {
                        
                        lblWhoWon.Text = "Player 1 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 1;
                    }
                    lblWhoWon.Text = "Player 2 wins!";
                    lblWhoWon.Visible = true;
                    start = false;
                    return 2;


                }

            }


            if(gameBoard[0,1] != '0')
            {

                if(gameBoard[0,1].Equals(gameBoard[1,1]) && gameBoard[0,1].Equals(gameBoard[2,1]))
                {

                    
                    if (!player1)
                    {
                        
                        lblWhoWon.Text = "Player 1 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 1;
                    }
                    lblWhoWon.Text = "Player 2 wins!";
                    lblWhoWon.Visible = true;
                    start = false;
                    return 2;

                }



            }


            if (gameBoard[0, 2] != '0')
            {


                if (gameBoard[0, 2].Equals(gameBoard[1,2]) && gameBoard[0,2].Equals(gameBoard[2,2]))
                {

                    
                    if (!player1)
                    {
                        
                        lblWhoWon.Text = "Player 1 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 1;
                    }
                    lblWhoWon.Text = "Player 2 wins!";
                    lblWhoWon.Visible = true;
                    start = false;
                    return 2;


                }


            }

            if(gameBoard[1,0]!='0')
            {

                if(gameBoard[1,0].Equals(gameBoard[1,1]) && gameBoard[1,0].Equals(gameBoard[1,2]))
                {

                    
                    if (!player1)
                    {
                        
                        lblWhoWon.Text = "Player 1 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 1;
                    }
                    lblWhoWon.Text = "Player 2 wins!";
                    lblWhoWon.Visible = true;
                    start = false;
                    return 2;


                }


            }

            if(gameBoard[0,2] != '0')
            {
                if(gameBoard[0,2].Equals(gameBoard[1,2]) && gameBoard[0,2].Equals(gameBoard[2,2]))
                {
                    
                    if (!player1)
                    {
                        
                        lblWhoWon.Text = "Player 1 wins!";
                        lblWhoWon.Visible = true;
                        start = false;
                        return 1;
                    }
                    lblWhoWon.Text = "Player 2 wins!";
                    lblWhoWon.Visible = true;
                    start = false;
                    return 2;


                }


            }

           if(spacesLeft == 0)
            {
                
                
                lblWhoWon.Text = "The cats win this round";
                lblWhoWon.Visible = true;
                start = false;
                return 0;

            }




            return -1;
            


            


        }


        public void clearForm()
        {
            
            start = false;
            spacesLeft = 9;
            player1 = true;
            singlePlayer = false;
            lblPlayer1.Visible = false;
            lblPlayer2.Visible = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    gameBoard[i, j] = '0';


                }

            }
            
            this.Invalidate();

        }


        public Point[,] findRectangle(int row, int col)
        {
            //int padding = 30;
            int edge = 200;
            int originX = (edge * col) + MARGIN + PADDING;
            int originY = (edge * row) + MARGIN + PADDING;

            
            Point origin = new Point(originX,originY);//0,0
            int fx = originX + edge - (2*PADDING);
            int fy = originY + edge - (2*PADDING);
            Point fxy = new Point(fx, fy);//1,1
            Point fxOY = new Point(fx, originY);//0,1
            Point oxFY = new Point(originX, fy);//1,0
            Point[,] p = new Point[2, 2];
            p[0, 0] = origin;
            p[0, 1] = fxOY;
            p[1, 0] = oxFY;
            p[1, 1] = fxy;
            return p;


        }




        private void ticTacForm_Load(object sender, EventArgs e)
        {

           

            for(int i = 0; i< 3; i++)
            {
                for(int j = 0; j<3; j++)
                {

                    gameBoard[i, j] = '0';


                }

            }

          


        }
       





        private void ticTacForm_MouseClick(object sender, MouseEventArgs e)
        {

            if(!start)
            {
                return;
            }
            int rawX = e.X - 50;
            int rawY = e.Y - 50;
            
            int col = rawX / 200;
            int row = rawY / 200;
           
            if(row > 2 || col > 2)
            {
                return;

            }

            



            if(player1)//is it player 1's turn they are x
            {
                lblPlayer1.Visible = true;
                if (gameBoard[row, col] == '0')
                {
                    gameBoard[row, col] = 'X';
                    player1 = false;
                    --spacesLeft;
                    if(checkWin( player1) == 1)
                    {
                        MessageBox.Show("player 1 won");
                    }
                    
                    lblPlayer1.Visible = false;
                    lblPlayer2.Visible = true;
                }
                else
                {
                    return;
                }
            }

            if(!player1 && singlePlayer)
            {
                if(checkWin(false) == 1 || checkWin(false) == 0)
                {
                    return;
                }
                Random randy = new Random();
                
                
                int r = randy.Next(3);
                int c = randy.Next(3);
                while(gameBoard[r,c] != '0')
                {
                    r = randy.Next(3);
                    c = randy.Next(3);
                }

                gameBoard[r, c] = 'O';
                player1 = true;
                --spacesLeft;
                checkWin(player1);
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = false;


            }


            if(!player1 && !singlePlayer)//player 2's turn they are O's
            {

                lblPlayer2.Visible = true;
                if(gameBoard[row,col] == '0')
                {
                    gameBoard[row, col] = 'O';
                    player1 = true;
                    --spacesLeft;
                    checkWin( player1);
                    lblPlayer2.Visible = false;
                    lblPlayer1.Visible = true;

                }
                else
                {
                    return;
                }
            }


            //this.Invalidate();


        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            lblWhoWon.Visible = false;
            clearForm();
            start = true;
            DialogResult result = MessageBox.Show("Single Player?", "Set Up", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                singlePlayer = true;
            }

            Random randy = new Random();
            int coin = randy.Next(101);
            if(coin < 50)
            {
                MessageBox.Show("Tails! O's go first. (Player 2)");
                player1 = false;
                


                int r = randy.Next(3);
                int c = randy.Next(3);
                while (gameBoard[r, c] != '0')
                {
                    r = randy.Next(3);
                    c = randy.Next(3);
                }

                gameBoard[r, c] = 'O';
                player1 = true;
                --spacesLeft;
                checkWin(player1);
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = false;

            }
            if (coin > 50)
            {
                MessageBox.Show("Heads! X's go first. (Player 1)");
                player1 = true;
            }

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rulesMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click start game and then follow the directions for single or 2 player game.  A coin toss decideds who goes first."
                + "Be the first to get three in a row either diagonally or straight across.");
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Alex Price\n Version: 0.9\n May 5th, 2017");
        }
    }


   
}
