namespace BodroTest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.WeightComboBox = new System.Windows.Forms.ComboBox();
            this.GenderBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseButtonX = new System.Windows.Forms.Button();
            this.DuraksButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PogonBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.BackColor = System.Drawing.Color.Black;
            this.buttonStartTest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartTest.Font = new System.Drawing.Font("Floripa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartTest.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonStartTest.Location = new System.Drawing.Point(142, 492);
            this.buttonStartTest.Margin = new System.Windows.Forms.Padding(315, 3, 315, 3);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(519, 53);
            this.buttonStartTest.TabIndex = 0;
            this.buttonStartTest.Text = "НАЧАТЬ ТЕСТ";
            this.buttonStartTest.UseVisualStyleBackColor = false;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.Black;
            this.NameBox.Font = new System.Drawing.Font("AvantGarde", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(360, 30);
            this.NameBox.Margin = new System.Windows.Forms.Padding(10);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(216, 38);
            this.NameBox.TabIndex = 2;
            // 
            // WeightComboBox
            // 
            this.WeightComboBox.BackColor = System.Drawing.Color.Black;
            this.WeightComboBox.DropDownWidth = 217;
            this.WeightComboBox.Font = new System.Drawing.Font("AvantGarde", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightComboBox.ForeColor = System.Drawing.Color.White;
            this.WeightComboBox.IntegralHeight = false;
            this.WeightComboBox.Location = new System.Drawing.Point(360, 264);
            this.WeightComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.WeightComboBox.Name = "WeightComboBox";
            this.WeightComboBox.Size = new System.Drawing.Size(216, 36);
            this.WeightComboBox.TabIndex = 5;
            // 
            // GenderBox
            // 
            this.GenderBox.BackColor = System.Drawing.Color.Black;
            this.GenderBox.Font = new System.Drawing.Font("AvantGarde", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderBox.ForeColor = System.Drawing.Color.White;
            this.GenderBox.Location = new System.Drawing.Point(360, 206);
            this.GenderBox.Margin = new System.Windows.Forms.Padding(10);
            this.GenderBox.Multiline = true;
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(216, 38);
            this.GenderBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ИМЯ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(45, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "ГЕНДЕР";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Chartreuse;
            this.label5.Location = new System.Drawing.Point(45, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "ВЕС НА РАЙОНЕ";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Black;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Floripa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.SubmitButton.Location = new System.Drawing.Point(136, 492);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(315, 3, 315, 3);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(531, 53);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "ОТПРАВИТЬ";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ФАМИЛИЯ";
            // 
            // SurnameBox
            // 
            this.SurnameBox.BackColor = System.Drawing.Color.Black;
            this.SurnameBox.Font = new System.Drawing.Font("AvantGarde", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameBox.ForeColor = System.Drawing.Color.White;
            this.SurnameBox.Location = new System.Drawing.Point(360, 90);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(10);
            this.SurnameBox.Multiline = true;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(216, 38);
            this.SurnameBox.TabIndex = 14;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Floripa", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chartreuse;
            this.label7.Location = new System.Drawing.Point(46, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(706, 48);
            this.label7.TabIndex = 15;
            this.label7.Text = "РЕГИСТРАЦИЯ";
            // 
            // CloseButtonX
            // 
            this.CloseButtonX.BackColor = System.Drawing.Color.Black;
            this.CloseButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButtonX.Font = new System.Drawing.Font("Floripa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButtonX.ForeColor = System.Drawing.Color.Chartreuse;
            this.CloseButtonX.Location = new System.Drawing.Point(758, 12);
            this.CloseButtonX.Name = "CloseButtonX";
            this.CloseButtonX.Size = new System.Drawing.Size(30, 30);
            this.CloseButtonX.TabIndex = 16;
            this.CloseButtonX.Text = "X";
            this.CloseButtonX.UseVisualStyleBackColor = false;
            this.CloseButtonX.Click += new System.EventHandler(this.CloseButtonX_Click);
            // 
            // DuraksButton
            // 
            this.DuraksButton.BackColor = System.Drawing.Color.Black;
            this.DuraksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DuraksButton.Font = new System.Drawing.Font("Floripa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DuraksButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.DuraksButton.Location = new System.Drawing.Point(710, 12);
            this.DuraksButton.Name = "DuraksButton";
            this.DuraksButton.Size = new System.Drawing.Size(30, 30);
            this.DuraksButton.TabIndex = 17;
            this.DuraksButton.Text = "?";
            this.DuraksButton.UseVisualStyleBackColor = false;
            this.DuraksButton.Click += new System.EventHandler(this.DuraksButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Controls.Add(this.PogonBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.SurnameBox);
            this.groupBox1.Controls.Add(this.GenderBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.WeightComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(91, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 412);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // PogonBox
            // 
            this.PogonBox.BackColor = System.Drawing.Color.Black;
            this.PogonBox.Font = new System.Drawing.Font("AvantGarde", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PogonBox.ForeColor = System.Drawing.Color.White;
            this.PogonBox.Location = new System.Drawing.Point(360, 148);
            this.PogonBox.Margin = new System.Windows.Forms.Padding(10);
            this.PogonBox.Multiline = true;
            this.PogonBox.Name = "PogonBox";
            this.PogonBox.Size = new System.Drawing.Size(216, 38);
            this.PogonBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(45, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ПОГОНЯЛО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Floripa", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Chartreuse;
            this.label6.Location = new System.Drawing.Point(267, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ГРАМОТНЫЙ ТЕСТ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DuraksButton);
            this.Controls.Add(this.CloseButtonX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox WeightComboBox;
        private System.Windows.Forms.TextBox GenderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CloseButtonX;
        private System.Windows.Forms.Button DuraksButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PogonBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}