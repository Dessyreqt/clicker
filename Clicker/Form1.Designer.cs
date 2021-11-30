namespace Clicker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.threadSleepTime = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.rightClick = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.threadSleepTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thread Sleep Time";
            // 
            // threadSleepTime
            // 
            this.threadSleepTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.threadSleepTime.Location = new System.Drawing.Point(15, 25);
            this.threadSleepTime.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.threadSleepTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.threadSleepTime.Name = "threadSleepTime";
            this.threadSleepTime.Size = new System.Drawing.Size(120, 20);
            this.threadSleepTime.TabIndex = 1;
            this.threadSleepTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 51);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(12, 80);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 3;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // rightClick
            // 
            this.rightClick.AutoSize = true;
            this.rightClick.Location = new System.Drawing.Point(15, 109);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(76, 17);
            this.rightClick.TabIndex = 4;
            this.rightClick.Text = "Right click";
            this.rightClick.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 142);
            this.Controls.Add(this.rightClick);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.threadSleepTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Clicker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.threadSleepTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown threadSleepTime;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.CheckBox rightClick;
    }
}

