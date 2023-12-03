using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.YuzhakovYM.Sprint6.Task3.V14.Lib;

namespace Tyuiu.YuzhakovYM.Sprint6.Task3.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] StartMatrix = new int[5, 5] { { 1, 4, -5, -12, -8 },
                                     { -7, -20, 11, -13, 6 },
                                     { 2, -12, 1, -12, 3 },
                                     { -1, -7, -20, -6, 17 },
                                     { -3, 3, 2, 13, -17 } };

        private void buttonHelp_YYM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, выполнил студент группы АСОиУб-23-3 | Южаков Юрий Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_YYM_Click(object sender, EventArgs e)
        {
            int[,] matrix = ds.Calculate(StartMatrix);

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult_YYM.ColumnCount = columns;
            dataGridViewResult_YYM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_YYM.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_YYM.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
