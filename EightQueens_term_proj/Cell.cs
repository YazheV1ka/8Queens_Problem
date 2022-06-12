using System.Windows.Forms;

namespace EightQueens_term_proj
{
    public class Cell : Button
    {
        public int Value { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public bool IsLocked { get; set; }

        public void ClearCell()
        {
            Image = null;
            Value = 0;
            IsLocked = false;
        }
    }
}