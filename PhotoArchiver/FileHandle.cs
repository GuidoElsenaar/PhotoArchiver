using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoArchiver
{
    class FileHandle
    {
        private string folderSource;

        public FileHandle(string text)
        {
            this.folderSource = text;

            string[] filelist = Directory.GetFiles(folderSource);
            Form1.l = filelist[0];
        }

        
    }
    

    {
        string folderSelect = richTextBoxFolderselectie.Text;
        string[] filelist = Directory.GetFiles(folderSelect);
        labelOutput.Text = filelist[0];
    }
}
