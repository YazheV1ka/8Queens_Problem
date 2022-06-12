using System.Drawing;

namespace EightQueens_term_proj.Algorithms
{
    public class IDS_alg
    {
        static Bitmap qPic = new Bitmap(Image.FromFile("queen.png"), 65, 65);
        private int N = 8;
        private DFS_alg boardIDS = new DFS_alg();
        private int depth = 2;
        public Board IDS(Board board)
        {
            if (oneIDS(board))
            {
                return board;
            }

            return null;
        }

        public void ShowBoardIDS(Cell[,] cells, Board board)
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

        public bool oneIDS(Board board)
        {
            for (int i = 0; i < N; i++)
            {
                bool res = boardIDS.OneDFS(i, depth, board);
                if (res)
                {
                    return res;
                }
            }

            return false;
        }
    }
}