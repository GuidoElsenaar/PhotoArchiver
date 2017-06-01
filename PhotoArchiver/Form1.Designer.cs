namespace PhotoArchiver
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
            this.richTextBoxFolderselectie = new System.Windows.Forms.RichTextBox();
            this.buttonFolderselectie = new System.Windows.Forms.Button();
            this.labelFolderselectie = new System.Windows.Forms.Label();
            this.buttonImportPhotos = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxFolderselectie
            // 
            this.richTextBoxFolderselectie.Location = new System.Drawing.Point(12, 25);
            this.richTextBoxFolderselectie.Multiline = false;
            this.richTextBoxFolderselectie.Name = "richTextBoxFolderselectie";
            this.richTextBoxFolderselectie.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxFolderselectie.Size = new System.Drawing.Size(233, 21);
            this.richTextBoxFolderselectie.TabIndex = 0;
            this.richTextBoxFolderselectie.Tag = "";
            this.richTextBoxFolderselectie.Text = "richTextBoxFolderselectie";
            this.richTextBoxFolderselectie.WordWrap = false;
            this.richTextBoxFolderselectie.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonFolderselectie
            // 
            this.buttonFolderselectie.Location = new System.Drawing.Point(252, 22);
            this.buttonFolderselectie.Name = "buttonFolderselectie";
            this.buttonFolderselectie.Size = new System.Drawing.Size(27, 24);
            this.buttonFolderselectie.TabIndex = 1;
            this.buttonFolderselectie.Text = "...";
            this.buttonFolderselectie.UseVisualStyleBackColor = true;
            this.buttonFolderselectie.Click += new System.EventHandler(this.buttonFolderselectie_Click);
            // 
            // labelFolderselectie
            // 
            this.labelFolderselectie.AutoSize = true;
            this.labelFolderselectie.Location = new System.Drawing.Point(12, 9);
            this.labelFolderselectie.Name = "labelFolderselectie";
            this.labelFolderselectie.Size = new System.Drawing.Size(94, 13);
            this.labelFolderselectie.TabIndex = 2;
            this.labelFolderselectie.Text = "labelFolderselectie";
            // 
            // buttonImportPhotos
            // 
            this.buttonImportPhotos.Location = new System.Drawing.Point(13, 53);
            this.buttonImportPhotos.Name = "buttonImportPhotos";
            this.buttonImportPhotos.Size = new System.Drawing.Size(75, 23);
            this.buttonImportPhotos.TabIndex = 3;
            this.buttonImportPhotos.Text = "buttonImportPhotos";
            this.buttonImportPhotos.UseVisualStyleBackColor = true;
            this.buttonImportPhotos.Click += new System.EventHandler(this.buttonImportPhotos_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(15, 103);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(61, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "labelOutput";
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 261);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonImportPhotos);
            this.Controls.Add(this.labelFolderselectie);
            this.Controls.Add(this.buttonFolderselectie);
            this.Controls.Add(this.richTextBoxFolderselectie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxFolderselectie;
        private System.Windows.Forms.Button buttonFolderselectie;
        private System.Windows.Forms.Label labelFolderselectie;
        private System.Windows.Forms.Button buttonImportPhotos;
        private System.Windows.Forms.Label labelOutput;
    }
}

