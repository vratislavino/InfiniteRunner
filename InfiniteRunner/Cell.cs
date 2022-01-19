using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteRunner
{
    public class Cell
    {
        public CellType type = CellType.None;

        public void Draw(Graphics g, int x, int y) {
            g.DrawRectangle(Pens.Black, x * 50, y * 50, 50, 50);
            switch (type) {
                case CellType.Obstacle:
                    g.FillRectangle(Brushes.Red, x * 50, y * 50, 50, 50);
                    break;
                case CellType.Coin:
                    g.FillEllipse(Brushes.Yellow, x * 50, y * 50, 50, 50);
                    break;
            }
        }
    }
    public enum CellType
    {
        None,
        Obstacle,
        Coin
    }
}
