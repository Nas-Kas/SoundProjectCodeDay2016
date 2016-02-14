namespace SoundReader
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
            this.TextTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextTest
            // 
            this.TextTest.AutoSize = true;
            this.TextTest.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.TextTest.Location = new System.Drawing.Point(55, 9);
            this.TextTest.Name = "TextTest";
            this.TextTest.Size = new System.Drawing.Size(187, 60);
            this.TextTest.TabIndex = 0;
            this.TextTest.Text = "---------";
            this.TextTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextTest.Click += new System.EventHandler(this.TextTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label1.Location = new System.Drawing.Point(199, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Octave:";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Comic Sans MS", 80F);
            this.NoteLabel.Location = new System.Drawing.Point(44, 144);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(198, 150);
            this.NoteLabel.TabIndex = 3;
            this.NoteLabel.Text = "-#";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(85, 297);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(179, 20);
            this.FilePath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.label3.Location = new System.Drawing.Point(21, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoButton
            // 
            this.DoButton.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.DoButton.Location = new System.Drawing.Point(41, 350);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(201, 64);
            this.DoButton.TabIndex = 6;
            this.DoButton.Text = "Read File!";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 426);
            this.Controls.Add(this.DoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DoButton;
    }
}

