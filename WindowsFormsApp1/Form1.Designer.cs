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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.taskBox = new System.Windows.Forms.ComboBox();
            this.tbPortalDirection = new System.Windows.Forms.TrackBar();
            this.lbPortalDirection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPortalDirection)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(776, 354);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(24, 382);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(207, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(180, 382);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(8, 45);
            this.trackBar2.TabIndex = 2;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(238, 391);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 13);
            this.lblDirection.TabIndex = 3;
            // 
            // taskBox
            // 
            this.taskBox.FormattingEnabled = true;
            this.taskBox.Items.AddRange(new object[] {
            "Счётчик",
            "Порталы"});
            this.taskBox.Location = new System.Drawing.Point(551, 391);
            this.taskBox.Name = "taskBox";
            this.taskBox.Size = new System.Drawing.Size(153, 21);
            this.taskBox.TabIndex = 6;
            this.taskBox.Text = "Счётчик";
            // 
            // tbPortalDirection
            // 
            this.tbPortalDirection.Location = new System.Drawing.Point(273, 382);
            this.tbPortalDirection.Maximum = 359;
            this.tbPortalDirection.Name = "tbPortalDirection";
            this.tbPortalDirection.Size = new System.Drawing.Size(157, 45);
            this.tbPortalDirection.TabIndex = 2;
            this.tbPortalDirection.Scroll += new System.EventHandler(this.tbPortalDirection_Scroll);
            // 
            // lbPortalDirection
            // 
            this.lbPortalDirection.AutoSize = true;
            this.lbPortalDirection.Location = new System.Drawing.Point(428, 390);
            this.lbPortalDirection.Name = "lbPortalDirection";
            this.lbPortalDirection.Size = new System.Drawing.Size(13, 13);
            this.lbPortalDirection.TabIndex = 8;
            this.lbPortalDirection.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPortalDirection);
            this.Controls.Add(this.tbPortalDirection);
            this.Controls.Add(this.taskBox);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPortalDirection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.ComboBox taskBox;
        private System.Windows.Forms.TrackBar tbPortalDirection;
        private System.Windows.Forms.Label lbPortalDirection;
    }
}

