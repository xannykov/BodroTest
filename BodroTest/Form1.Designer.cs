namespace BodroTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTestStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.NameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonReady = new System.Windows.Forms.Button();
            this.DuraksButton = new System.Windows.Forms.Button();
            this.CloseButtonX = new System.Windows.Forms.Button();
            this.StopBox = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            this.LightBox = new System.Windows.Forms.PictureBox();
            this.component11 = new BodroTest.Component1(this.components);
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.BackColor = System.Drawing.Color.Black;
            this.buttonNextQuestion.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextQuestion.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonNextQuestion.Location = new System.Drawing.Point(358, 550);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(404, 64);
            this.buttonNextQuestion.TabIndex = 1;
            this.buttonNextQuestion.Text = "СЛЕДУЮЩИЙ ВОПРОС";
            this.buttonNextQuestion.UseVisualStyleBackColor = false;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // tableLayoutPanelAnswers
            // 
            this.tableLayoutPanelAnswers.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelAnswers.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelAnswers.ColumnCount = 1;
            this.tableLayoutPanelAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanelAnswers.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanelAnswers.Location = new System.Drawing.Point(22, 154);
            this.tableLayoutPanelAnswers.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.tableLayoutPanelAnswers.Name = "tableLayoutPanelAnswers";
            this.tableLayoutPanelAnswers.RowCount = 4;
            this.tableLayoutPanelAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAnswers.Size = new System.Drawing.Size(740, 346);
            this.tableLayoutPanelAnswers.TabIndex = 9;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Black;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTestStatus,
            this.toolStripStatusLabelCount,
            this.toolStripStatusLabelElapsedTime,
            this.NameStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 636);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(786, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTestStatus
            // 
            this.toolStripStatusLabelTestStatus.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelTestStatus.ForeColor = System.Drawing.Color.Chartreuse;
            this.toolStripStatusLabelTestStatus.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.toolStripStatusLabelTestStatus.Name = "toolStripStatusLabelTestStatus";
            this.toolStripStatusLabelTestStatus.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabelTestStatus.Text = "Тест идёт";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelCount.ForeColor = System.Drawing.Color.Chartreuse;
            this.toolStripStatusLabelCount.Margin = new System.Windows.Forms.Padding(20, 3, 20, 2);
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabelCount.Text = "0/...";
            // 
            // toolStripStatusLabelElapsedTime
            // 
            this.toolStripStatusLabelElapsedTime.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelElapsedTime.ForeColor = System.Drawing.Color.Chartreuse;
            this.toolStripStatusLabelElapsedTime.Margin = new System.Windows.Forms.Padding(20, 3, 20, 2);
            this.toolStripStatusLabelElapsedTime.Name = "toolStripStatusLabelElapsedTime";
            this.toolStripStatusLabelElapsedTime.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabelElapsedTime.Text = "00:00";
            // 
            // NameStatusLabel
            // 
            this.NameStatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameStatusLabel.Name = "NameStatusLabel";
            this.NameStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.Color.Black;
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestion.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBoxQuestion.Location = new System.Drawing.Point(22, 58);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestion.Size = new System.Drawing.Size(740, 80);
            this.textBoxQuestion.TabIndex = 12;
            // 
            // buttonReady
            // 
            this.buttonReady.BackColor = System.Drawing.Color.Black;
            this.buttonReady.Font = new System.Drawing.Font("Floripa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReady.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonReady.Location = new System.Drawing.Point(358, 550);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(404, 64);
            this.buttonReady.TabIndex = 13;
            this.buttonReady.Text = "ОТПРАВИТЬ ОТВЕТ";
            this.buttonReady.UseVisualStyleBackColor = false;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // DuraksButton
            // 
            this.DuraksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DuraksButton.BackColor = System.Drawing.Color.Black;
            this.DuraksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DuraksButton.Font = new System.Drawing.Font("Floripa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DuraksButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.DuraksButton.Location = new System.Drawing.Point(696, 12);
            this.DuraksButton.Name = "DuraksButton";
            this.DuraksButton.Size = new System.Drawing.Size(30, 30);
            this.DuraksButton.TabIndex = 19;
            this.DuraksButton.Text = "?";
            this.DuraksButton.UseVisualStyleBackColor = false;
            this.DuraksButton.Click += new System.EventHandler(this.DuraksButton_Click);
            // 
            // CloseButtonX
            // 
            this.CloseButtonX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonX.BackColor = System.Drawing.Color.Black;
            this.CloseButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButtonX.Font = new System.Drawing.Font("Floripa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButtonX.ForeColor = System.Drawing.Color.Chartreuse;
            this.CloseButtonX.Location = new System.Drawing.Point(744, 12);
            this.CloseButtonX.Name = "CloseButtonX";
            this.CloseButtonX.Size = new System.Drawing.Size(30, 30);
            this.CloseButtonX.TabIndex = 18;
            this.CloseButtonX.Text = "X";
            this.CloseButtonX.UseVisualStyleBackColor = false;
            this.CloseButtonX.Click += new System.EventHandler(this.CloseButtonX_Click);
            // 
            // StopBox
            // 
            this.StopBox.BackColor = System.Drawing.Color.Transparent;
            this.StopBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StopBox.Image = global::BodroTest.Properties.Resources.Stop;
            this.StopBox.Location = new System.Drawing.Point(188, 550);
            this.StopBox.Name = "StopBox";
            this.StopBox.Size = new System.Drawing.Size(64, 64);
            this.StopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StopBox.TabIndex = 22;
            this.StopBox.TabStop = false;
            this.StopBox.Visible = false;
            this.StopBox.Click += new System.EventHandler(this.StopBox_Click);
            // 
            // PlayerBox
            // 
            this.PlayerBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBox.Image = global::BodroTest.Properties.Resources.Play;
            this.PlayerBox.Location = new System.Drawing.Point(188, 550);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(64, 64);
            this.PlayerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerBox.TabIndex = 21;
            this.PlayerBox.TabStop = false;
            this.PlayerBox.Visible = false;
            this.PlayerBox.Click += new System.EventHandler(this.PlayerBox_Click);
            // 
            // LightBox
            // 
            this.LightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LightBox.Location = new System.Drawing.Point(22, 550);
            this.LightBox.Name = "LightBox";
            this.LightBox.Size = new System.Drawing.Size(64, 64);
            this.LightBox.TabIndex = 20;
            this.LightBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(786, 658);
            this.ControlBox = false;
            this.Controls.Add(this.StopBox);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.LightBox);
            this.Controls.Add(this.DuraksButton);
            this.Controls.Add(this.CloseButtonX);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tableLayoutPanelAnswers);
            this.Controls.Add(this.buttonNextQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAnswers;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTestStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelElapsedTime;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonReady;
        //private System.Windows.Forms.PictureBox pictureBoxQuestion;
        private System.Windows.Forms.Button DuraksButton;
        private System.Windows.Forms.Button CloseButtonX;
        private System.Windows.Forms.ToolStripStatusLabel NameStatusLabel;
        private System.Windows.Forms.PictureBox LightBox;
        private Component1 component11;
        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.PictureBox StopBox;
    }
}

