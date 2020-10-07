using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApptest1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static List<string> winList = new List<string> ();
        
        String symbol = "X";
        int xWinCounter = 0;
        int oWinCounter = 0;
        int drawCounter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {   

           foreach (Control c in gameBoard.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.Enabled = true;
                    c.BackColor = Color.LightGray;
                }
            }

            ProgressLabel.Text = "Game in process!";
          
        }


            private void btn1_1_Click(object sender, EventArgs e)
        {   
            if (symbol == "X")
            {
                move(symbol, btn1_1);
                symbol = "O";
                
            }
            else if (symbol == "O")
            {
                move(symbol, btn1_1);
                symbol = "X";
            }
           
        }
        private void btn1_2_Click(object sender, EventArgs e)
        {
            if (symbol == "X")
            {
                move(symbol, btn1_2);
                symbol = "O";

            }
            else if (symbol == "O")
            {
                move(symbol, btn1_2);
                symbol = "X";
            }

        }
        private void btn1_3_Click(object sender, EventArgs e)
        {
            if (symbol == "X")
            {
                move(symbol, btn1_3);
                symbol = "O";

            }
            else if (symbol == "O")
            {
                move(symbol, btn1_3);
                symbol = "X";
            }

        }
        private void btn2_1_Click(object sender, EventArgs e)
        {
            if (symbol == "X")
            {
                move(symbol, btn2_1);
                symbol = "O";

            }
            else if (symbol == "O")
            {
                move(symbol, btn2_1);
                symbol = "X";
            }

        }
        private void btn2_2_Click(object sender, EventArgs e)
        {
            if (symbol == "X")
            {
                move(symbol, btn2_2);
                symbol = "O";

            }
            else if (symbol == "O")
            {
                move(symbol, btn2_2);
                symbol = "X";
            }

        }
        private void btn2_3_Click(object sender, EventArgs e)
        {
            if (symbol == "X")
            {
                move(symbol, btn2_3);
                symbol = "O";

            }
            else if (symbol == "O")
            {
                move(symbol, btn2_3);
                symbol = "X";
            }

        }
        private void btn3_1_Click(object sender, EventArgs e)
        {
            if (symbol == "X")
            {
                move(symbol, btn3_1);
                symbol = "O";

            }
            else if (symbol == "O")
            {
                move(symbol, btn3_1);
                symbol = "X";
            }

        }
        private void btn3_2_Click(object sender, EventArgs e)
        {
            if (symbol == "X")
            {
                move(symbol, btn3_2);
                symbol = "O";

            }
            else if (symbol == "O")
            {
                move(symbol, btn3_2);
                symbol = "X";
            }

        }
        private void btn3_3_Click(object sender, EventArgs e)
        {
            if (symbol == "X")
            {
                move(symbol, btn3_3);
                symbol = "O";

            }
            else if (symbol == "O")
            {
                move(symbol, btn3_3);
                symbol = "X";
            }

        }
        private void move (string symbol, Button buttonName)
        {
            
            if (symbol == "X")
            {
               
                buttonName.Text = symbol;
                buttonName.Enabled = false;

                if (checkWinner() == true)
                {
                    xWinCounter++;
                    winList.Add(Convert.ToString(DateTime.Now) + "   X wins");
                    XwinLabel.Text = "X wins = " + xWinCounter;
                    ProgressLabel.Text = "X wins! :)";
                    foreach (Control c in gameBoard.Controls)
                    {
                        if (c is Button)
                        {
                            c.Text = "";
                            c.Enabled = false;

                        }
                    }
                    
                }
               
            }
            else if (symbol == "O")
            {
                
                buttonName.Text = symbol;
                buttonName.Enabled = false;

                if (checkWinner() == true)
                {
                    oWinCounter++;
                    winList.Add(Convert.ToString(DateTime.Now) + "   O wins");
                    OwinLabel.Text = "O wins = " + oWinCounter;
                    ProgressLabel.Text = "O wins! :)";
                    foreach (Control c in gameBoard.Controls)
                    {
                        if (c is Button)
                        {
                            c.Text = "";
                            c.Enabled = false;

                        }
                    }
                    
                }

            }
            if ((!btn1_1.Enabled) && (!btn1_2.Enabled) && (!btn1_3.Enabled) && (!btn2_1.Enabled) && (!btn2_2.Enabled) && (!btn2_3.Enabled) && (!btn3_1.Enabled) && (!btn3_2.Enabled) && (btn3_3.Enabled))
            {
                drawCounter++;
                ProgressLabel.Text = "DRAW ! ";
                DrawLabel.Text = "Draws =" + drawCounter;
            }
        }
        private bool checkWinner ()
        { 
            if ((btn1_1.Text == btn1_2.Text)&&(btn1_2.Text==btn1_3.Text)&& (!btn1_1.Enabled))
            {
                btn1_1.BackColor = Color.Green;
                btn1_2.BackColor = Color.Green;
                btn1_3.BackColor = Color.Green;
                return true;
            }
            else if ((btn2_1.Text == btn2_2.Text) && (btn2_2.Text == btn2_3.Text) && (!btn2_1.Enabled))
            {
                btn2_1.BackColor = Color.Green;
                btn2_2.BackColor = Color.Green;
                btn2_3.BackColor = Color.Green;
                return true;
            }
            else if ((btn3_1.Text == btn3_2.Text) && (btn3_2.Text == btn3_3.Text) && (!btn3_1.Enabled))
            {
                btn3_1.BackColor = Color.Green;
                btn3_2.BackColor = Color.Green;
                btn3_3.BackColor = Color.Green;
                return true;
            }
            else if ((btn1_1.Text == btn2_1.Text) && (btn2_1.Text == btn3_1.Text) && (!btn1_1.Enabled))
            {
                btn1_1.BackColor = Color.Green;
                btn2_1.BackColor = Color.Green;
                btn3_1.BackColor = Color.Green;
                return true;
            }
            else if ((btn1_2.Text == btn2_2.Text) && (btn2_2.Text == btn3_2.Text) && (!btn1_2.Enabled))
            {
                btn1_2.BackColor = Color.Green;
                btn2_2.BackColor = Color.Green;
                btn3_2.BackColor = Color.Green;
                return true;
            }
            else if ((btn1_3.Text == btn2_3.Text) && (btn2_3.Text == btn3_3.Text) && (!btn1_3.Enabled))
            {
                btn1_3.BackColor = Color.Green;
                btn2_3.BackColor = Color.Green;
                btn3_3.BackColor = Color.Green;
                return true;
            }
            else if ((btn1_1.Text == btn2_2.Text) && (btn2_2.Text == btn3_3.Text) && (!btn1_1.Enabled))
            {
                btn1_1.BackColor = Color.Green;
                btn2_2.BackColor = Color.Green;
                btn3_3.BackColor = Color.Green;
                return true;
            }
            else if ((btn1_3.Text == btn2_2.Text) && (btn2_2.Text == btn3_1.Text) && (!btn1_3.Enabled))
            {
                btn1_3.BackColor = Color.Green;
                btn2_2.BackColor = Color.Green;
                btn3_1.BackColor = Color.Green;
                return true;
            }

            else
            {
                return false;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveForm form2 = new SaveForm();
            form2.ShowDialog();
        }

        private void History_Click(object sender, EventArgs e)
        {
            LoadForm form3 = new LoadForm();
            form3.ShowDialog();
        }
    }
}
