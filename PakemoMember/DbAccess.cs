using System;
using System.Data;
using System.Data.SqlClient;

namespace PakemoMember
{
    internal class DbAccess
    {
        internal static DataTable GetData()
        {
            var table = new DataTable();

            // 接続文字列の取得
            var connectionString = "Data Source=DESKTOP-FLVBBJM\\SQLEXPRESS;Initial Catalog=KANRI;Integrated Security=True;";

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    // データベースの接続開始
                    connection.Open();

                    // SQLの設定
                    command.CommandText = @"SELECT [MemberId],[MemberName] FROM [dbo].[MST_MEMBER]";

                    // SQLの実行
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
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

            return table;
        }
    }
}
