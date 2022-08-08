using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gomoku
{
    class Cell:Button
    {
        public bool isOccupied;
        public int OccupiedID;
        public Cell(int H, int W)
        {
            isOccupied = false;
            OccupiedID = -1;
            this.Height = H;
            this.Width = W;
        }
    }
}
