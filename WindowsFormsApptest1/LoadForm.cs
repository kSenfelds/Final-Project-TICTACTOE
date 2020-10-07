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

namespace WindowsFormsApptest1
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SaveForm.savedFiles.Count; i++)
            {
                chooseFile.Items.Add(SaveForm.savedFiles[i]);
            }
        }

        private void chooseFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(SaveForm._pathname +Convert.ToString(chooseFile.SelectedItem)+ ".txt");
                string line = sr.ReadLine();
                while (line != null)
                {
                    list1.Items.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Failed to read file");
            }
        }
    }
}
