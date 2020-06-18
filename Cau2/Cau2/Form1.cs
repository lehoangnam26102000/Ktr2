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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var Del = MessageBox.Show("Bạn muốn thoát khỏi chương trình không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Del == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemThiSinh TS = new ThemThiSinh();
            TS.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danhSachDataSet1.SieuCupTable' table. You can move, or remove it, as needed.
            this.sieuCupTableTableAdapter.Fill(this.danhSachDataSet1.SieuCupTable);
            // TODO: This line of code loads data into the 'danhSachDataSet.ChuyenTable' table. You can move, or remove it, as needed.
            this.chuyenTableTableAdapter.Fill(this.danhSachDataSet.ChuyenTable);

        }
    }
}
