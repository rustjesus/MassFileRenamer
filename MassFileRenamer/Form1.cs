using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassFileRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void RenameFilesInFolder(string folderPath, string newFileName)
        {
            // Get all the files in the specified folder
            string[] files = Directory.GetFiles(folderPath);

            // Loop through each file
            for (int i = 0; i < files.Length; i++)
            {
                string extension = Path.GetExtension(files[i]);
                string newFilePath = Path.Combine(folderPath, newFileName + "_" + (i + 1) + extension);

                // Rename the file
                File.Move(files[i], newFilePath);
            }
        }

        //*******************INPUTS*********************************************************
        private void changeNamesBtn_Click(object sender, EventArgs e)
        {
            RenameFilesInFolder(filePathTxtBox.Text, newNameTxtBox.Text);
        }

    }
}
