using System;
using System.Collections.Generic;
using System.Drawing;

namespace EightQueens_term_proj.Algorithms
{
    public class BFS_alg
    {
        static int N = 8;
        static LinkedList<int[,]> boards = new LinkedList<int[,]>();
        static int[,] solution = null;
        static Bitmap qPic = new Bitmap(Image.FromFile("queen.png"), 65, 65);

        static int checkSolution(int[,] board)
        {
            int queenCount = 0;
            //Iterate over board to count the amount of queens in a state
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (board[i, j] == 1)
                    {
                        queenCount++;
                    }
                }
            }

            return queenCount;
        }

        public static bool isSafeBFS(int[,] board, int row, int col)
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

        static void addQueen(int[,] board)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //Check if board safe
                    if (isSafeBFS(board, i, j))
                    {
                        //Check if the current board has the correct queens for this step
                        if (checkSolution(board) == i)
                        {
                            int[,] temp = new int[8, 8];
                            for (int x = 0; x < N; x++)
                            {
                                for (int y = 0; y < N; y++)
                                {
                                    temp[x, y] = board[x, y];
                                }
                            }

                            temp[i, j] = 1;
                            //Add new child
                            boards.AddLast(temp);
                        }
                    }
                }
            }
        }

        static void placeQueens(int[,] board)
        {
            for (int i = 0; i < N; i++)
            {
                //Create initial board
                boards.AddLast(board);
                board = new int[N, N];
            }
        }

        public void ShowBoardBFS(Cell[,] cells)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (boards.First.Value[i, j] == 1)
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

        public int[,] BFS(Board board)
        {
            Random rand = new Random();
            int count;
            do
            {
                placeQueens(board.board);
                do
                {
                    checkSolution(boards.First.Value);
                    if (checkSolution(boards.First.Value) == N)
                    {
                        //Get random board
                        count = rand.Next(0, 10);
                        if (count == 6)
                        {
                            return boards.First.Value;

                        }

                        boards.Remove(boards.First.Value);
                    }
                    else
                    {
                        addQueen((boards.First.Value));
                        boards.Remove(boards.First.Value);
                    }
                } while (boards.Count > 0);
            } while (false);

            return null;
        }
    }
}