using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baicuoi
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            var DR = MessageBox.Show("ban muon thoat chuong trinh ?", "thoat", MessageBoxButtons.YesNo);
            if(DR==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                double d, x, x1, x2;
                d = b * b - 4 * a * c;
                if(d<0)
                {
                    richTextBox1.Text = ("phuong trinh vo nghiem");
                }
                if(d==0)
                {
                    x = -b / (2 * a);
                    richTextBox1.Text = ("phuong trinh co nghiem x" + x);
                }
                if(d>0)
                {
                    x1 = (-b - (double)Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + (double)Math.Sqrt(d)) / (2 * a);
                    richTextBox1.Text = ("phuong trinh co 2 nghiem \n" + "nghiem x1=" + x1 + "\nnghiem x2=" + x2);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("phai nhap so", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
