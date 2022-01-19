using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteRunner
{
    public class Player
    {
        public int x = 0;
        public int y = 1;
        public void Draw(Graphics g) {
            g.FillEllipse(Brushes.Blue, x * 50, y * 50, 50, 50);
        }
    }
}
