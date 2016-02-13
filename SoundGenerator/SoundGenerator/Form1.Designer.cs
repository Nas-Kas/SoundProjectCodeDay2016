namespace SoundGenerator
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
            this.GenerateWave = new System.Windows.Forms.Button();
            this.PATH = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.HertzSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.HertzValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HertzSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateWave
            // 
            this.GenerateWave.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.GenerateWave.Location = new System.Drawing.Point(51, 175);
            this.GenerateWave.Name = "GenerateWave";
            this.GenerateWave.Size = new System.Drawing.Size(185, 83);
            this.GenerateWave.TabIndex = 0;
            this.GenerateWave.Text = "Generate!";
            this.GenerateWave.UseVisualStyleBackColor = true;
            this.GenerateWave.Click += new System.EventHandler(this.button1_Click);
            // 
            // PATH
            // 
            this.PATH.Location = new System.Drawing.Point(42, 50);
            this.PATH.Name = "PATH";
            this.PATH.Size = new System.Drawing.Size(204, 20);
            this.PATH.TabIndex = 3;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.PathLabel.Location = new System.Drawing.Point(35, 9);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(82, 38);
            this.PathLabel.TabIndex = 4;
            this.PathLabel.Text = "Path:";
            this.PathLabel.Click += new System.EventHandler(this.PathLabel_Click);
            // 
            // HertzSlider
            // 
            this.HertzSlider.Location = new System.Drawing.Point(42, 124);
            this.HertzSlider.Maximum = 5000;
            this.HertzSlider.Minimum = 20;
            this.HertzSlider.Name = "HertzSlider";
            this.HertzSlider.Size = new System.Drawing.Size(204, 45);
            this.HertzSlider.TabIndex = 5;
            this.HertzSlider.Value = 20;
            this.HertzSlider.Scroll += new System.EventHandler(this.HertzSlider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.label1.Location = new System.Drawing.Point(183, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hz";
            // 
            // HertzValue
            // 
            this.HertzValue.AutoSize = true;
            this.HertzValue.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.HertzValue.Location = new System.Drawing.Point(106, 83);
            this.HertzValue.Name = "HertzValue";
            this.HertzValue.Size = new System.Drawing.Size(50, 38);
            this.HertzValue.TabIndex = 7;
            this.HertzValue.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.HertzValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HertzSlider);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PATH);
            this.Controls.Add(this.GenerateWave);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HertzSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateWave;
        private System.Windows.Forms.TextBox PATH;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TrackBar HertzSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HertzValue;
    }
}

