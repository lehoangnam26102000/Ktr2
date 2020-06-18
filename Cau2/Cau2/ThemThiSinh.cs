using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau2
{
    public partial class ThemThiSinh : Form
    {
        Form1 f1 = new Form1();
        public ThemThiSinh()
        {
            InitializeComponent();
        }
        public ThemThiSinh(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var Del = MessageBox.Show("Bạn muốn thoát khỏi chương trình không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Del == DialogResult.Yes)
            {
                this.Close();
                f1.Show();
            }
        }
    }
}
