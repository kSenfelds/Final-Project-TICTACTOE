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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public const string _pathname = @"D:\RCSprojects\cSharpSchool\frameworktest\WindowsFormsApptest1\WindowsFormsApptest1\";
        public static List<string> savedFiles = new List<string>();
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(_pathname + textBox1.Text + ".txt");
                for (int i = 0; i<MainForm.winList.Count; i++)
                {
                    sw.WriteLine(MainForm.winList[i]);
                }
                sw.Close();
                savedFiles.Add(textBox1.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Failed to write file");
            }
        }
    }
}
