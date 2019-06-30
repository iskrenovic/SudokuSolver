using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {
        private const int fieldNumbers = 9;
        private const int fieldSize = 50;
        private static Color cellCollor = Color.LightGray;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            dgv.RowCount = fieldNumbers;
            dgv.ColumnCount = fieldNumbers;
            for(int i  = 0; i < fieldNumbers; ++i)
            {
                dgv.Rows[i].Height = fieldSize;                
                dgv.Columns[i].Width = fieldSize;                
                if (i < 3 || i > 5)
                {
                    dgv[i, 0].Style.BackColor = cellCollor;
                    dgv[i, 1].Style.BackColor = cellCollor;
                    dgv[i, 2].Style.BackColor = cellCollor;
                    dgv[i, 6].Style.BackColor = cellCollor;
                    dgv[i, 7].Style.BackColor = cellCollor;
                    dgv[i, 8].Style.BackColor = cellCollor;
                }
                else
                {
                    dgv[i, 3].Style.BackColor = cellCollor;
                    dgv[i, 4].Style.BackColor = cellCollor;
                    dgv[i, 5].Style.BackColor = cellCollor;
                }
            }
            dgv.Width = fieldSize * fieldNumbers + 1;
            dgv.Height = fieldSize * fieldNumbers + 1;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;            
            
        }
    }
}
