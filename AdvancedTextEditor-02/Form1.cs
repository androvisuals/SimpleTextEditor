using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//allows VS to read and write files, IN OUT

//TODO
// add a save function, save over text file that was last loaded.

namespace AdvancedTextEditor_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();//clears rich text box on 1st time load
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();//create opne file dialog
            openFile.Title = "Open a file.";
            if (openFile.ShowDialog() == DialogResult.OK)//checks if dialog load was ok
            {
                richTextBox1.Clear();//clears the textbox
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();//makes us read it to the richTextBox1 Object
                    sr.Close();//release system resources associated with the StreamReaderObject
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file as..";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter textOutput = new StreamWriter(saveFile.FileName);
                textOutput.Write(richTextBox1.Text);
                textOutput.Close();
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {


            /*
            if(toolStripMenuItem2.CheckOnClick == true)
            {
                richTextBox1.Font = new System.Drawing.Font(richTextBox1.Font.Name, 8F);
            }
            */
        }
       
        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();//redirect this function to click the already existing new button (clears)
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();//redirect this function to perform a click on the open menu button.

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoButton.PerformClick();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoButton.PerformClick();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectAllButton.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "a boo boo";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new System.Drawing.Font(richTextBox1.Font.Name, 8F);
        }

        
        
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           richTextBox1.Font = new System.Drawing.Font(richTextBox1.Font.Name, 10F);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new System.Drawing.Font(richTextBox1.Font.Name, 12F);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new System.Drawing.Font(richTextBox1.Font.Name, 14F);
        }
    }
}
