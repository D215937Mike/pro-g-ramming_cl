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

namespace FileChanger
{
    public partial class TextAdder : Form
    {
        public string filePath;
        public TextAdder()
        {
            InitializeComponent();
            buttonsControl(true);
        }

        private void buttonsControl(bool state)
        {
            if (state)
            {
                executerButton.Enabled = false;
                capsCB.Enabled = false;
                lowerCB.Enabled = false;
                numberCB.Enabled = false;
                TextEditor.Enabled = false;
            }
            if (!state)
            {
                executerButton.Enabled = true;
                capsCB.Enabled = true;
                lowerCB.Enabled = true;
                numberCB.Enabled = true;
                TextEditor.Enabled = true;
            }
        }

        private void fileLoaderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                buttonsControl(false);
                filePath = openFile.FileName;
                documentLabel.Text = "File Loaded : \n" + Path.GetFileName(filePath);
                informationLabel.Text = "File Information :\nFile Name : " + Path.GetFileNameWithoutExtension(filePath) + ", Extention : " + Path.GetExtension(filePath) + "\nRows Count : " + File.ReadAllLines(filePath).Length + ", Last Modified : " + File.GetLastWriteTime(filePath);
            }
        }

        private void executerButton_Click(object sender, EventArgs e)
        {
            string[] readText = File.ReadAllLines(openFile.FileName); string fileName = Path.GetFileName(openFile.FileName);
            for (int index = 0; index < readText.Length; index++)
            {
                if (numberCB.CheckState == CheckState.Checked)
                {
                    index = 0;
                    readText[index] = index.ToString() + ". " + readText[index];
                }
                if (capsCB.CheckState == CheckState.Checked)
                {
                    index = 0;
                    readText[index] = readText[index].ToUpper();
                }
                if (lowerCB.CheckState == CheckState.Checked)
                {
                    index = 0;
                    readText[index] = readText[index].ToLower();
                }
                else
                {
                    readText[index] = firstInsertBox.Text + readText[index] + endInsertBox.Text;
                }
            }
            string[] newFileName = fileName.Split('.');
            string directoryFolder = @"C:\Users\" + Environment.UserName.ToString() + @"\Desktop\"; string pathCombine = System.IO.Path.Combine(directoryFolder, fileName);
            System.IO.File.WriteAllLines(directoryFolder + @"\" + newFileName[0].ToString() + "_edit" + ".txt", readText);
            if (System.IO.File.Exists(directoryFolder + @"\" + newFileName[0].ToString() + "_edit" + ".txt"))
            {
                MessageBox.Show("All the lines have been processed.\nThank you for your time.", "List: Information");
            }
        }

        private void capsCB_CheckedChanged(object sender, EventArgs e)
        {
            lowerCB.CheckState = CheckState.Unchecked;
        }

        private void lowerCB_CheckedChanged(object sender, EventArgs e)
        {
            capsCB.CheckState = CheckState.Unchecked;
        }
    }
}
