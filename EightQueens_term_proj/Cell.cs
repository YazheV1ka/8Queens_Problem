using System.Windows.Forms;

namespace EightQueens_term_proj
{
    public class Cell : Button
    {
        private int x;
        private int y;
        private bool isLocked;
        private int value;
      
        public int Value
        {
            get => value;
            set => this.value = value;
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public bool IsLocked
        {
            get => isLocked;
            set => isLocked = value;
        }
        public void ClearCell()
        {
            Image = null;
            Value = 0;
            IsLocked = false;
        }
    }
}