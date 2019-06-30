using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Field
    {
        private int value = 0;
        private bool[] possible;

        public bool IsPossible(int value)
        {
            if(this.value == 0)
            {
                return possible[value];
            }
            return false;
        }

        public void SetValue(int value)
        {
            this.value = value;

        }
    }
}
