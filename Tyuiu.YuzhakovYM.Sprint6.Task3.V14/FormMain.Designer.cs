
namespace Tyuiu.YuzhakovYM.Sprint6.Task3.V14
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
            this.groupBoxCondition_YYM = new System.Windows.Forms.GroupBox();
            this.labelCondition_YYM = new System.Windows.Forms.Label();
            this.labelMatrixCondition_YYM = new System.Windows.Forms.Label();
            this.groupBoxResult_YYM = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_YYM = new System.Windows.Forms.DataGridView();
            this.buttonDone_YYM = new System.Windows.Forms.Button();
            this.buttonHelp_YYM = new System.Windows.Forms.Button();
            this.groupBoxCondition_YYM.SuspendLayout();
            this.groupBoxResult_YYM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_YYM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_YYM
            // 
            this.groupBoxCondition_YYM.Controls.Add(this.labelMatrixCondition_YYM);
            this.groupBoxCondition_YYM.Controls.Add(this.labelCondition_YYM);
            this.groupBoxCondition_YYM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_YYM.Name = "groupBoxCondition_YYM";
            this.groupBoxCondition_YYM.Size = new System.Drawing.Size(479, 426);
            this.groupBoxCondition_YYM.TabIndex = 1;
            this.groupBoxCondition_YYM.TabStop = false;
            this.groupBoxCondition_YYM.Text = "Условие";
            // 
            // labelCondition_YYM
            // 
            this.labelCondition_YYM.AutoSize = true;
            this.labelCondition_YYM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCondition_YYM.Location = new System.Drawing.Point(10, 20);
            this.labelCondition_YYM.Name = "labelCondition_YYM";
            this.labelCondition_YYM.Size = new System.Drawing.Size(464, 34);
            this.labelCondition_YYM.TabIndex = 0;
            this.labelCondition_YYM.Text = "Дан массив 5 на 5 элементов. Заменить четные значения во второй\r\nстроке на 0. Рез" +
    "ультат вывести в DataGridView.";
            // 
            // labelMatrixCondition_YYM
            // 
            this.labelMatrixCondition_YYM.AllowDrop = true;
            this.labelMatrixCondition_YYM.AutoSize = true;
            this.labelMatrixCondition_YYM.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelMatrixCondition_YYM.Location = new System.Drawing.Point(10, 68);
            this.labelMatrixCondition_YYM.Name = "labelMatrixCondition_YYM";
            this.labelMatrixCondition_YYM.Size = new System.Drawing.Size(184, 153);
            this.labelMatrixCondition_YYM.TabIndex = 1;
            this.labelMatrixCondition_YYM.Text = resources.GetString("labelMatrixCondition_YYM.Text");
            // 
            // groupBoxResult_YYM
            // 
            this.groupBoxResult_YYM.Controls.Add(this.buttonHelp_YYM);
            this.groupBoxResult_YYM.Controls.Add(this.buttonDone_YYM);
            this.groupBoxResult_YYM.Controls.Add(this.dataGridViewResult_YYM);
            this.groupBoxResult_YYM.Location = new System.Drawing.Point(498, 13);
            this.groupBoxResult_YYM.Name = "groupBoxResult_YYM";
            this.groupBoxResult_YYM.Size = new System.Drawing.Size(398, 425);
            this.groupBoxResult_YYM.TabIndex = 2;
            this.groupBoxResult_YYM.TabStop = false;
            this.groupBoxResult_YYM.Text = "Результат";
            // 
            // dataGridViewResult_YYM
            // 
            this.dataGridViewResult_YYM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_YYM.ColumnHeadersVisible = false;
            this.dataGridViewResult_YYM.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewResult_YYM.Name = "dataGridViewResult_YYM";
            this.dataGridViewResult_YYM.RowHeadersVisible = false;
            this.dataGridViewResult_YYM.Size = new System.Drawing.Size(385, 306);
            this.dataGridViewResult_YYM.TabIndex = 0;
            // 
            // buttonDone_YYM
            // 
            this.buttonDone_YYM.Location = new System.Drawing.Point(214, 341);
            this.buttonDone_YYM.Name = "buttonDone_YYM";
            this.buttonDone_YYM.Size = new System.Drawing.Size(178, 65);
            this.buttonDone_YYM.TabIndex = 1;
            this.buttonDone_YYM.Text = "Выполнить";
            this.buttonDone_YYM.UseVisualStyleBackColor = true;
            this.buttonDone_YYM.Click += new System.EventHandler(this.buttonDone_YYM_Click);
            // 
            // buttonHelp_YYM
            // 
            this.buttonHelp_YYM.Location = new System.Drawing.Point(149, 341);
            this.buttonHelp_YYM.Name = "buttonHelp_YYM";
            this.buttonHelp_YYM.Size = new System.Drawing.Size(59, 65);
            this.buttonHelp_YYM.TabIndex = 2;
            this.buttonHelp_YYM.Text = "?";
            this.buttonHelp_YYM.UseVisualStyleBackColor = true;
            this.buttonHelp_YYM.Click += new System.EventHandler(this.buttonHelp_YYM_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.groupBoxResult_YYM);
            this.Controls.Add(this.groupBoxCondition_YYM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 14 | Южаков Ю. М.";
            this.groupBoxCondition_YYM.ResumeLayout(false);
            this.groupBoxCondition_YYM.PerformLayout();
            this.groupBoxResult_YYM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_YYM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_YYM;
        private System.Windows.Forms.Label labelMatrixCondition_YYM;
        private System.Windows.Forms.Label labelCondition_YYM;
        private System.Windows.Forms.GroupBox groupBoxResult_YYM;
        private System.Windows.Forms.DataGridView dataGridViewResult_YYM;
        private System.Windows.Forms.Button buttonHelp_YYM;
        private System.Windows.Forms.Button buttonDone_YYM;
    }
}

