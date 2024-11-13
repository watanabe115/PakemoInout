using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PakemoMember
{
    public partial class FrmMembers: Form

       
    {
        public FrmMembers()
        {
            InitializeComponent();
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var registrationForm = new FrmRegister();
            registrationForm.ShowDialog();
            dataGridView1.DataSource = DbAccess.GetData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var fixesForm = new FrmRegister();
            fixesForm.ShowDialog();
            dataGridView1.DataSource = DbAccess.GetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("社員ID:" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "を削除しますか？", "削除", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("社員ID:" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "を削除しました。", "削除完了", MessageBoxButtons.OK);

            }
            //dataGridView1.Rows.RemoveAt(0);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbAccess.GetData();
            lblMemberCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
