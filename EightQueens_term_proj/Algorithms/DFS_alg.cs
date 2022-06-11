using System.Drawing;

namespace EightQueens_term_proj.Algorithms
{
    public class DFS_alg
    {
        static Bitmap qPic = new Bitmap(Image.FromFile("queen.png"), 65, 65);
        private int N = 8;

        //DFS recursion till solution is found
        public Board DFS(Board board)
        {
            if (OneDFS(0,board))
            {
                return board;
            }

            return null;
        }
        
        public void ShowBoardDFS(Cell[,] cells, Board board)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (board.board[i, j] == 1)
                    {
                        cells[i, j].Image = qPic;
                    }
                    else
                    {
                        cells[i, j].Image = null;
                    }
                }
            }
        }
        
        //Check 
        bool isSafe(int [,]board, int row, int col)
        {
            int i = row, j = col, l = N;
            
            while (++j < l)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            i = row;
            j = col;
            while (--j >= 0)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            i = row;
            j = col;
            while (++i < l)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            i = row;
            j = col;
            while (--i >= 0)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            i = row;
            j = col;
            while (--i >= 0 && --j >= 0)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            i = row;
            j = col;
            while (++i < l && ++j < l)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            i = row;
            j = col;
            while (++i < l && --j >= 0)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            i = row;
            j = col;
            while (--i >= 0 && ++j < l)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }
            
            return true;
        }
        public void UnPlaceIncorrect(int[,] board, int row, int col)
        {
            int i = row, j = col, l = N;

            while (j < l)
            {
                if (board[i, j] == 1)
                {
                    while (++j < l)
                    {
                        board[i, j] = 0;
                    }
                }
                j++;

            }

            i = row;
            j = col;
            while (j >= 0)
            {
                if (board[i, j] == 1)
                {
                    while (--j >= 0)
                    {
                        board[i, j] = 0;
                    }
                }
                j--;
            }

            i = row;
            j = col;
            while (i < l)
            {
                if (board[i, j] == 1)
                {
                    while (++i < l)
                    {
                        board[i, j] = 0;
                    }
                }
                i++;
            }

            i = row;
            j = col;
            while (i >= 0)
            {
                if (board[i, j] == 1)
                {
                    while (--i >= 0)
                    {
                        board[i, j] = 0;
                    }
                }
                i--;
            }

            i = row;
            j = col;
            while (i >= 0 && j >= 0)
            {
                if (board[i, j] == 1)
                {
                    while (--i >= 0 && --j >= 0)
                    {
                        board[i, j] = 0;
                    }
                }
                i--;
                j--;
            }

            i = row;
            j = col;
            while (i < l && j < l)
            {
                if (board[i, j] == 1)
                {
                    while (++i < l && ++j < l)
                    {
                        board[i, j] = 0;
                    }
                }
                i++;
                j++;
            }

            i = row;
            j = col;
            while (i < l && j >= 0)
            {
                if (board[i, j] == 1)
                {
                    while (++i < l && --j >= 0)
                    {
                        board[i, j] = 0;
                    }
                }
                i++;
                j--;
            }

            i = row;
            j = col;
            while (i >= 0 && j < l)
            {
                if (board[i, j] == 1)
                {
                    while (--i >= 0 && ++j < l)
                    {
                        board[i, j] = 0;
                    }
                }
                i--;
                j++;
            }
        }

        public bool OneDFS(int col, Board board)
        {
            if (col >= N) 
            {
                return true;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    UnPlaceIncorrect(board.board, i, j);
                }
            }

            for (int r = 0; r < N; r++) 
            {
                
                if (isSafe(board.board, r, col)) 
                {
                    board.board[r, col] = 1;
                    if (OneDFS(col + 1, board))
                    {
                        return true;
                    }
                    board.board[r, col] = 0;
                }
                else
                {
                    board.board[r, col] = 0;
                }
                
                
            }
            return false;
        }
    }
}