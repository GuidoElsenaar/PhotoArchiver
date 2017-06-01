using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoArchiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelFolderselectie.Text = Constants.TextBoxes.labelFolderselectie;
            richTextBoxFolderselectie.Text = Constants.TextBoxes.richTextBoxFolderselectie;
            buttonImportPhotos.Text = Constants.TextBoxes.buttonImportPhotos;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonFolderselectie_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = richTextBoxFolderselectie.Text;
                DialogResult result = fbd.ShowDialog();
                if(result == DialogResult.OK)
                {
                    richTextBoxFolderselectie.Text = fbd.SelectedPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonImportPhotos_Click(object sender, EventArgs e)
        {
            var fh = new FileHandle(richTextBoxFolderselectie.Text);
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
