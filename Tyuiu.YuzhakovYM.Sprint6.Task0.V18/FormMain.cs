using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.YuzhakovYM.Sprint6.Task0.V18.Lib;

namespace Tyuiu.YuzhakovYM.Sprint6.Task0.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_YYM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_YYM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxDataX_YYM.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_YYM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, выполнил студент группы АСОиУб-23-3 | Южаков Юрий Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
