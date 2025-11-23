namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSqr = new System.Windows.Forms.RadioButton();
            this.radioButtonExp = new System.Windows.Forms.RadioButton();
            this.radioButtonCos = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLiner = new System.Windows.Forms.Button();
            this.btnBranching = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.textBoxZ2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panelBranching = new System.Windows.Forms.Panel();
            this.panelLinear = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите значение X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите значение Y";
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.Color.Pink;
            this.textBoxX.Location = new System.Drawing.Point(208, 366);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 26);
            this.textBoxX.TabIndex = 3;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.Color.Pink;
            this.textBoxY.Location = new System.Drawing.Point(208, 291);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 26);
            this.textBoxY.TabIndex = 4;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxResult.Location = new System.Drawing.Point(187, 566);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(243, 26);
            this.textBoxResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат: a=";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButtonSqr);
            this.groupBox1.Controls.Add(this.radioButtonExp);
            this.groupBox1.Controls.Add(this.radioButtonCos);
            this.groupBox1.Location = new System.Drawing.Point(356, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор фунции";
            // 
            // radioButtonSqr
            // 
            this.radioButtonSqr.AutoSize = true;
            this.radioButtonSqr.Location = new System.Drawing.Point(21, 69);
            this.radioButtonSqr.Name = "radioButtonSqr";
            this.radioButtonSqr.Size = new System.Drawing.Size(46, 24);
            this.radioButtonSqr.TabIndex = 2;
            this.radioButtonSqr.TabStop = true;
            this.radioButtonSqr.Text = "x²";
            this.radioButtonSqr.UseVisualStyleBackColor = true;
            this.radioButtonSqr.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonExp
            // 
            this.radioButtonExp.AutoSize = true;
            this.radioButtonExp.Location = new System.Drawing.Point(21, 106);
            this.radioButtonExp.Name = "radioButtonExp";
            this.radioButtonExp.Size = new System.Drawing.Size(76, 24);
            this.radioButtonExp.TabIndex = 1;
            this.radioButtonExp.TabStop = true;
            this.radioButtonExp.Text = "exp(x)";
            this.radioButtonExp.UseVisualStyleBackColor = true;
            // 
            // radioButtonCos
            // 
            this.radioButtonCos.AutoSize = true;
            this.radioButtonCos.Location = new System.Drawing.Point(21, 31);
            this.radioButtonCos.Name = "radioButtonCos";
            this.radioButtonCos.Size = new System.Drawing.Size(76, 24);
            this.radioButtonCos.TabIndex = 0;
            this.radioButtonCos.TabStop = true;
            this.radioButtonCos.Text = "cos(x)";
            this.radioButtonCos.UseVisualStyleBackColor = true;
            this.radioButtonCos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(219, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnLiner
            // 
            this.btnLiner.BackColor = System.Drawing.Color.Pink;
            this.btnLiner.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLiner.Location = new System.Drawing.Point(161, 3);
            this.btnLiner.Name = "btnLiner";
            this.btnLiner.Size = new System.Drawing.Size(236, 43);
            this.btnLiner.TabIndex = 10;
            this.btnLiner.Text = "Разветвленный алгоритм";
            this.btnLiner.UseVisualStyleBackColor = false;
            this.btnLiner.Click += new System.EventHandler(this.btnLiner_Click);
            // 
            // btnBranching
            // 
            this.btnBranching.BackColor = System.Drawing.Color.Pink;
            this.btnBranching.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBranching.Location = new System.Drawing.Point(895, 3);
            this.btnBranching.Name = "btnBranching";
            this.btnBranching.Size = new System.Drawing.Size(249, 43);
            this.btnBranching.TabIndex = 11;
            this.btnBranching.Text = "Линейный алгоритм";
            this.btnBranching.UseVisualStyleBackColor = false;
            this.btnBranching.Click += new System.EventHandler(this.btnBranching_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonCalc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCalc.Location = new System.Drawing.Point(937, 465);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(178, 65);
            this.buttonCalc.TabIndex = 12;
            this.buttonCalc.Text = "Рассчитать";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Результат: t=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(872, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите значение Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(871, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Введите значение X";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(862, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxY2
            // 
            this.textBoxY2.BackColor = System.Drawing.Color.Pink;
            this.textBoxY2.Location = new System.Drawing.Point(1072, 338);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(100, 26);
            this.textBoxY2.TabIndex = 17;
            this.textBoxY2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.Pink;
            this.textBoxX2.Location = new System.Drawing.Point(1072, 280);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 26);
            this.textBoxX2.TabIndex = 18;
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxResult2.Location = new System.Drawing.Point(929, 569);
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.ReadOnly = true;
            this.textBoxResult2.Size = new System.Drawing.Size(243, 26);
            this.textBoxResult2.TabIndex = 19;
            // 
            // textBoxZ2
            // 
            this.textBoxZ2.BackColor = System.Drawing.Color.Pink;
            this.textBoxZ2.Location = new System.Drawing.Point(1072, 396);
            this.textBoxZ2.Name = "textBoxZ2";
            this.textBoxZ2.Size = new System.Drawing.Size(100, 26);
            this.textBoxZ2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(873, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Введите значение Z";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1060, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 26);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // panelBranching
            // 
            this.panelBranching.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBranching.BackgroundImage")));
            this.panelBranching.Location = new System.Drawing.Point(12, 52);
            this.panelBranching.Name = "panelBranching";
            this.panelBranching.Size = new System.Drawing.Size(588, 617);
            this.panelBranching.TabIndex = 23;
            this.panelBranching.Visible = false;
            // 
            // panelLinear
            // 
            this.panelLinear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLinear.BackgroundImage")));
            this.panelLinear.Location = new System.Drawing.Point(705, 52);
            this.panelLinear.Name = "panelLinear";
            this.panelLinear.Size = new System.Drawing.Size(566, 617);
            this.panelLinear.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1294, 652);
            this.Controls.Add(this.panelLinear);
            this.Controls.Add(this.panelBranching);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxZ2);
            this.Controls.Add(this.textBoxResult2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.btnBranching);
            this.Controls.Add(this.btnLiner);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSqr;
        private System.Windows.Forms.RadioButton radioButtonExp;
        private System.Windows.Forms.RadioButton radioButtonCos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLiner;
        private System.Windows.Forms.Button btnBranching;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxResult2;
        private System.Windows.Forms.TextBox textBoxZ2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panelBranching;
        private System.Windows.Forms.Panel panelLinear;
    }
}

