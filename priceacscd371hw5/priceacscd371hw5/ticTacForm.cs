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

        TacBox[] gameBoard = new TacBox[9];
        bool player1 = true;

        public ticTacForm()
        {
            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Pen p = new Pen(Color.CornflowerBlue, 20);
            double d = 650.0 * (2.0/3.0);
            int VRX = (int)Math.Truncate(d);
            graphic.DrawLine(p, 20 + (int)Math.Truncate(650.0 / 3), 50, 20 + (int)Math.Truncate(650.0 / 3), 650);//vertical left

            graphic.DrawLine(p, VRX + 20, 50, VRX+ 20, 650);//vertical right
            graphic.DrawLine(p, 50, (int)Math.Truncate(650.00 * (2.0/3.0) + 20), 650, (int)Math.Truncate(650.00 * (2.0/3.0)) + 20);//horizontal bottom
            graphic.DrawLine(p, 50, 650 / 3, 650, 650 / 3);//horizontal top
            p.Color = Color.DarkSeaGreen;
            p.Width = 15;
            graphic.DrawRectangle(p, 50, 50, 600, 600);
            for (int i = 0; i < 3; i++)
            {


                if (gameBoard[i].getPiece() != '0')
                {
                    //Point poi = new Point(VRX,VRX);
                    graphic.DrawLine(p, gameBoard[i].topL, gameBoard[i].botR);
                }
            }
            base.OnPaint(e);

        }

        private void ticTacForm_Load(object sender, EventArgs e)
        {
            int MTLX = (int) Math.Truncate((650.0 / 3.0) - 20);
            int MTLY =  MTLX;
            int MTRX = (int)Math.Truncate(650.0 * (2 / 3) - 20);
            int MTRY = MTLY;
            int MBLX = MTLX;
            int MBLY = MTRX;
            int MBRX = MTRX;
            int MBRY = MTRX;
            int TLX = 50;
            Point l = new Point(55, 55);
            Point r = new Point(MTLX, MTLY);
            gameBoard[0] = new TacBox(l, r);
            for(int i = 1; i < 9; i++)
            {

                if(i >= 0 && i < 3)
                {
                    TLX += (600 / 3);
                    
                    MTLX += MTLX;
                    MTLY += MTLY;
                    Point topl = new Point(TLX,50);
                    Point botR = new Point(MTLX, MTLY);
                    gameBoard[i] = new TacBox(topl, botR);

                }




            }



        }

        private void ticTacForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(MousePosition.X >= 50 && MousePosition.Y >= 50)
            {
                gameBoard[0].setPiece('X');
                gameBoard[1].setPiece('x');
                gameBoard[1].setPiece('x');

            }
            this.Invalidate();


        }
    }
}
