using System;
using System.Windows.Forms;
using EightQueens_term_proj.Algorithms;
using EightQueens_term_proj.FileWorker;

namespace EightQueens_term_proj
{
    public partial class Form1 : Form
    {
        public static int N = 8;
        public Field field = new Field();
        
        private DFS_alg algDFS = new DFS_alg();
        private BFS_alg algBFS = new BFS_alg();
        private IDS_alg algIDS = new IDS_alg();
        private Files placementFile = new Files();
        
     
        public Form1()
        {
            InitializeComponent();
            field.createCells(gameField);
        }
        
        /*[Information for user]*/
        
        // Rules
        private void btnRules_Click(object sender, EventArgs e)
        {
            string text = "1. Put 8 queens on a chessboard so that they don`t attack each other." +
                          "\n2. While custom placement, you can`t place queen on the same column or row." +
                          "\n3. If you can`t solve the task - choose one of the methods.";
            MessageBox.Show(text,caption:"Rules");
        }
        
        // Information about algorithms 
        private void btnMInfo_Click(object sender, EventArgs e)
        {
            string text2 = "LDFS - Explores as far as possible along each branch before backtracking from the root node.\n" +
                          "\nBFS - All nodes are reachable from the root node.\n" +
                          "\nIDS - Combines LDFS & BFS. Сalls DFS for a fixed depth, starting at the root node. ";
            MessageBox.Show(text2,caption:"Metods");
        }
        
        /*[Board service for user]*/
        
        // Clear field
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            field.ClearField();
            MessageBox.Show("Field was cleared");
        }
        
        // Check user solution
        private void Checkbtn_Click(object sender, EventArgs e)
        {
            var count = 0;
            Board _board = new Board(field.Cells);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (_board.boardCheck(_board,i,j) == false)
                    {
                        MessageBox.Show("Wrong placement ☠☠☠\nTry again!");
                        return;
                    }
                }
            }
            MessageBox.Show("You win!!!");
        }
        
        /*[Solution Methods]*/

        // LDFS
        //!!!!!!!!!!!!
        public void DFSbtn_Click(object sender, EventArgs e)
        {
            foreach (var cell in field.Cells)
            {
                cell.IsLocked = false;
            }
            var boardDFS = new Board(field.Cells);
            placementFile.UserInput("userInput.txt",boardDFS);
            var res = algDFS.DFS(boardDFS);
            if (res != null)
            {
                algDFS.ShowBoardDFS(field.Cells,boardDFS);
                placementFile.AlgOutput("algOutput.txt",res.board);
                foreach (var cell in field.Cells)
                {
                    cell.IsLocked = true;
                }
            }
            else
            {
                MessageBox.Show("No result :(");
            }
        }
        
        // BFS
        //Ban next solution by timer and clear
        public void BFSbtn_Click(object sender, EventArgs e)
        {
            foreach (var cell in field.Cells)
            {
                cell.IsLocked = false;
            }
            var boardBFS = new Board(field.Cells);
            var res = algBFS.BFS(boardBFS);
            placementFile.UserInput("userInput.txt",boardBFS);

            if (res != null)
            {
                algBFS.ShowBoardBFS(field.Cells);
                //placementFile.AlgOutput("algOutput.txt",res);
                foreach (var cell in field.Cells)
                {
                    cell.IsLocked = true;
                }
            }
            else
            {
                MessageBox.Show("No result :(");
            }
        }
        
        // IDS
        public void IDSbtn_Click(object sender, EventArgs e)
        {
            var boardIDS = new Board(field.Cells);
            placementFile.UserInput("userInput.txt",boardIDS);  
            var res = algIDS.IDS(boardIDS);
            if (res != null)
            {
                algIDS.ShowBoardIDS(field.Cells,boardIDS);
                placementFile.AlgOutput("algOutput.txt",res);
            }
            else
            {
                MessageBox.Show("No result :(");
            }
        }
    }
}