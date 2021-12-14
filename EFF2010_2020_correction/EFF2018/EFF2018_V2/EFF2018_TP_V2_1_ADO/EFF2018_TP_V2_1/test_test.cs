using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFF2018_TP_V2_1
{
    public partial class test_test : Form
    {
        public test_test()
        {
            InitializeComponent();
        }

        private void test_test_Load(object sender, EventArgs e)
        {
            //using (StreamWriter writer = new StreamWriter(filename))
            //{
            //    writer.Write("This is created by Animesh Datta.....");
            //}


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\myfile.txt";
            MessageBox.Show(filepath);
        }
    }
}
