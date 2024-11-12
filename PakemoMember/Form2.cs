using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PakemoMember
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            dbTable.Insert(this);
        }

        
    }

    internal class dbTable
    {
        public static void Insert(Form registrationForm)
        {

            // 登録フォームの値を渡すためのフィールド
            string MemberID;
            string MemberName;
            string MemberKana;
            int MemberBusyo;
            string MemberKCard = "001";
            string GoogleID;
            string GooglePass;
            int DelFlg;
            DateTime WriteDate;

            // 登録フォームの入力情報を取得   
            MemberID = "";
            MemberName = "";
            MemberKana = "";
            MemberBusyo = 1;
            MemberKCard = "001";
            GoogleID = "";
            GooglePass = "";
            DelFlg = 0;
            DateTime.TryParse("2024/11/12", out WriteDate);

            // 接続文字列の取得
            var connectionString = "Data Source=DESKTOP-FLVBBJM\\SQLEXPRESS;Initial Catalog=KANRI;Integrated Security=True;";

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    // データベースの接続開始
                    connection.Open();

                    // SQLの準備
                    command.CommandText = @"INSERT INTO [dbo].[MST_MEMBER] ([MemberId]
                                                                           ,[MemberName]
                                                                           ,[MemberKana]
                                                                           ,[MemberBusho]
                                                                           ,[MemberKCard]
                                                                           ,[GoogleID]
                                                                           ,[GooglePass]
                                                                           ,[DeIFlag]
                                                                           ,[WriteDate])

                                            VALUES                         (@MemberId
                                                                           ,@MemberName
                                                                           ,@MemberKana
                                                                           ,@MemberBusho
                                                                           ,@MemberKCard
                                                                           ,@GoogleID
                                                                           ,@GooglePass
                                                                           ,@DeIFlag
                                                                           ,@WriteDate)";
                    command.Parameters.Add(new SqlParameter("@MemberId", MemberID));
                    command.Parameters.Add(new SqlParameter("@MemberName", MemberName));
                    command.Parameters.Add(new SqlParameter("@MemberKana", MemberKana));
                    command.Parameters.Add(new SqlParameter("@MemberBusho", MemberBusyo));
                    command.Parameters.Add(new SqlParameter("@MemberKCard", MemberKCard));
                    command.Parameters.Add(new SqlParameter("@GoogleID", GoogleID));
                    command.Parameters.Add(new SqlParameter("@GooglePass", GooglePass));
                    command.Parameters.Add(new SqlParameter("@DeIFlag", DelFlg));
                    command.Parameters.Add(new SqlParameter("@WriteDate", WriteDate));

                    // SQLの実行
                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
                finally
                {
                    // データベースの接続終了
                    connection.Close();
                }
            }
        }
    }
}
