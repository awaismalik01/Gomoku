using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Gomoku : Form
    {
        Cell[,] Cs;
        int Dim = -1;
        int player = 0, NOP = 2;
        public Gomoku()
        {
            InitializeComponent();
        }

        void OnCellClick(object sender, EventArgs e)
        {
            Cell clickedcell = (Cell)sender;

            if(clickedcell.isOccupied)
            {
                MessageBox.Show("You Cheater...!!!");
                return;
            }

            if(player == 0)
            {
                clickedcell.OccupiedID = player;
                clickedcell.isOccupied = true;
                clickedcell.BackColor = Color.Blue;
                IsWin();
            }
            else
            {
                clickedcell.OccupiedID = player;
                clickedcell.isOccupied = true;
                clickedcell.BackColor = Color.Red;
                IsWin();
            }
           
            player = (player + 1) % NOP;
            

        }
        void Init()
        {
            Grid.Controls.Clear();
            Cs = new Cell[Dim, Dim];
            for (int r = 0; r < Dim; r++)
            {
                for(int c = 0; c<Dim; c++)
                {
                    int H = Grid.Height / Dim - 6;
                    int W = Grid.Width / Dim - 6;

                    Cell acell = new Cell(H, W);
                    acell.Click += new EventHandler(OnCellClick);
                    Grid.Controls.Add(acell);
                    Cs[r, c] = acell;
                }
            }

        }

        void IsWin()
        {
            int F1 = 0, F2 = 0;
            for (int r = 0; r < Dim; r++)
            {
                for (int c = 0; c < Dim; c++)
                {
                    if(Cs[r, c].OccupiedID == 0)
                    {
                        F1 = 0;
                        for (int i = r, j = c; j < Dim && F1 != 5; j++)         //cols wise
                        {
                            if (Cs[i, j].OccupiedID == 0)
                            {
                                F1++;
                            }
                            else
                            {
                                F1 = 0;
                                break;
                            }
                        }

                        for (int i = r, j = c; i < Dim && F1 != 5; i++)         //rows wise
                        {
                            if (Cs[i, j].OccupiedID == 0)
                            {
                                F1++;
                            }
                            else
                            {
                                F1 = 0;
                                break;
                            }
                        }

                        for (int i = r, j = c; j < Dim && i < Dim && F1 != 5; j++, i++)         //Diagnal wise
                        {
                            if (Cs[i, j].OccupiedID == 0)
                            {
                                F1++;
                            }
                            else
                            {
                                F1 = 0;
                                break;
                            }
                        }
                        if (F1 == 5)
                        {
                            MessageBox.Show("Blue Wins");
                            break;
                        }
                    }

                    if (Cs[r, c].OccupiedID == 1)
                    {
                        F2 = 0;
                        for (int i = r, j = c; j < Dim && F2 != 5; j++)         //cols wise
                        {
                            if (Cs[i, j].OccupiedID == 1)
                            {
                                F2++;
                            }
                            else
                            {
                                F2 = 0;
                                break;
                            }
                        }

                        for (int i = r, j = c; i < Dim && F2 != 5; i++)         //rows wise
                        {
                            if (Cs[i, j].OccupiedID == 1)
                            {
                                F2++;
                            }
                            else
                            {
                                F2 = 0;
                                break;
                            }
                        }

                        for (int i = r, j = c; j < Dim && i < Dim && F2 != Dim; j++, i++)         //Diagnal wise
                        {
                            if (Cs[i, j].OccupiedID == 1)
                            {
                                F2++;
                            }
                            else
                            {
                                F2 = 0;
                                break;
                            }
                        }
                        if (F2 == 5)
                        {
                            MessageBox.Show("Red Wins");
                            break;
                        }
                    }
                }
                if (F1 == 5 || F2 == 5)
                {
                    Grid.Controls.Clear();
                    break;
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Fivex5.Checked == true)
                Dim = 5;
            else if (Tenx10.Checked == true)
                Dim = 10;
            else if (Fifteenx15.Checked == true)
                Dim = 15;
            else if (Nineteenx19.Checked == true)
                Dim = 19;

            if(Dim == -1)
            {
                MessageBox.Show("Select THE OPTION Please...!!!");
            }
            else
            {
                MessageBox.Show(Dim.ToString());
                Init();
            }   
        }

        private void Fivex5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fifteenx15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gomoku_Load(object sender, EventArgs e)
        {

        }

        private void Tenx10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Nineteenx19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
