using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChangeWalpaper
{
    
    public partial class Form1 : Form
    {
       

        private string _filePath;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
       
        private bool IsImageFile(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            var allowedExtensions = new HashSet<string>
            {
                ".jpg",
                ".jpeg",
                ".png"
            };

            if (!allowedExtensions.Contains(ext))
            {
                //   MessageBox.Show(ext + " is not a valid image file. Please select a JPG or PNG file.", "Warning",
                // MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (var img = Image.FromStream(fs))
                    {
                        return true;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnShowFileDialog_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog1.FileName;
                textBox1.Text = _filePath;
            }

            if (!IsImageFile(_filePath))
            {
                MessageBox.Show("Please select a valid image file (JPG or PNG).", "Invalid File",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                return;
            }

            Form confirmForm = new ConfirmForm(_filePath);
            confirmForm.ShowDialog();
        }
    }
}
