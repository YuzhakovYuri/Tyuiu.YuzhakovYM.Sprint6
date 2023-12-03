using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.YuzhakovYM.Sprint6.Task2.V3.Lib;

namespace Tyuiu.YuzhakovYM.Sprint6.Task2.V3
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
                int startValue = Convert.ToInt32(textBoxStart_YYM.Text);
                int stopValue = Convert.ToInt32(textBoxStop_YYM.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_YYM.Titles.Add("График функции");

                this.chartResult_YYM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_YYM.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_YYM.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartResult_YYM.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void buttonHelp_YYM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, выполнил студент группы АСОиУб-23-3 | Южаков Юрий Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}