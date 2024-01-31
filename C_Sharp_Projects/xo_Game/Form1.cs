using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xo_Game.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace xo_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int flag = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.White,10);
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(myPen, 550, 120, 250, 120);
            e.Graphics.DrawLine(myPen, 550, 220, 250, 220);

            e.Graphics.DrawLine(myPen, 340, 50, 340, 300);
            e.Graphics.DrawLine(myPen, 460, 50, 460, 300);

        }
        private void ChangePlayer()
        {
            if (lbl_Player.Text == "Player1")
                lbl_Player.Text = "Player2";
            else
                lbl_Player.Text = "Player1";
        }
        private void ChangeIcon(PictureBox sender)
        {
            if (lbl_Player.Text == "Player1")
            {
                sender.Image = Resources.O;
                sender.Tag = "O";
            }
            else
            {
                sender.Image = Resources.X;
                sender.Tag = "X";
            }
            sender.Enabled = false;
            ChangePlayer();
        }
        private string GetWinner()
        {
            if (pp_A1.Tag == pp_A2.Tag && pp_A1.Tag == pp_A3.Tag)
            {
                pp_A1.BackColor = Color.Lime;
                pp_A2.BackColor = Color.Lime;
                pp_A3.BackColor = Color.Lime;
                return pp_A1.Tag.ToString();
            }
            if (pp_B1.Tag == pp_B2.Tag && pp_B1.Tag == pp_B3.Tag)
            {
                pp_B1.BackColor = Color.Lime;
                pp_B2.BackColor = Color.Lime;
                pp_B3.BackColor = Color.Lime;
                return pp_B1.Tag.ToString();
            }
            if (pp_C1.Tag == pp_C2.Tag && pp_C1.Tag == pp_C3.Tag)
            {
                pp_C1.BackColor = Color.Lime;
                pp_C2.BackColor = Color.Lime;
                pp_C3.BackColor = Color.Lime;
                return pp_C1.Tag.ToString();
            }
            if (pp_A1.Tag == pp_B1.Tag && pp_A1.Tag == pp_C1.Tag)
            {
                pp_A1.BackColor = Color.Lime;
                pp_B1.BackColor = Color.Lime;
                pp_C1.BackColor = Color.Lime;
                return pp_A1.Tag.ToString();
            }
            if (pp_A2.Tag == pp_B2.Tag && pp_A2.Tag == pp_C2.Tag)
            {
                pp_A2.BackColor = Color.Lime;
                pp_B2.BackColor = Color.Lime;
                pp_C2.BackColor = Color.Lime;
                return pp_A2.Tag.ToString();
            }
            if (pp_A3.Tag == pp_B3.Tag && pp_A3.Tag == pp_C3.Tag)
            {
                pp_A3.BackColor = Color.Lime;
                pp_B3.BackColor = Color.Lime;
                pp_C3.BackColor = Color.Lime;
                return pp_A3.Tag.ToString();
            }
            if (pp_A1.Tag == pp_B2.Tag && pp_A1.Tag == pp_C3.Tag)
            {
                pp_A1.BackColor = Color.Lime;
                pp_B2.BackColor = Color.Lime;
                pp_C3.BackColor = Color.Lime;
                return pp_A1.Tag.ToString();
            }
            if (pp_A3.Tag == pp_B2.Tag && pp_A3.Tag == pp_C1.Tag)
            {
                pp_A3.BackColor = Color.Lime;
                pp_B2.BackColor = Color.Lime;
                pp_C1.BackColor = Color.Lime;
                return pp_A3.Tag.ToString();
            }
            else
                return "In Progress";
                
        }
        private void PrintWinner()
        {
            string Winner = GetWinner();
            if (Winner == "O")
                lbl_Result.Text = "Player1";
            else if (Winner == "X")
                lbl_Result.Text = "Player2";
            else if (flag == 9)
                lbl_Result.Text = "No Winner";
            else
                lbl_Result.Text = "In Progress";
        }
        private void stopGame()
        {
            if (lbl_Result.Text != "In Progress")
            {
                pp_A1.Enabled = false;
                pp_A2.Enabled = false;
                pp_A3.Enabled = false;
                pp_B1.Enabled = false;
                pp_B2.Enabled = false;
                pp_B3.Enabled = false;
                pp_C1.Enabled = false;
                pp_C2.Enabled = false;
                pp_C3.Enabled = false;
                MessageBox.Show("Game Over!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        private void pp_Click(object sender, EventArgs e)
        {

            ChangeIcon((PictureBox)sender);
            flag++;
            PrintWinner();
            stopGame();
        }
        private void btn_RestartGame_Click(object sender, EventArgs e)
        {
            lbl_Player.Text = "Player1";
            lbl_Result.Text = "In Progress";

            pp_A1.Image = Resources.question_mark_96;
            pp_A1.Tag = "A1";
            pp_A1.Enabled = true;
            pp_A1.BackColor = Color.Black;

            pp_A2.Image = Resources.question_mark_96;
            pp_A2.Tag = "A2";
            pp_A2.Enabled = true;
            pp_A2.BackColor = Color.Black;

            pp_A3.Image = Resources.question_mark_96;
            pp_A3.Tag = "A3";
            pp_A3.Enabled = true;
            pp_A3.BackColor = Color.Black;

            pp_B1.Image = Resources.question_mark_96;
            pp_B1.Tag = "B1";
            pp_B1.Enabled = true;
            pp_B1.BackColor = Color.Black;
            
            pp_B2.Image = Resources.question_mark_96;
            pp_B2.Tag = "B2";
            pp_B2.Enabled = true;
            pp_B2.BackColor = Color.Black;

            pp_B3.Image = Resources.question_mark_96;
            pp_B3.Tag = "B3";
            pp_B3.Enabled = true;
            pp_B3.BackColor = Color.Black;

            pp_C1.Image = Resources.question_mark_96;
            pp_C1.Tag = "C1";
            pp_C1.Enabled = true;
            pp_C1.BackColor = Color.Black;

            pp_C2.Image = Resources.question_mark_96;
            pp_C2.Tag = "C2";
            pp_C2.Enabled = true;
            pp_C2.BackColor = Color.Black;

            pp_C3.Image = Resources.question_mark_96;
            pp_C3.Tag = "C3";
            pp_C3.Enabled = true;
            pp_C3.BackColor = Color.Black;

            flag = 0;
        }

    }
}
