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
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            gameArea1.onScoreChanged += GameArea1_onScoreChanged;
        }

        private void GameArea1_onScoreChanged(int score) {
            label1.Text = "Skóre: " + score;
        }
    }
}
