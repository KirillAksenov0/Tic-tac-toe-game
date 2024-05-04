using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {

        bool playerX = true;
        int xCount;
        int oCount;
        string X;
        string O;
        public Form1()
        {

            InitializeComponent();

            xCount = 0;
            oCount = 0;
            XCount.Text = xCount.ToString();
            OCount.Text = oCount.ToString();
            X = "X";
            O = "O";

        }

        private void LeftUpButton_Click(object sender, EventArgs e)
        {
            if (LeftUpButton.Text == "")
            {
                if (playerX)
                {
                    LeftUpButton.Text = X;
                    LeftUpButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    LeftUpButton.Text = O;
                    LeftUpButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }

            WinCondition();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (UpButton.Text == "")
            {
                if (playerX)
                {
                    UpButton.Text = X;
                    UpButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    UpButton.Text = O;
                    UpButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }

            WinCondition();
        }

        private void RightUpButton_Click(object sender, EventArgs e)
        {
            if (RightUpButton.Text == "")
            {
                if (playerX)
                {
                    RightUpButton.Text = X;
                    RightUpButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    RightUpButton.Text = O;
                    RightUpButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }

            WinCondition();
        }
        private void LeftDownButton_Click(object sender, EventArgs e)
        {
            if (LeftDownButton.Text == "")
            {
                if (playerX)
                {
                    LeftDownButton.Text = X;
                    LeftDownButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    LeftDownButton.Text = O;
                    LeftDownButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }
            WinCondition();
        }


        private void ClearButtons()
        {
            RightUpButton.Text = "";
            UpButton.Text = "";
            LeftUpButton.Text = "";
            RightButton.Text = "";
            CenterButton.Text = "";
            LeftButton.Text = "";
            RightDownButton.Text = "";
            DownButton.Text = "";
            LeftDownButton.Text = "";
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (LeftButton.Text == "")
            {
                if (playerX)
                {
                    LeftButton.Text = X;
                    LeftButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    LeftButton.Text = O;
                    LeftButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }
            WinCondition();
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            if (CenterButton.Text == "")
            {
                if (playerX)
                {
                    CenterButton.Text = X;
                    CenterButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    CenterButton.Text = O;
                    CenterButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }
            WinCondition();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (RightButton.Text == "")
            {
                if (playerX)
                {
                    RightButton.Text = X;
                    RightButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    RightButton.Text = O;
                    RightButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }
            WinCondition();
        }



        private void DownButton_Click(object sender, EventArgs e)
        {
            if (DownButton.Text == "")
            {
                if (playerX)
                {
                    DownButton.Text = X;
                    DownButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    DownButton.Text = O;
                    DownButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }
            WinCondition();
        }

        private void RightDownButton_Click(object sender, EventArgs e)
        {
            if (RightDownButton.Text == "")
            {
                if (playerX)
                {
                    RightDownButton.Text = X;
                    RightDownButton.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    RightDownButton.Text = O;
                    RightDownButton.ForeColor = System.Drawing.Color.Blue;
                }

                playerX = !playerX;
            }
            WinCondition();
        }

        private void WinCondition()
        {
            if (LeftUpButton.Text == X & UpButton.Text == X && RightUpButton.Text == X)
            {
                xCount++;
                XCount.Text = xCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftUpButton.Text == O & UpButton.Text == O && RightUpButton.Text == O)
            {
                oCount++;
                OCount.Text = oCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftButton.Text == X & CenterButton.Text == X && RightButton.Text == X)
            {
                xCount++;
                XCount.Text = xCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftButton.Text == O & CenterButton.Text == O && RightButton.Text == O)
            {
                oCount++;
                OCount.Text = oCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftDownButton.Text == X & DownButton.Text == X && RightDownButton.Text == X)
            {
                xCount++;
                XCount.Text = xCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftDownButton.Text == O & DownButton.Text == O && RightDownButton.Text == O)
            {
                oCount++;
                OCount.Text = oCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftUpButton.Text == X & CenterButton.Text == X && RightDownButton.Text == X)
            {
                xCount++;
                XCount.Text = xCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftUpButton.Text == O & CenterButton.Text == O && RightDownButton.Text == O)
            {
                oCount++;
                OCount.Text = oCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (RightUpButton.Text == X & CenterButton.Text == X && LeftDownButton.Text == X)
            {
                xCount++;
                XCount.Text = xCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (RightUpButton.Text == O & CenterButton.Text == O && LeftDownButton.Text == O)
            {
                oCount++;
                OCount.Text = oCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (RightUpButton.Text == X & RightButton.Text == X && RightDownButton.Text == X)
            {
                xCount++;
                XCount.Text = xCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (RightUpButton.Text == O & RightButton.Text == O && RightDownButton.Text == O)
            {
                oCount++;
                OCount.Text = oCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (UpButton.Text == X & CenterButton.Text == X && DownButton.Text == X)
            {
                xCount++;
                XCount.Text = xCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (UpButton.Text == O & CenterButton.Text == O && DownButton.Text == O)
            {
                oCount++;
                OCount.Text = oCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftUpButton.Text == X & LeftButton.Text == X && LeftDownButton.Text == X)
            {
                xCount++;
                XCount.Text = xCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (LeftUpButton.Text == O & LeftButton.Text == O && LeftDownButton.Text == O)
            {
                oCount++;
                OCount.Text = oCount.ToString();
                ClearButtons();
                playerX = true;
            }
            else if (RightUpButton.Text != "" && UpButton.Text != "" && LeftUpButton.Text != ""
                && CenterButton.Text != "" && RightButton.Text != "" & LeftButton.Text != "" &&
                DownButton.Text != "" && LeftDownButton.Text != "" && RightDownButton.Text != "")
            {
                ClearButtons();
                playerX = true;
            }

        }
    }
}