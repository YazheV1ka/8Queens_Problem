using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EightQueens_term_proj.Algorithms
{
    public class IDS_alg
    {
        /*bool bottomReached = false; // Variable to keep track if we have reached the bottom of the tree
        static Bitmap qPic = new Bitmap(Image.FromFile("queen.png"), 65, 65);
        private int N = 8;
        
        public Board DFS(Board board)
        {
            if (OneDFS(0,board))
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
        Node iterativeDeepeningDFS(Node start, int target)
        {
            // Start by doing DFS with a depth of 1, keep doubling depth until we reach the "bottom" of the tree or find the node we're searching for
            int depth = 1;
            while (!bottomReached)
            {
                bottomReached = true; // One of the "end nodes" of the search with this depth has to still have children and set this to false again
                Node result = iterativeDeepeningDFS(start, target, 0, depth);
                if (result != null)
                {
                    // We've found the goal node while doing DFS with this max depth
                    return result;
                }

                // We haven't found the goal node, but there are still deeper nodes to search through
                depth *= 2;
            }

            // Bottom reached is true.
            // We haven't found the node and there were no more nodes that still have children to explore at a higher depth.
            return null;
        }

        Node iterativeDeepeningDFS(Node node, int target, int currentDepth, int maxDepth)
        {
            System.out.println("Visiting Node " + node.value);
            if (node.value == target)
            {
                // We have found the goal node we we're searching for
                return node;
            }

            if (currentDepth == maxDepth)
            {
                System.out.println("Current maximum depth reached, returning...");
                // We have reached the end for this depth...
                if (node.children.Length > 0)
                {
                    //...but we have not yet reached the bottom of the tree
                    bottomReached = false;
                }

                return null;
            }

            // Recurse with all children
            for (int i = 0; i < node.children.Length; i++)
            {
                Node result = iterativeDeepeningDFS(node.children[i], target, currentDepth + 1, maxDepth);
                if (result != null)
                {
                    // We've found the goal node while going down that child
                    return result;
                }
            }

            // We've gone through all children and not found the goal node
            return null;
        }

        class Node
        {
            public Node[] children;
            public int value;
        }
        */

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

