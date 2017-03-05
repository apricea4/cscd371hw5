using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace priceacscd371hw5
{
    public class TacBox
    {
        public Point topL;
        public Point botR;
        public char piece;

        






        public TacBox(Point topL, Point botR)
        {
            this.topL = topL;
            this.botR = botR;
        }

        public void setPiece(char piece)
        {
            this.piece = piece;
        }
        public char getPiece()
        {
            return this.piece;
        }

    }

   
}
