using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public static Label label1_1;
        public Form1()
        {
            InitializeComponent();
            label1_1 = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1_1.Text = "hola mundo";
            label1_1.BackColor = Color.HotPink;
            label1_1.ForeColor = Color.Pink;
            label1_1.Size = new Size(100, 20);
            Form2 a = new Form2();
            Form1 b = new Form1();
            //a.Show();
            a.ShowDialog();
            
        }
    }
}
