using System.IO;

namespace EightQueens_term_proj.FileWorker
{
    public class Files
    {
        private int N = 8;

        //User placement file
        public void UserInput(string path,Board board)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            
            string[] res = new string[N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (board.board[j,i] == 1)
                    {
                        
                        res[i] += "♕ ";
                    }
                    else
                    {
                        res[i] += "_ ";

                    }
                }

                res[i] += "\n";
            }
            
            File.WriteAllLines(path,res);
        }
        
        //Algorithms placement file
        public void AlgOutput(string path, Board board)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            
            string[] res = new string[N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (board.board[j, i] == 1)
                    {
                        
                        res[i] += "♕ ";
                    }
                    else
                    {
                        res[i] += "_ ";

                    }
                }

                res[i] += "\n";
            }
            
            File.WriteAllLines(path,res);
        }
        
        //Algorithms placement file
        public void AlgOutput(string path, int[,] board)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            
            string[] res = new string[N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (board[j, i] == 1)
                    {
                        
                        res[i] += "♕ ";
                    }
                    else
                    {
                        res[i] += "_ ";

                    }
                }

                res[i] += "\n";
            }
            
            File.WriteAllLines(path,res);
        }
    }
}