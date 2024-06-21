namespace BodroTest
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTotalQuestions = new System.Windows.Forms.Label();
            this.labelResultPercentage = new System.Windows.Forms.Label();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCorrectQuestions = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.buttonSendEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelTime.Location = new System.Drawing.Point(31, 71);
            this.labelTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(383, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "ВРЕМЯ ПРОХОЖДЕНИЯ";
            // 
            // labelTotalQuestions
            // 
            this.labelTotalQuestions.AutoSize = true;
            this.labelTotalQuestions.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalQuestions.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelTotalQuestions.Location = new System.Drawing.Point(31, 131);
            this.labelTotalQuestions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.labelTotalQuestions.Name = "labelTotalQuestions";
            this.labelTotalQuestions.Size = new System.Drawing.Size(402, 16);
            this.labelTotalQuestions.TabIndex = 1;
            this.labelTotalQuestions.Text = "КОЛИЧЕСТВО ВОПРОСОВ";
            // 
            // labelResultPercentage
            // 
            this.labelResultPercentage.AutoSize = true;
            this.labelResultPercentage.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultPercentage.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelResultPercentage.Location = new System.Drawing.Point(31, 251);
            this.labelResultPercentage.Name = "labelResultPercentage";
            this.labelResultPercentage.Size = new System.Drawing.Size(347, 16);
            this.labelResultPercentage.TabIndex = 2;
            this.labelResultPercentage.Text = "РЕЗУЛЬТАТИВНОСТЬ";
            // 
            // chartPie
            // 
            this.chartPie.BackColor = System.Drawing.Color.Black;
            this.chartPie.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 50;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.Chartreuse;
            legend1.Name = "Legend1";
            this.chartPie.Legends.Add(legend1);
            this.chartPie.Location = new System.Drawing.Point(34, 274);
            this.chartPie.Name = "chartPie";
            this.chartPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPie.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Chartreuse,
        System.Drawing.Color.Black};
            series1.BorderColor = System.Drawing.Color.Chartreuse;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPie.Series.Add(series1);
            this.chartPie.Size = new System.Drawing.Size(303, 298);
            this.chartPie.TabIndex = 3;
            this.chartPie.Text = "chartPie";
            // 
            // labelCorrectQuestions
            // 
            this.labelCorrectQuestions.AutoSize = true;
            this.labelCorrectQuestions.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorrectQuestions.ForeColor = System.Drawing.Color.Chartreuse;
            this.labelCorrectQuestions.Location = new System.Drawing.Point(31, 191);
            this.labelCorrectQuestions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.labelCorrectQuestions.Name = "labelCorrectQuestions";
            this.labelCorrectQuestions.Size = new System.Drawing.Size(614, 16);
            this.labelCorrectQuestions.TabIndex = 4;
            this.labelCorrectQuestions.Text = "КОЛИЧЕСТВО ПРАВИЛЬНЫХ ОТВЕТОВ";
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Black;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Floripa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.ForeColor = System.Drawing.Color.Red;
            this.buttonOk.Location = new System.Drawing.Point(528, 442);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(256, 3, 256, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(258, 53);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "ЗАКРЫТЬ";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxRating
            // 
            this.textBoxRating.BackColor = System.Drawing.Color.Black;
            this.textBoxRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRating.ForeColor = System.Drawing.Color.White;
            this.textBoxRating.Location = new System.Drawing.Point(528, 352);
            this.textBoxRating.Margin = new System.Windows.Forms.Padding(188, 3, 188, 3);
            this.textBoxRating.Multiline = true;
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.ReadOnly = true;
            this.textBoxRating.Size = new System.Drawing.Size(258, 53);
            this.textBoxRating.TabIndex = 6;
            this.textBoxRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSendEmail
            // 
            this.buttonSendEmail.BackColor = System.Drawing.Color.Black;
            this.buttonSendEmail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendEmail.Font = new System.Drawing.Font("Floripa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendEmail.ForeColor = System.Drawing.Color.White;
            this.buttonSendEmail.Location = new System.Drawing.Point(528, 442);
            this.buttonSendEmail.Margin = new System.Windows.Forms.Padding(256, 3, 256, 3);
            this.buttonSendEmail.Name = "buttonSendEmail";
            this.buttonSendEmail.Size = new System.Drawing.Size(258, 53);
            this.buttonSendEmail.TabIndex = 8;
            this.buttonSendEmail.Text = "ОТПРАВИТЬ РЕЗУЛЬТАТЫ";
            this.buttonSendEmail.UseVisualStyleBackColor = false;
            this.buttonSendEmail.Click += new System.EventHandler(this.buttonSendEmail_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(832, 590);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSendEmail);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelCorrectQuestions);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.labelResultPercentage);
            this.Controls.Add(this.labelTotalQuestions);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTotalQuestions;
        private System.Windows.Forms.Label labelResultPercentage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.Label labelCorrectQuestions;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Button buttonSendEmail;
    }
}