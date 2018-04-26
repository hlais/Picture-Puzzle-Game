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

            lblMovesMade.Text += inMoves;
            lblTimeElapsed.Text = "00:00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void Shuffle()
        {
            do
            {
                int j;
                //8 not pressent since it is a last slice
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
                Random r = new Random();

                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9)
                    {
                        //store empty picture in box index
                        inNullSliceIndex = i;
                    }
                }
            } while (CheckWin());
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();

            if (lblTimeElapsed.Text != "00:00:00")
            {
                //if timer has started
                YesOrNo = MessageBox.Show("Are you sure you want to RESTART?", "Picute Puzzle",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            //if user selected yes. or timer has has not started yet
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00") 
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inMoves = 0;
                lblMovesMade.Text = "Moves Made: 0";
            }
        }
        private void SwitchPictureBox(object sender, EventArgs e)
        {

            if (lblTimeElapsed.Text == "00:00:00")
            {
                //if not started timer would start
                timer.Start();
            }
            int inPicutureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            //if null picture box is different
            if (inNullSliceIndex != inPicutureBoxIndex)
            {
                //if %3=0. it means its the on the left most side //%3==2 is right most side
                List<int> FourBrothers = new List<int>(new int[] {((inPicutureBoxIndex % 3 ==0)?-1: inPicutureBoxIndex-1), inPicutureBoxIndex -3,( inPicutureBoxIndex % 3==2)
                    ? -1: inPicutureBoxIndex +1, inPicutureBoxIndex +3 });
               

                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    //current picture box in blank image
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPicutureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPicutureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPicutureBoxIndex;
                    lblMovesMade.Text = "Moves Made : " + (++inMoves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        //once all pic match we put the blank pic back in its place
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Congratulations you have completed the game\n YOU ROCK!!" + timer.Elapsed.ToString().Remove(8) +
                            "\nTotal Moves Made :" + inMoves, "Rabit Puzzle");
                        //reseting values
                        inMoves = 0;
                        lblMovesMade.Text = "Moves Made: 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Start();
        }

        bool CheckWin()
        {
            int i;
            for ( i = 0; i < 8; i++)
            {
                //the images were added in the groupbox
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i])
                    break;
            }
            if (i == 8) return true;
            else return false;
        }

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
            {
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            }
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                lblMovesMade.Text = "Moves Made : 0";
                lblTimeElapsed.Text = "00:00:00";
                inMoves = 0;
                //pause button activates when user plays
                btnPause.Enabled = false;
                MessageBox.Show("Time is Up\n Try Again", "Rabbit Puzzle");
                Shuffle();
            }
        }

        private void AskAskPermissionBeforeQuit(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNo = MessageBox.Show("Are you sure you want to quit ?", "Rabbit Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNo == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnQuit && YesOrNo == DialogResult.Yes) Environment.Exit(0);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            AskAskPermissionBeforeQuit((object)sender, e as FormClosedEventArgs );
        }

     

        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Resume";
            }
            else
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pause";
            }
        }
    }
}
