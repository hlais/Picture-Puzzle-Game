using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Picture_Puzzle_Game
{
    public partial class Form1 : Form
    {
        int inNullSliceIndex, inMoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();

        Stopwatch timer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3,
                Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7,
                Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
