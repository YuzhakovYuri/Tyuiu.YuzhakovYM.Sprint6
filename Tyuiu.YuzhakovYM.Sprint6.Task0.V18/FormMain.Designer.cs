
namespace Tyuiu.YuzhakovYM.Sprint6.Task0.V18
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
            this.groupBoxMain_YYM = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_YYM = new System.Windows.Forms.PictureBox();
            this.labelCondition_YYM = new System.Windows.Forms.Label();
            this.groupBoxData_YYM = new System.Windows.Forms.GroupBox();
            this.labelDataX_YYM = new System.Windows.Forms.Label();
            this.textBoxDataX_YYM = new System.Windows.Forms.TextBox();
            this.groupBoxResult_YYM = new System.Windows.Forms.GroupBox();
            this.labelResult_YYM = new System.Windows.Forms.Label();
            this.textBoxResult_YYM = new System.Windows.Forms.TextBox();
            this.buttonDone_YYM = new System.Windows.Forms.Button();
            this.buttonInfo_YYM = new System.Windows.Forms.Button();
            this.groupBoxMain_YYM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_YYM)).BeginInit();
            this.groupBoxData_YYM.SuspendLayout();
            this.groupBoxResult_YYM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain_YYM
            // 
            this.groupBoxMain_YYM.Controls.Add(this.pictureBoxCondition_YYM);
            this.groupBoxMain_YYM.Controls.Add(this.labelCondition_YYM);
            this.groupBoxMain_YYM.Location = new System.Drawing.Point(12, 26);
            this.groupBoxMain_YYM.Name = "groupBoxMain_YYM";
            this.groupBoxMain_YYM.Size = new System.Drawing.Size(753, 241);
            this.groupBoxMain_YYM.TabIndex = 0;
            this.groupBoxMain_YYM.TabStop = false;
            this.groupBoxMain_YYM.Text = "Условие";
            // 
            // pictureBoxCondition_YYM
            // 
            this.pictureBoxCondition_YYM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_YYM.Image")));
            this.pictureBoxCondition_YYM.InitialImage = null;
            this.pictureBoxCondition_YYM.Location = new System.Drawing.Point(34, 52);
            this.pictureBoxCondition_YYM.Name = "pictureBoxCondition_YYM";
            this.pictureBoxCondition_YYM.Size = new System.Drawing.Size(137, 80);
            this.pictureBoxCondition_YYM.TabIndex = 1;
            this.pictureBoxCondition_YYM.TabStop = false;
            // 
            // labelCondition_YYM
            // 
            this.labelCondition_YYM.AutoSize = true;
            this.labelCondition_YYM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCondition_YYM.Location = new System.Drawing.Point(7, 20);
            this.labelCondition_YYM.Name = "labelCondition_YYM";
            this.labelCondition_YYM.Size = new System.Drawing.Size(636, 17);
            this.labelCondition_YYM.TabIndex = 0;
            this.labelCondition_YYM.Text = "Дано выражение, вычислить его значение при x = 3. Округлить до трёх знаков после " +
    "запятой.";
            // 
            // groupBoxData_YYM
            // 
            this.groupBoxData_YYM.Controls.Add(this.labelDataX_YYM);
            this.groupBoxData_YYM.Controls.Add(this.textBoxDataX_YYM);
            this.groupBoxData_YYM.Location = new System.Drawing.Point(12, 286);
            this.groupBoxData_YYM.Name = "groupBoxData_YYM";
            this.groupBoxData_YYM.Size = new System.Drawing.Size(397, 113);
            this.groupBoxData_YYM.TabIndex = 1;
            this.groupBoxData_YYM.TabStop = false;
            this.groupBoxData_YYM.Text = "Ввод данных";
            // 
            // labelDataX_YYM
            // 
            this.labelDataX_YYM.AutoSize = true;
            this.labelDataX_YYM.Location = new System.Drawing.Point(6, 37);
            this.labelDataX_YYM.Name = "labelDataX_YYM";
            this.labelDataX_YYM.Size = new System.Drawing.Size(84, 13);
            this.labelDataX_YYM.TabIndex = 1;
            this.labelDataX_YYM.Text = "Переменная X:";
            // 
            // textBoxDataX_YYM
            // 
            this.textBoxDataX_YYM.Location = new System.Drawing.Point(10, 53);
            this.textBoxDataX_YYM.Name = "textBoxDataX_YYM";
            this.textBoxDataX_YYM.ReadOnly = true;
            this.textBoxDataX_YYM.Size = new System.Drawing.Size(80, 20);
            this.textBoxDataX_YYM.TabIndex = 0;
            this.textBoxDataX_YYM.Text = "3";
            // 
            // groupBoxResult_YYM
            // 
            this.groupBoxResult_YYM.Controls.Add(this.labelResult_YYM);
            this.groupBoxResult_YYM.Controls.Add(this.textBoxResult_YYM);
            this.groupBoxResult_YYM.Location = new System.Drawing.Point(425, 286);
            this.groupBoxResult_YYM.Name = "groupBoxResult_YYM";
            this.groupBoxResult_YYM.Size = new System.Drawing.Size(340, 113);
            this.groupBoxResult_YYM.TabIndex = 2;
            this.groupBoxResult_YYM.TabStop = false;
            this.groupBoxResult_YYM.Text = "Вывод данных";
            // 
            // labelResult_YYM
            // 
            this.labelResult_YYM.AutoSize = true;
            this.labelResult_YYM.Location = new System.Drawing.Point(6, 37);
            this.labelResult_YYM.Name = "labelResult_YYM";
            this.labelResult_YYM.Size = new System.Drawing.Size(62, 13);
            this.labelResult_YYM.TabIndex = 2;
            this.labelResult_YYM.Text = "Результат:";
            // 
            // textBoxResult_YYM
            // 
            this.textBoxResult_YYM.Location = new System.Drawing.Point(6, 53);
            this.textBoxResult_YYM.Name = "textBoxResult_YYM";
            this.textBoxResult_YYM.ReadOnly = true;
            this.textBoxResult_YYM.Size = new System.Drawing.Size(80, 20);
            this.textBoxResult_YYM.TabIndex = 1;
            // 
            // buttonDone_YYM
            // 
            this.buttonDone_YYM.Location = new System.Drawing.Point(656, 405);
            this.buttonDone_YYM.Name = "buttonDone_YYM";
            this.buttonDone_YYM.Size = new System.Drawing.Size(109, 33);
            this.buttonDone_YYM.TabIndex = 3;
            this.buttonDone_YYM.Text = "Выполнить";
            this.buttonDone_YYM.UseVisualStyleBackColor = true;
            this.buttonDone_YYM.Click += new System.EventHandler(this.buttonDone_YYM_Click);
            // 
            // buttonInfo_YYM
            // 
            this.buttonInfo_YYM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_YYM.Location = new System.Drawing.Point(618, 405);
            this.buttonInfo_YYM.Name = "buttonInfo_YYM";
            this.buttonInfo_YYM.Size = new System.Drawing.Size(32, 33);
            this.buttonInfo_YYM.TabIndex = 4;
            this.buttonInfo_YYM.Text = "?";
            this.buttonInfo_YYM.UseVisualStyleBackColor = true;
            this.buttonInfo_YYM.Click += new System.EventHandler(this.buttonInfo_YYM_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_YYM);
            this.Controls.Add(this.buttonDone_YYM);
            this.Controls.Add(this.groupBoxResult_YYM);
            this.Controls.Add(this.groupBoxData_YYM);
            this.Controls.Add(this.groupBoxMain_YYM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 18 | Южаков Ю.М.";
            this.groupBoxMain_YYM.ResumeLayout(false);
            this.groupBoxMain_YYM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_YYM)).EndInit();
            this.groupBoxData_YYM.ResumeLayout(false);
            this.groupBoxData_YYM.PerformLayout();
            this.groupBoxResult_YYM.ResumeLayout(false);
            this.groupBoxResult_YYM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain_YYM;
        private System.Windows.Forms.PictureBox pictureBoxCondition_YYM;
        private System.Windows.Forms.Label labelCondition_YYM;
        private System.Windows.Forms.GroupBox groupBoxData_YYM;
        private System.Windows.Forms.Label labelDataX_YYM;
        private System.Windows.Forms.TextBox textBoxDataX_YYM;
        private System.Windows.Forms.GroupBox groupBoxResult_YYM;
        private System.Windows.Forms.Label labelResult_YYM;
        private System.Windows.Forms.TextBox textBoxResult_YYM;
        private System.Windows.Forms.Button buttonDone_YYM;
        private System.Windows.Forms.Button buttonInfo_YYM;
    }
}

