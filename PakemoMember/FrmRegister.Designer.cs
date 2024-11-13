
namespace PakemoMember
{
    partial class FrmRegister
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
            this.labelMemberID = new System.Windows.Forms.Label();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.labelMemberKana = new System.Windows.Forms.Label();
            this.labelMemberBusho = new System.Windows.Forms.Label();
            this.labelMemberKCard = new System.Windows.Forms.Label();
            this.labelGoogleID = new System.Windows.Forms.Label();
            this.labelGooglePass = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetCardID = new System.Windows.Forms.Button();
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
            this.textBoxGooglePass = new System.Windows.Forms.TextBox();
            this.textBoxGoogleID = new System.Windows.Forms.TextBox();
            this.textBoxMemberKCard = new System.Windows.Forms.TextBox();
            this.textBoxMemberKana = new System.Windows.Forms.TextBox();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.comboBoxMemberBusyo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMemberID
            // 
            this.labelMemberID.Location = new System.Drawing.Point(31, 40);
            this.labelMemberID.Name = "labelMemberID";
            this.labelMemberID.Size = new System.Drawing.Size(57, 28);
            this.labelMemberID.TabIndex = 0;
            this.labelMemberID.Text = "社員ID";
            this.labelMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemberName
            // 
            this.labelMemberName.Location = new System.Drawing.Point(31, 90);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(37, 28);
            this.labelMemberName.TabIndex = 1;
            this.labelMemberName.Text = "氏名";
            this.labelMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemberKana
            // 
            this.labelMemberKana.Location = new System.Drawing.Point(31, 140);
            this.labelMemberKana.Name = "labelMemberKana";
            this.labelMemberKana.Size = new System.Drawing.Size(57, 28);
            this.labelMemberKana.TabIndex = 2;
            this.labelMemberKana.Text = "かな";
            this.labelMemberKana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemberBusho
            // 
            this.labelMemberBusho.Location = new System.Drawing.Point(31, 190);
            this.labelMemberBusho.Name = "labelMemberBusho";
            this.labelMemberBusho.Size = new System.Drawing.Size(57, 28);
            this.labelMemberBusho.TabIndex = 3;
            this.labelMemberBusho.Text = "部署";
            this.labelMemberBusho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemberKCard
            // 
            this.labelMemberKCard.Location = new System.Drawing.Point(31, 240);
            this.labelMemberKCard.Name = "labelMemberKCard";
            this.labelMemberKCard.Size = new System.Drawing.Size(57, 28);
            this.labelMemberKCard.TabIndex = 4;
            this.labelMemberKCard.Text = "カードID";
            this.labelMemberKCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGoogleID
            // 
            this.labelGoogleID.Location = new System.Drawing.Point(31, 290);
            this.labelGoogleID.Name = "labelGoogleID";
            this.labelGoogleID.Size = new System.Drawing.Size(92, 28);
            this.labelGoogleID.TabIndex = 5;
            this.labelGoogleID.Text = "Googleアカウント";
            this.labelGoogleID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGooglePass
            // 
            this.labelGooglePass.Location = new System.Drawing.Point(31, 340);
            this.labelGooglePass.Name = "labelGooglePass";
            this.labelGooglePass.Size = new System.Drawing.Size(57, 28);
            this.labelGooglePass.TabIndex = 6;
            this.labelGooglePass.Text = "パスワード";
            this.labelGooglePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistration.Location = new System.Drawing.Point(332, 12);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(75, 38);
            this.btnRegistration.TabIndex = 7;
            this.btnRegistration.Text = "登録";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(332, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetCardID
            // 
            this.btnGetCardID.Location = new System.Drawing.Point(290, 243);
            this.btnGetCardID.Name = "btnGetCardID";
            this.btnGetCardID.Size = new System.Drawing.Size(75, 23);
            this.btnGetCardID.TabIndex = 9;
            this.btnGetCardID.Text = "取得";
            this.btnGetCardID.UseVisualStyleBackColor = true;
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.Location = new System.Drawing.Point(129, 45);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.Size = new System.Drawing.Size(101, 19);
            this.textBoxMemberID.TabIndex = 10;
            // 
            // textBoxGooglePass
            // 
            this.textBoxGooglePass.Location = new System.Drawing.Point(129, 345);
            this.textBoxGooglePass.Name = "textBoxGooglePass";
            this.textBoxGooglePass.Size = new System.Drawing.Size(155, 19);
            this.textBoxGooglePass.TabIndex = 11;
            // 
            // textBoxGoogleID
            // 
            this.textBoxGoogleID.Location = new System.Drawing.Point(129, 295);
            this.textBoxGoogleID.Name = "textBoxGoogleID";
            this.textBoxGoogleID.Size = new System.Drawing.Size(155, 19);
            this.textBoxGoogleID.TabIndex = 12;
            // 
            // textBoxMemberKCard
            // 
            this.textBoxMemberKCard.Location = new System.Drawing.Point(129, 245);
            this.textBoxMemberKCard.Name = "textBoxMemberKCard";
            this.textBoxMemberKCard.Size = new System.Drawing.Size(155, 19);
            this.textBoxMemberKCard.TabIndex = 13;
            // 
            // textBoxMemberKana
            // 
            this.textBoxMemberKana.Location = new System.Drawing.Point(129, 145);
            this.textBoxMemberKana.Name = "textBoxMemberKana";
            this.textBoxMemberKana.Size = new System.Drawing.Size(155, 19);
            this.textBoxMemberKana.TabIndex = 14;
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(129, 95);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(155, 19);
            this.textBoxMemberName.TabIndex = 15;
            // 
            // comboBoxMemberBusyo
            // 
            this.comboBoxMemberBusyo.FormattingEnabled = true;
            this.comboBoxMemberBusyo.Items.AddRange(new object[] {
            "なし",
            "パッケージ開発部",
            "モバイル医療部",
            "デザイン企画部",
            "営業部"});
            this.comboBoxMemberBusyo.Location = new System.Drawing.Point(129, 195);
            this.comboBoxMemberBusyo.Name = "comboBoxMemberBusyo";
            this.comboBoxMemberBusyo.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMemberBusyo.TabIndex = 16;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 422);
            this.Controls.Add(this.comboBoxMemberBusyo);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.textBoxMemberKana);
            this.Controls.Add(this.textBoxMemberKCard);
            this.Controls.Add(this.textBoxGoogleID);
            this.Controls.Add(this.textBoxGooglePass);
            this.Controls.Add(this.textBoxMemberID);
            this.Controls.Add(this.btnGetCardID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.labelGooglePass);
            this.Controls.Add(this.labelGoogleID);
            this.Controls.Add(this.labelMemberKCard);
            this.Controls.Add(this.labelMemberBusho);
            this.Controls.Add(this.labelMemberKana);
            this.Controls.Add(this.labelMemberName);
            this.Controls.Add(this.labelMemberID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmRegister";
            this.Text = "登録・編集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemberID;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.Label labelMemberKana;
        private System.Windows.Forms.Label labelMemberBusho;
        private System.Windows.Forms.Label labelMemberKCard;
        private System.Windows.Forms.Label labelGoogleID;
        private System.Windows.Forms.Label labelGooglePass;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetCardID;
        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.TextBox textBoxGooglePass;
        private System.Windows.Forms.TextBox textBoxGoogleID;
        private System.Windows.Forms.TextBox textBoxMemberKCard;
        private System.Windows.Forms.TextBox textBoxMemberKana;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.ComboBox comboBoxMemberBusyo;
    }
}