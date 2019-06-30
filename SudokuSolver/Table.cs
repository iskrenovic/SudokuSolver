using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    
    class Table
    {
        private static int n;
        private Field[,] fields;
        private bool[,] rows;
        private bool[,] columns;
        private bool[,] boxes;

        public Table(int n2, int[,] table)
        {
            n = n2;
            fields = new Field[n, n];
            rows = new bool[n, n];
            columns = new bool[n, n];
            boxes = new bool[n, n];

            for(int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    if (table[i, j] != 0)
                    {
                        fields[i, j].SetValue(table[i, j]);
                        rows[i, table[i, j]] = true;
                        columns[j, table[i, j]] = true;
                        boxes[GetBoxLocation(i,j),table[i,j]] = true;
                    }                    
                }
            }
        }       

        public void Solve()
        {
            
        }

        private void Init()
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (rows[i, j])
                    {
                         
                    }
                }
            }
        }

        private int GetBoxLocation(int x, int y)
        {
            return 9 / x * 3 + 9 / y;
        }

        private bool IsSameBox(int x1, int y1, int x2, int y2)
        {
            if(9/x1==9/x2 && 9/y1 == 9/y2) return true;
            return false;
        }
    }
}
