using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMID
{
    public class FrmMid : Form
    {
        List<Person> list = new List<Person>() { new Person() { Name = "张三", Age = 24 }, new Person() { Name = "李四", Age = 26 } };
        private DataGridView dataGridView1;

        public FrmMid()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(474, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmMid
            // 
            this.ClientSize = new System.Drawing.Size(474, 286);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMid";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MID窗体";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }



        private void SetDataSource()
        {
            dataGridView1.DataSource = list;
        }
        private void ColumnsArias()
        {
            dataGridView1.Columns["Name"].HeaderText = "姓名";
            dataGridView1.Columns["Age"].HeaderText = "年龄";

        }

        private void FrmMid_Load(object sender, EventArgs e)
        {
            SetDataSource();
            ColumnsArias();
            dataGridView1.Refresh();
        }
    }
}
