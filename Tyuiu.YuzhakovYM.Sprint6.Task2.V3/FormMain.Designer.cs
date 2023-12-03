
namespace Tyuiu.YuzhakovYM.Sprint6.Task2.V3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_YYM = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_YYM = new System.Windows.Forms.PictureBox();
            this.labelCondition_YYM = new System.Windows.Forms.Label();
            this.groupBoxValues_YYM = new System.Windows.Forms.GroupBox();
            this.labelStop_YYM = new System.Windows.Forms.Label();
            this.labelStart_YYM = new System.Windows.Forms.Label();
            this.textBoxStop_YYM = new System.Windows.Forms.TextBox();
            this.textBoxStart_YYM = new System.Windows.Forms.TextBox();
            this.buttonHelp_YYM = new System.Windows.Forms.Button();
            this.buttonDone_YYM = new System.Windows.Forms.Button();
            this.groupBoxResult_YYM = new System.Windows.Forms.GroupBox();
            this.chartResult_YYM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_YYM = new System.Windows.Forms.DataGridView();
            this.ColumnX_YYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFX_YYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_YYM = new System.Windows.Forms.Label();
            this.groupBoxCondition_YYM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_YYM)).BeginInit();
            this.groupBoxValues_YYM.SuspendLayout();
            this.groupBoxResult_YYM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_YYM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_YYM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_YYM
            // 
            this.groupBoxCondition_YYM.Controls.Add(this.pictureBoxCondition_YYM);
            this.groupBoxCondition_YYM.Controls.Add(this.labelCondition_YYM);
            this.groupBoxCondition_YYM.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_YYM.Name = "groupBoxCondition_YYM";
            this.groupBoxCondition_YYM.Size = new System.Drawing.Size(519, 331);
            this.groupBoxCondition_YYM.TabIndex = 0;
            this.groupBoxCondition_YYM.TabStop = false;
            this.groupBoxCondition_YYM.Text = "Условие";
            // 
            // pictureBoxCondition_YYM
            // 
            this.pictureBoxCondition_YYM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_YYM.Image")));
            this.pictureBoxCondition_YYM.Location = new System.Drawing.Point(13, 73);
            this.pictureBoxCondition_YYM.Name = "pictureBoxCondition_YYM";
            this.pictureBoxCondition_YYM.Size = new System.Drawing.Size(303, 33);
            this.pictureBoxCondition_YYM.TabIndex = 1;
            this.pictureBoxCondition_YYM.TabStop = false;
            // 
            // labelCondition_YYM
            // 
            this.labelCondition_YYM.AutoSize = true;
            this.labelCondition_YYM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCondition_YYM.Location = new System.Drawing.Point(10, 20);
            this.labelCondition_YYM.Name = "labelCondition_YYM";
            this.labelCondition_YYM.Size = new System.Drawing.Size(435, 34);
            this.labelCondition_YYM.TabIndex = 0;
            this.labelCondition_YYM.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.\r\n";
            // 
            // groupBoxValues_YYM
            // 
            this.groupBoxValues_YYM.Controls.Add(this.labelStop_YYM);
            this.groupBoxValues_YYM.Controls.Add(this.labelStart_YYM);
            this.groupBoxValues_YYM.Controls.Add(this.textBoxStop_YYM);
            this.groupBoxValues_YYM.Controls.Add(this.textBoxStart_YYM);
            this.groupBoxValues_YYM.Location = new System.Drawing.Point(13, 351);
            this.groupBoxValues_YYM.Name = "groupBoxValues_YYM";
            this.groupBoxValues_YYM.Size = new System.Drawing.Size(256, 100);
            this.groupBoxValues_YYM.TabIndex = 1;
            this.groupBoxValues_YYM.TabStop = false;
            this.groupBoxValues_YYM.Text = "Ввод данных:";
            // 
            // labelStop_YYM
            // 
            this.labelStop_YYM.AutoSize = true;
            this.labelStop_YYM.Location = new System.Drawing.Point(134, 55);
            this.labelStop_YYM.Name = "labelStop_YYM";
            this.labelStop_YYM.Size = new System.Drawing.Size(69, 13);
            this.labelStop_YYM.TabIndex = 3;
            this.labelStop_YYM.Text = "Конец шага:";
            // 
            // labelStart_YYM
            // 
            this.labelStart_YYM.AutoSize = true;
            this.labelStart_YYM.Location = new System.Drawing.Point(7, 55);
            this.labelStart_YYM.Name = "labelStart_YYM";
            this.labelStart_YYM.Size = new System.Drawing.Size(67, 13);
            this.labelStart_YYM.TabIndex = 2;
            this.labelStart_YYM.Text = "Старт шага:";
            // 
            // textBoxStop_YYM
            // 
            this.textBoxStop_YYM.Location = new System.Drawing.Point(137, 74);
            this.textBoxStop_YYM.Name = "textBoxStop_YYM";
            this.textBoxStop_YYM.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_YYM.TabIndex = 1;
            // 
            // textBoxStart_YYM
            // 
            this.textBoxStart_YYM.Location = new System.Drawing.Point(7, 74);
            this.textBoxStart_YYM.Name = "textBoxStart_YYM";
            this.textBoxStart_YYM.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_YYM.TabIndex = 0;
            // 
            // buttonHelp_YYM
            // 
            this.buttonHelp_YYM.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_YYM.Location = new System.Drawing.Point(275, 351);
            this.buttonHelp_YYM.Name = "buttonHelp_YYM";
            this.buttonHelp_YYM.Size = new System.Drawing.Size(86, 100);
            this.buttonHelp_YYM.TabIndex = 2;
            this.buttonHelp_YYM.Text = "Справка";
            this.buttonHelp_YYM.UseVisualStyleBackColor = false;
            this.buttonHelp_YYM.Click += new System.EventHandler(this.buttonHelp_YYM_Click);
            // 
            // buttonDone_YYM
            // 
            this.buttonDone_YYM.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_YYM.Location = new System.Drawing.Point(367, 351);
            this.buttonDone_YYM.Name = "buttonDone_YYM";
            this.buttonDone_YYM.Size = new System.Drawing.Size(165, 100);
            this.buttonDone_YYM.TabIndex = 3;
            this.buttonDone_YYM.Text = "Выполнить";
            this.buttonDone_YYM.UseVisualStyleBackColor = false;
            this.buttonDone_YYM.Click += new System.EventHandler(this.buttonDone_YYM_Click);
            // 
            // groupBoxResult_YYM
            // 
            this.groupBoxResult_YYM.Controls.Add(this.chartResult_YYM);
            this.groupBoxResult_YYM.Controls.Add(this.dataGridViewResult_YYM);
            this.groupBoxResult_YYM.Controls.Add(this.labelResult_YYM);
            this.groupBoxResult_YYM.Location = new System.Drawing.Point(539, 13);
            this.groupBoxResult_YYM.Name = "groupBoxResult_YYM";
            this.groupBoxResult_YYM.Size = new System.Drawing.Size(485, 438);
            this.groupBoxResult_YYM.TabIndex = 4;
            this.groupBoxResult_YYM.TabStop = false;
            this.groupBoxResult_YYM.Text = "Вывод данных:";
            // 
            // chartResult_YYM
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_YYM.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartResult_YYM.Legends.Add(legend4);
            this.chartResult_YYM.Location = new System.Drawing.Point(135, 29);
            this.chartResult_YYM.Name = "chartResult_YYM";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_YYM.Series.Add(series4);
            this.chartResult_YYM.Size = new System.Drawing.Size(344, 387);
            this.chartResult_YYM.TabIndex = 2;
            // 
            // dataGridViewResult_YYM
            // 
            this.dataGridViewResult_YYM.AllowUserToResizeColumns = false;
            this.dataGridViewResult_YYM.AllowUserToResizeRows = false;
            this.dataGridViewResult_YYM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_YYM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_YYM,
            this.ColumnFX_YYM});
            this.dataGridViewResult_YYM.Location = new System.Drawing.Point(10, 45);
            this.dataGridViewResult_YYM.Name = "dataGridViewResult_YYM";
            this.dataGridViewResult_YYM.RowHeadersVisible = false;
            this.dataGridViewResult_YYM.Size = new System.Drawing.Size(104, 371);
            this.dataGridViewResult_YYM.TabIndex = 1;
            // 
            // ColumnX_YYM
            // 
            this.ColumnX_YYM.HeaderText = "X";
            this.ColumnX_YYM.Name = "ColumnX_YYM";
            this.ColumnX_YYM.ReadOnly = true;
            this.ColumnX_YYM.Width = 50;
            // 
            // ColumnFX_YYM
            // 
            this.ColumnFX_YYM.HeaderText = "F(X)";
            this.ColumnFX_YYM.Name = "ColumnFX_YYM";
            this.ColumnFX_YYM.ReadOnly = true;
            this.ColumnFX_YYM.Width = 50;
            // 
            // labelResult_YYM
            // 
            this.labelResult_YYM.AutoSize = true;
            this.labelResult_YYM.Location = new System.Drawing.Point(7, 20);
            this.labelResult_YYM.Name = "labelResult_YYM";
            this.labelResult_YYM.Size = new System.Drawing.Size(62, 13);
            this.labelResult_YYM.TabIndex = 0;
            this.labelResult_YYM.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 459);
            this.Controls.Add(this.groupBoxResult_YYM);
            this.Controls.Add(this.buttonDone_YYM);
            this.Controls.Add(this.buttonHelp_YYM);
            this.Controls.Add(this.groupBoxValues_YYM);
            this.Controls.Add(this.groupBoxCondition_YYM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Южаков Ю. М.";
            this.groupBoxCondition_YYM.ResumeLayout(false);
            this.groupBoxCondition_YYM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_YYM)).EndInit();
            this.groupBoxValues_YYM.ResumeLayout(false);
            this.groupBoxValues_YYM.PerformLayout();
            this.groupBoxResult_YYM.ResumeLayout(false);
            this.groupBoxResult_YYM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_YYM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_YYM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_YYM;
        private System.Windows.Forms.GroupBox groupBoxValues_YYM;
        private System.Windows.Forms.Label labelStop_YYM;
        private System.Windows.Forms.Label labelStart_YYM;
        private System.Windows.Forms.TextBox textBoxStop_YYM;
        private System.Windows.Forms.TextBox textBoxStart_YYM;
        private System.Windows.Forms.Button buttonHelp_YYM;
        private System.Windows.Forms.Button buttonDone_YYM;
        private System.Windows.Forms.Label labelCondition_YYM;
        private System.Windows.Forms.PictureBox pictureBoxCondition_YYM;
        private System.Windows.Forms.GroupBox groupBoxResult_YYM;
        private System.Windows.Forms.Label labelResult_YYM;
        private System.Windows.Forms.DataGridView dataGridViewResult_YYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_YYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX_YYM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_YYM;
    }
}

