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
                    //Check if state valid
                    if (isSafeBFS(board, i, j))
                    {
                        //Check if the current state has the correct queens for this step
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
                            //Add new child state to queue
                            boards.AddLast(temp);
                        }
                    }
                }
            }
        }

        static void placeInitialQueens(int[,] board)
        {
            for (int i = 0; i < N; i++)
            {
                board[0, i] = 1;
                //Create initial states
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
                placeInitialQueens(board.board);
                do
                {
                    checkSolution(boards.First.Value);
                    if (checkSolution(boards.First.Value) == N)
                    {
                        //Get random solution
                        //return rand(one return) and break;
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

/*public int N = 8;
Bitmap qPic = new Bitmap(Image.FromFile("queen.png"), 65, 65);

public void ShowBoardBFS(Board board, Cell[,] cells)
{
    var resArr = new ProblemCalculator(N).BFS();
    
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            board.board[i, j] = 0;
        }
    }
    
    for (int i = 0; i < N; i++)
    {
        board.board[i, resArr[i]] = 1;
    }

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

public class ProblemCalculator
{

    private int amount;


    private Queue<State> queue;


    public ProblemCalculator(int amount)
    {
        this.amount = amount;

        queue = new Queue<State>();
    }


    public int[] BFS()
    {
        State rootNode = new State(amount);

        State state = bfs(rootNode);

        var res = state.getPositions();
        
        return res;
    }

    public State bfs(State rootNode)
    {
        Queue<State> queue = new Queue<State>();
        
        queue.Enqueue(rootNode);
        
        while (queue.Count != 0)
        {

            State state = queue.Dequeue();

            foreach (State child in state.getChildSolutions())
            {
                if (child.isGoal())
                {
                    return child;
                }

                if (child.isAcceptable())
                {
                    queue.Enqueue(child);

                }
            }
        }
        return null;
    }
}

public class State
{
    private int[] positions;
    private int n = 8;

    public State(int n)
    {
        this.n = n;
        positions = new int[n];
        for (int i = 0; i < positions.Length; i++) positions[i] = -1;
    }


    private State(int n, int[] positions)
    {

        this.n = n;
        this.positions = positions;
    }


    public int[] getPositions()
    {
        return positions;
    }

    public bool isAcceptable()
    {

        int current = 0;

        while (current < n && positions[current] != -1)
        {

            ++current;
        }

        --current;

        for (int i = 0; i < n; ++i)
        {
            if (i != current && positions[i] != -1)
            {

                if (positions[i] == positions[current])
                {
                    return false;
                }
                if (Math.Abs((current) - i) == Math.Abs(positions[current] - positions[i]))
                {
                    return false;
                }
            }
        }
        return true;
    }


    public bool isGoal()
    {
        if (positions[n - 1] != -1 && isAcceptable())
        {
            return true;
        }

        return false;
    }

 

    public ISet<State> getChildSolutions()
    {
        ISet<State> children = new HashSet<State>();

        int row = 0;

        while (row < n && positions[row] != -1)
        {
            ++row;
        }

        if (row - 1 == n && positions[row] != -1)
        {
            return null;
        }

        for (int i = 0; i < n; ++i)
        {

            int[] childPositions = (int[]) positions.Clone();
            
            childPositions[row] = i;

            children.Add(new State(n, childPositions));
        }

        return children;
    }
}
}*/


