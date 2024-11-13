using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PakemoMember
{
    public partial class FrmRegister : Form
    {
        // フォーム外に情報を渡すためのプロパティ
        // 入力、選択した情報を社員マスタに渡したい
        public string TextBoxMemberID
        {
            get
            {
                return textBoxMemberID.Text;
            }
            set
            {
                textBoxMemberID.Text = value;
            }
        }
        public string TextBoxMemberName
        {
            get
            {
                return textBoxMemberName.Text;
            }
            set
            {
                textBoxMemberName.Text = value;
            }
        }
        public string TextBoxMemberKana
        {
            get
            {
                return textBoxMemberKana.Text;
            }
            set
            {
                textBoxMemberKana.Text = value;
            }
        }
        public int ComboBoxMemberBusyo
        {
            get
            {
                return comboBoxMemberBusyo.SelectedIndex;
            }
            set
            {
                comboBoxMemberBusyo.SelectedIndex = value;
            }
        }
        public string TextBoxMemberKCard
        {
            get
            {
                return textBoxMemberKCard.Text;
            }
            set
            {
                textBoxMemberKCard.Text = value;
            }
        }
        public string TextBoxGoogleID
        {
            get
            {
                return textBoxGoogleID.Text;
            }
            set
            {
                textBoxGoogleID.Text = value;
            }
        }
        public string TextBoxGooglePass
        {
            get
            {
                return textBoxGooglePass.Text;
            }
            set
            {
                textBoxGooglePass.Text = value;
            }
        }


        // イベント
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            DbCRUD.Insert(this);
           // MainForm.dataGridView1.DataSource = DbAccess.GetData();
           // マスタ画面を更新したい
            this.Close();
        }

        
    }
}
