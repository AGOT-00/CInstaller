namespace CPPFormApp
{
    partial class App
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
            this.DownloadBar = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Label();
            this.DSpeed = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DownloadBar
            // 
            this.DownloadBar.Location = new System.Drawing.Point(41, 12);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Size = new System.Drawing.Size(537, 23);
            this.DownloadBar.TabIndex = 2;
            this.DownloadBar.Click += new System.EventHandler(this.DownloadBar_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(39, 63);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(46, 13);
            this.Status.TabIndex = 3;
            this.Status.Text = "Status : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speed :";
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Location = new System.Drawing.Point(91, 63);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(73, 13);
            this.Down.TabIndex = 5;
            this.Down.Text = "Downloaded :";
            // 
            // DSpeed
            // 
            this.DSpeed.AutoSize = true;
            this.DSpeed.Location = new System.Drawing.Point(91, 38);
            this.DSpeed.Name = "DSpeed";
            this.DSpeed.Size = new System.Drawing.Size(45, 13);
            this.DSpeed.TabIndex = 6;
            this.DSpeed.Text = "MB/sec";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(503, 41);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 100);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.DSpeed);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.DownloadBar);
            this.Name = "App";
            this.Text = "C++ Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar DownloadBar;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label DSpeed;
        private System.Windows.Forms.Button Start;
    }
}

