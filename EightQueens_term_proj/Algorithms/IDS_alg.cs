using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EightQueens_term_proj.Algorithms
{
	public class IDS_alg
	{
		static Bitmap qPic = new Bitmap(Image.FromFile("queen.png"), 65, 65);
		private DFS_alg boardIDS = new DFS_alg();
		private int N = 8;
		
		public Board IDS(Board board)
		{
			if (oneIDS(0,board))
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

		public bool oneIDS(int col, Board board)
		{
			for (int i = 0; i < N; i++)
			{
				bool res = boardIDS.OneDFS(i, board);
				if (res == true)
				{
					return res;
				}

			}
			return false;
		}
	}
}