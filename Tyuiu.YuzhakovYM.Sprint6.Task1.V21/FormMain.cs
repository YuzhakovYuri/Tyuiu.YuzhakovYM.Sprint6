using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.YuzhakovYM.Sprint6.Task1.V21.Lib;

namespace Tyuiu.YuzhakovYM.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_YYM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_YYM.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_YYM.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_YYM.Text = "";
                textBoxResult_YYM.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult_YYM.AppendText("|    X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_YYM.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}    | {1,7:f2}   | ", startValue, valueArray[i]);
                    textBoxResult_YYM.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_YYM.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void buttonHelp_YYM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1, выполнил студент группы АСОиУб-23-3 | Южаков Юрий Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
