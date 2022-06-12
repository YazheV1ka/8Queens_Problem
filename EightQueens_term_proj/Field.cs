using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EightQueens_term_proj.Algorithms;

namespace EightQueens_term_proj
{
    public class Field
    {
        public static int N = 8;
        private Cell[,] cells = new Cell[N,N];
        Bitmap qPic = new Bitmap(Image.FromFile("queen.png"), 65, 65);
        DFS_alg boardDfsAlg;
        List<Cell> Qlist = new List<Cell>();

        public Cell[,] Cells
        {
            get => cells;
            set => cells = value;
        }
    
        //Field creation
        public void createCells(Panel gameField)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //creating cells w styles and so on
                    cells[i,j] = new Cell();
                    cells[i, j].Size = new Size(60, 60);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 60, j * 60);
                    cells[i, j].BackColor = ((i + 1) + (j + 1)) % 2== 0 ? SystemColors.Control : Color.Black;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;
                    cells[i, j].Value = 0;
                    cells[i, j].Click += cell_Click;
                    gameField.Controls.Add(cells[i, j]); 
                }
            }
        }
        
        //User place the Queen
        private void cell_Click(object sender, EventArgs e)
        {
            if (sender is Cell cell && !cell.IsLocked && cells!=null)
            {
                cell.Value = 1;
                cell.Image = qPic;
                int locX = cell.X;
                int locY = cell.Y;
                for (int i = 0; i < N; i++)
                {
                    cells[i,locY].IsLocked = true;
                    cells[locX,i].IsLocked = true;
                    cell.IsLocked = true;
                }
            }
            else
            {
                MessageBox.Show("You can`t place queen on the occupied row, column or cell");
            }
        }
        
        
        //Get user queen placement
        public Cell[] userPlacement(Cell[,] cells)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (cells[i,j].Value == 1)
                    {
                        Qlist.Add(cells[0,j]);
                    }
                }
            }

            return Qlist.ToArray();
        }
        
        //Clear all queens on the board
        public void ClearField()
        {
            foreach (var cell in Cells)
            {
                cell.ClearCell();
            }
        }
    }
}