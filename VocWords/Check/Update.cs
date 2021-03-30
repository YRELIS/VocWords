using System;
using System.Data.SqlClient;
using System.Drawing;

namespace VocWords
{
    class Update
    {
        public void upStatus(int id, string word, string connection, string sql)
        {
            SqlConnection Con = new SqlConnection(connection);
            SqlCommand Cmd = new SqlCommand(sql, Con);
            Cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            Cmd.Parameters.Add("@word", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters["@id"].Value = id;
            Cmd.Parameters["@word"].Value = Convert.ToString(word);
            Con.Open();
            int RowsAffected = Cmd.ExecuteNonQuery();
            Con.Close();
        }

        public void upStatusThree(string connection, string sql)
        {
            SqlConnection Con = new SqlConnection(connection);
            SqlCommand Cmd = new SqlCommand(sql, Con);
            Con.Open();
            int RowsAffected = Cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
