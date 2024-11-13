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


        // コンストラクタ
        public FrmRegister()
        {
            InitializeComponent();
        }
        public FrmRegister(DataTable dataTable)
        {
            InitializeComponent();

            inTable = dataTable;

            textBoxMemberID.Enabled = false;
            textBoxMemberID.Text = inTable.Rows[0][0].ToString();
            textBoxMemberName.Text = inTable.Rows[0][1].ToString();
            textBoxMemberKana.Text  = inTable.Rows[0][2].ToString();
            comboBoxMemberBusyo.SelectedIndex = int.Parse(inTable.Rows[0][3].ToString());
            textBoxMemberKCard.Text = inTable.Rows[0][4].ToString();
            textBoxGoogleID.Text = inTable.Rows[0][5].ToString();
            textBoxGooglePass.Text = inTable.Rows[0][6].ToString();
        }


        DataTable inTable;

        // イベント
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if(inTable == null)
            {
                DbCRUD.Insert(this);
            }
            else
            {
                DbCRUD.Update(this, inTable.Rows[0][0].ToString());
            }
            this.Close();
        }

        
    }
}
