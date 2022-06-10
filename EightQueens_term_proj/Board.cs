using System.Drawing;

namespace EightQueens_term_proj
{
    public class Board
    {
        public int N = 8;
        public int[,] board;
        /*public int[] board;*/
        private Field _field = new Field();
        
        //Board with user placement
        public Board(Cell[,] cells)
        {
            board = new int[N, N];
            var userQ = _field.userPlacement(cells);
            for (int i = 0; i < userQ.Length; i++)
            {
                var cell = userQ[i];
                board[i, cell.Y] = 1;
            }
        }

        public bool boardCheck(Board board, int row, int col)
        {
            int i = 0, j = 0, l = N;
            int conflicts = 0;
        
            
            while (j < l)
            {
                if (board.board[i, j] == 1)
                {
                    while (++j < l)
                    {
                        if (board.board[i, j] == 1)
                        {
                            conflicts++;
                        }
                    }
                }

            }

            i = row;
            j = col;
            while (j >= 0)
            {
                if (board.board[i, j] == 1)
                {
                    while (--j >= 0)
                    {
                        if (board.board[i, j] == 1)
                        {
                            conflicts++;
                        }
                    }
                }
            }

            i = row;
            j = col;
            while (i < l)
            {
                if (board.board[i, j] == 1)
                {
                    while (++i < l)
                    {
                        if (board.board[i, j] == 1)
                        {
                            conflicts++;
                        }
                    }
                }
            }

            i = row;
            j = col;
            while (i >= 0)
            {
                if (board.board[i, j] == 1)
                {
                    while (--i >= 0)
                    {
                        if (board.board[i, j] == 1)
                        {
                            conflicts++;
                        }
                    }
                }
            }

            i = row;
            j = col;
            while (i >= 0 && --j >= 0)
            {
                if (board.board[i, j] == 1)
                {
                    while (--i >= 0 && --j >= 0)
                    {
                        if (board.board[i, j] == 1)
                        {
                            conflicts++;
                        }
                    }
                }
            }

            i = row;
            j = col;
            while (i < l && ++j < l)
            {
                if (board.board[i, j] == 1)
                {
                    while (++i < l && ++j < l)
                    {
                        if (board.board[i, j] == 1)
                        {
                            conflicts++;
                        }
                    }
                }
            }

            i = row;
            j = col;
            while (i < l && j >= 0)
            {
                if (board.board[i, j] == 1)
                {
                    while (++i < l && --j >= 0)
                    {
                        if (board.board[i, j] == 1)
                        {
                            conflicts++;
                        }
                    }
                }
            }

            i = row;
            j = col;
            while (i >= 0 && j < l)
            {
                if (board.board[i, j] == 1)
                {
                    while (--i >= 0 && ++j < l)
                    {
                        if (board.board[i, j] == 1)
                        {
                            conflicts++;
                        }
                    }
                }
            }

            if (conflicts > 0)
            {
                return false; 
            }
            return true;
        }
    }
}