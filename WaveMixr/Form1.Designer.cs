namespace WaveMixr
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
            this.Start = new System.Windows.Forms.Button();
            this.HertzLabel = new System.Windows.Forms.Label();
            this.OctaveNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(127, 542);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(104, 38);
            this.Start.TabIndex = 0;
            this.Start.Text = "Go";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // HertzLabel
            // 
            this.HertzLabel.AutoSize = true;
            this.HertzLabel.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.HertzLabel.Location = new System.Drawing.Point(102, 9);
            this.HertzLabel.Name = "HertzLabel";
            this.HertzLabel.Size = new System.Drawing.Size(187, 60);
            this.HertzLabel.TabIndex = 7;
            this.HertzLabel.Text = "---------";
            this.HertzLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HertzLabel.Click += new System.EventHandler(this.HertzLabel_Click);
            // 
            // OctaveNumber
            // 
            this.OctaveNumber.AutoSize = true;
            this.OctaveNumber.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.OctaveNumber.Location = new System.Drawing.Point(246, 69);
            this.OctaveNumber.Name = "OctaveNumber";
            this.OctaveNumber.Size = new System.Drawing.Size(43, 60);
            this.OctaveNumber.TabIndex = 8;
            this.OctaveNumber.Text = "-";
            this.OctaveNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label2.Location = new System.Drawing.Point(59, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 60);
            this.label2.TabIndex = 9;
            this.label2.Text = "Octave:";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Comic Sans MS", 80F);
            this.NoteLabel.Location = new System.Drawing.Point(91, 144);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(198, 150);
            this.NoteLabel.TabIndex = 10;
            this.NoteLabel.Text = "-#";
            this.NoteLabel.Click += new System.EventHandler(this.NoteLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 592);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OctaveNumber);
            this.Controls.Add(this.HertzLabel);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label HertzLabel;
        private System.Windows.Forms.Label OctaveNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NoteLabel;
    }
}

