namespace Cau2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.danhSachDataSet = new Cau2.DanhSachDataSet();
            this.chuyenTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chuyenTableTableAdapter = new Cau2.DanhSachDataSetTableAdapters.ChuyenTableTableAdapter();
            this.danhSachDataSet1 = new Cau2.DanhSachDataSet1();
            this.sieuCupTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sieuCupTableTableAdapter = new Cau2.DanhSachDataSet1TableAdapters.SieuCupTableTableAdapter();
            this.sốBáoDanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.họTênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmBài1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmBài2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmBài3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiếngAnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngĐiểmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốBáoDanhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.họTênDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmThi1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmThi2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmThi3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cơSởDữLiệuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngĐiểmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sieuCupTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách thí sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách thí sinh Chuyên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách thí sinh Siêu cúp:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sốBáoDanhDataGridViewTextBoxColumn,
            this.họTênDataGridViewTextBoxColumn,
            this.điểmBài1DataGridViewTextBoxColumn,
            this.điểmBài2DataGridViewTextBoxColumn,
            this.điểmBài3DataGridViewTextBoxColumn,
            this.tiếngAnhDataGridViewTextBoxColumn,
            this.tổngĐiểmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chuyenTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 142);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sốBáoDanhDataGridViewTextBoxColumn1,
            this.họTênDataGridViewTextBoxColumn1,
            this.điểmThi1DataGridViewTextBoxColumn,
            this.điểmThi2DataGridViewTextBoxColumn,
            this.điểmThi3DataGridViewTextBoxColumn,
            this.cơSởDữLiệuDataGridViewTextBoxColumn,
            this.tổngĐiểmDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.sieuCupTableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(19, 247);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(599, 130);
            this.dataGridView2.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(133, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 22);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(240, 390);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(75, 23);
            this.btnRepair.TabIndex = 7;
            this.btnRepair.Text = "Cập nhật";
            this.btnRepair.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(543, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // danhSachDataSet
            // 
            this.danhSachDataSet.DataSetName = "DanhSachDataSet";
            this.danhSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chuyenTableBindingSource
            // 
            this.chuyenTableBindingSource.DataMember = "ChuyenTable";
            this.chuyenTableBindingSource.DataSource = this.danhSachDataSet;
            // 
            // chuyenTableTableAdapter
            // 
            this.chuyenTableTableAdapter.ClearBeforeFill = true;
            // 
            // danhSachDataSet1
            // 
            this.danhSachDataSet1.DataSetName = "DanhSachDataSet1";
            this.danhSachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sieuCupTableBindingSource
            // 
            this.sieuCupTableBindingSource.DataMember = "SieuCupTable";
            this.sieuCupTableBindingSource.DataSource = this.danhSachDataSet1;
            // 
            // sieuCupTableTableAdapter
            // 
            this.sieuCupTableTableAdapter.ClearBeforeFill = true;
            // 
            // sốBáoDanhDataGridViewTextBoxColumn
            // 
            this.sốBáoDanhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sốBáoDanhDataGridViewTextBoxColumn.DataPropertyName = "Số báo danh";
            this.sốBáoDanhDataGridViewTextBoxColumn.HeaderText = "Số báo danh";
            this.sốBáoDanhDataGridViewTextBoxColumn.Name = "sốBáoDanhDataGridViewTextBoxColumn";
            this.sốBáoDanhDataGridViewTextBoxColumn.Width = 93;
            // 
            // họTênDataGridViewTextBoxColumn
            // 
            this.họTênDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.họTênDataGridViewTextBoxColumn.DataPropertyName = "Họ tên";
            this.họTênDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.họTênDataGridViewTextBoxColumn.Name = "họTênDataGridViewTextBoxColumn";
            this.họTênDataGridViewTextBoxColumn.Width = 64;
            // 
            // điểmBài1DataGridViewTextBoxColumn
            // 
            this.điểmBài1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.điểmBài1DataGridViewTextBoxColumn.DataPropertyName = "Điểm bài 1";
            this.điểmBài1DataGridViewTextBoxColumn.HeaderText = "Điểm bài 1";
            this.điểmBài1DataGridViewTextBoxColumn.Name = "điểmBài1DataGridViewTextBoxColumn";
            this.điểmBài1DataGridViewTextBoxColumn.Width = 82;
            // 
            // điểmBài2DataGridViewTextBoxColumn
            // 
            this.điểmBài2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.điểmBài2DataGridViewTextBoxColumn.DataPropertyName = "Điểm bài 2";
            this.điểmBài2DataGridViewTextBoxColumn.HeaderText = "Điểm bài 2";
            this.điểmBài2DataGridViewTextBoxColumn.Name = "điểmBài2DataGridViewTextBoxColumn";
            this.điểmBài2DataGridViewTextBoxColumn.Width = 82;
            // 
            // điểmBài3DataGridViewTextBoxColumn
            // 
            this.điểmBài3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.điểmBài3DataGridViewTextBoxColumn.DataPropertyName = "Điểm bài 3";
            this.điểmBài3DataGridViewTextBoxColumn.HeaderText = "Điểm bài 3";
            this.điểmBài3DataGridViewTextBoxColumn.Name = "điểmBài3DataGridViewTextBoxColumn";
            this.điểmBài3DataGridViewTextBoxColumn.Width = 82;
            // 
            // tiếngAnhDataGridViewTextBoxColumn
            // 
            this.tiếngAnhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tiếngAnhDataGridViewTextBoxColumn.DataPropertyName = "Tiếng Anh";
            this.tiếngAnhDataGridViewTextBoxColumn.HeaderText = "Tiếng Anh";
            this.tiếngAnhDataGridViewTextBoxColumn.Name = "tiếngAnhDataGridViewTextBoxColumn";
            this.tiếngAnhDataGridViewTextBoxColumn.Width = 81;
            // 
            // tổngĐiểmDataGridViewTextBoxColumn
            // 
            this.tổngĐiểmDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tổngĐiểmDataGridViewTextBoxColumn.DataPropertyName = "Tổng điểm";
            this.tổngĐiểmDataGridViewTextBoxColumn.HeaderText = "Tổng điểm";
            this.tổngĐiểmDataGridViewTextBoxColumn.Name = "tổngĐiểmDataGridViewTextBoxColumn";
            // 
            // sốBáoDanhDataGridViewTextBoxColumn1
            // 
            this.sốBáoDanhDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sốBáoDanhDataGridViewTextBoxColumn1.DataPropertyName = "Số báo danh";
            this.sốBáoDanhDataGridViewTextBoxColumn1.HeaderText = "Số báo danh";
            this.sốBáoDanhDataGridViewTextBoxColumn1.Name = "sốBáoDanhDataGridViewTextBoxColumn1";
            this.sốBáoDanhDataGridViewTextBoxColumn1.Width = 93;
            // 
            // họTênDataGridViewTextBoxColumn1
            // 
            this.họTênDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.họTênDataGridViewTextBoxColumn1.DataPropertyName = "Họ tên";
            this.họTênDataGridViewTextBoxColumn1.HeaderText = "Họ tên";
            this.họTênDataGridViewTextBoxColumn1.Name = "họTênDataGridViewTextBoxColumn1";
            this.họTênDataGridViewTextBoxColumn1.Width = 64;
            // 
            // điểmThi1DataGridViewTextBoxColumn
            // 
            this.điểmThi1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.điểmThi1DataGridViewTextBoxColumn.DataPropertyName = "Điểm thi 1";
            this.điểmThi1DataGridViewTextBoxColumn.HeaderText = "Điểm thi 1";
            this.điểmThi1DataGridViewTextBoxColumn.Name = "điểmThi1DataGridViewTextBoxColumn";
            this.điểmThi1DataGridViewTextBoxColumn.Width = 79;
            // 
            // điểmThi2DataGridViewTextBoxColumn
            // 
            this.điểmThi2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.điểmThi2DataGridViewTextBoxColumn.DataPropertyName = "Điểm thi 2";
            this.điểmThi2DataGridViewTextBoxColumn.HeaderText = "Điểm thi 2";
            this.điểmThi2DataGridViewTextBoxColumn.Name = "điểmThi2DataGridViewTextBoxColumn";
            this.điểmThi2DataGridViewTextBoxColumn.Width = 79;
            // 
            // điểmThi3DataGridViewTextBoxColumn
            // 
            this.điểmThi3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.điểmThi3DataGridViewTextBoxColumn.DataPropertyName = "Điểm thi 3";
            this.điểmThi3DataGridViewTextBoxColumn.HeaderText = "Điểm thi 3";
            this.điểmThi3DataGridViewTextBoxColumn.Name = "điểmThi3DataGridViewTextBoxColumn";
            this.điểmThi3DataGridViewTextBoxColumn.Width = 79;
            // 
            // cơSởDữLiệuDataGridViewTextBoxColumn
            // 
            this.cơSởDữLiệuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cơSởDữLiệuDataGridViewTextBoxColumn.DataPropertyName = "Cơ sở dữ liệu";
            this.cơSởDữLiệuDataGridViewTextBoxColumn.HeaderText = "Cơ sở dữ liệu";
            this.cơSởDữLiệuDataGridViewTextBoxColumn.Name = "cơSởDữLiệuDataGridViewTextBoxColumn";
            this.cơSởDữLiệuDataGridViewTextBoxColumn.Width = 93;
            // 
            // tổngĐiểmDataGridViewTextBoxColumn1
            // 
            this.tổngĐiểmDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tổngĐiểmDataGridViewTextBoxColumn1.DataPropertyName = "Tổng điểm";
            this.tổngĐiểmDataGridViewTextBoxColumn1.HeaderText = "Tổng điểm";
            this.tổngĐiểmDataGridViewTextBoxColumn1.Name = "tổngĐiểmDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 424);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Danh sách thí sinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sieuCupTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnExit;
        private DanhSachDataSet danhSachDataSet;
        private System.Windows.Forms.BindingSource chuyenTableBindingSource;
        private DanhSachDataSetTableAdapters.ChuyenTableTableAdapter chuyenTableTableAdapter;
        private DanhSachDataSet1 danhSachDataSet1;
        private System.Windows.Forms.BindingSource sieuCupTableBindingSource;
        private DanhSachDataSet1TableAdapters.SieuCupTableTableAdapter sieuCupTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốBáoDanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn họTênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmBài1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmBài2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmBài3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiếngAnhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngĐiểmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốBáoDanhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn họTênDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmThi1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmThi2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmThi3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cơSởDữLiệuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngĐiểmDataGridViewTextBoxColumn1;
    }
}

