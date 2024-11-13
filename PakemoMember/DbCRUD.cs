using System;
using System.Data.SqlClient;

namespace PakemoMember
{
    internal class DbCRUD
    {
        private FrmRegister referenceForm;

        internal static void Insert(FrmRegister referenceForm)
        {
            // 登録フォームの値をテーブルへ渡すためのフィールド
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
            MemberID = referenceForm.TextBoxMemberID;
            MemberName = referenceForm.TextBoxMemberName;
            MemberKana = referenceForm.TextBoxMemberKana;
            MemberBusyo = referenceForm.ComboBoxMemberBusyo;
            MemberKCard = "";
            GoogleID = referenceForm.TextBoxGoogleID;
            GooglePass = referenceForm.TextBoxGooglePass;
            DelFlg = 0;
            WriteDate = DateTime.Now;


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
                    command.CommandText = 
                        @"INSERT INTO [dbo].[MST_MEMBER] ([MemberId]
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

        internal static void Update(FrmRegister referenceForm, string selectedId)
        {
            // 登録フォームの値をテーブルへ渡すためのフィールド
            string MemberID;
            string MemberName;
            string MemberKana;
            int MemberBusyo;
            string MemberKCard = "001";
            string GoogleID;
            string GooglePass;
            DateTime WriteDate;

            // 登録フォームの入力情報を取得
            MemberID = selectedId;
            MemberName = referenceForm.TextBoxMemberName;
            MemberKana = referenceForm.TextBoxMemberKana;
            MemberBusyo = referenceForm.ComboBoxMemberBusyo;
            MemberKCard = "";
            GoogleID = referenceForm.TextBoxGoogleID;
            GooglePass = referenceForm.TextBoxGooglePass;
            WriteDate = DateTime.Now;


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
                    command.CommandText =
                        @"UPDATE                          [dbo].[MST_MEMBER]
                          SET                            [MemberName] = @MemberName
                                                         ,[MemberKana] = @MemberKana
                                                         ,[MemberBusho] = @MemberBusho
                                                         ,[MemberKCard] = @MemberKCard
                                                         ,[GoogleID] = @GoogleID
                                                         ,[GooglePass] = @GooglePass
                                                         ,[WriteDate] = @WriteDate

                          WHERE                          [MemberId] = @MemberId";

                    command.Parameters.Add(new SqlParameter("@MemberId", MemberID));
                    command.Parameters.Add(new SqlParameter("@MemberName", MemberName));
                    command.Parameters.Add(new SqlParameter("@MemberKana", MemberKana));
                    command.Parameters.Add(new SqlParameter("@MemberBusho", MemberBusyo));
                    command.Parameters.Add(new SqlParameter("@MemberKCard", MemberKCard));
                    command.Parameters.Add(new SqlParameter("@GoogleID", GoogleID));
                    command.Parameters.Add(new SqlParameter("@GooglePass", GooglePass));
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

        internal static void Delete(string deleteID)
        {
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
                    command.CommandText =
                        @"DELETE FROM   [dbo].[MST_MEMBER]
                                                         
                                 WHERE  [MemberId] = @DeleteMemberId";

                    command.Parameters.Add(new SqlParameter("@DeleteMemberId", deleteID));
                   
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
