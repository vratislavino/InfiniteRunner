using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfiniteRunner
{
    public partial class GameArea : UserControl
    {
        public Cell[,] cells;
        public Player player;
        private int score;
        private bool lost = false;
        public int Score {
            get {
                return score;
            }
            set {
                score = value;
                onScoreChanged?.Invoke(score);
            }
        }
        public event Action<int> onScoreChanged;
        public GameArea() {
            InitializeComponent();
            cells = new Cell[3, 7];
            for (int i = 0; i < cells.GetLength(0); i++) {
                for (int j = 0; j < cells.GetLength(1); j++) {
                    cells[i, j] = new Cell();
                }
            }
            cells[0, 2].type = CellType.Coin;
            cells[0, 0].type = CellType.Coin;

            player = new Player();
            Refresh();
        }

        private void GameArea_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            for (int i = 0; i < cells.GetLength(0); i++) {
                for (int j = 0; j < cells.GetLength(1); j++) {
                    cells[i, j].Draw(g, j, i);
                }
            }
            player.Draw(g);
        }

        private void GameArea_KeyDown(object sender, KeyEventArgs e) {
            if (lost)
                return;
            switch (e.KeyCode) {
                case Keys.W:
                    if (player.y > 0)
                        player.y -= 1;
                    break;
                case Keys.S:
                    if (player.y < cells.GetLength(0) - 1) {
                        player.y += 1;
                    }
                    break;
            }
            CheckPlayer();
            Refresh();
        }

        private void CheckPlayer() {
            Cell cell = cells[player.y, player.x];
            switch (cell.type) {
                case CellType.Obstacle:
                    Lost();
                    break;
                case CellType.Coin:
                    cell.type = CellType.None;
                    AddScore(500);
                    break;
            }
        }

        private void AddScore(int scoreToAdd) {
            Score += scoreToAdd;
        }

        private void Lost() {
            lost = true;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            MoveGameAreaLeft();
            Generate();
            CheckPlayer();
            AddScore(100);
            Refresh();
        }

        private void Generate() {
            Random r = new Random(); ;
            for (int i = 0; i < cells.GetLength(0); i++) {
                cells[i, cells.GetLength(1)-1].type = (CellType)r.Next(0, 3); 
            }
        }

        private void MoveGameAreaLeft() {
            for (int i = 0; i < cells.GetLength(1)-1; i++) {
                for (int j = 0; j < cells.GetLength(0); j++) {
                    cells[j, i].type = cells[j, i + 1].type;
                }
            }
        }
    }
}
