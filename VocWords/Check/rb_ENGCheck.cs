using System;
using System.Data.SqlClient;
using System.Drawing;

namespace VocWords
{
    class rb_ENGCheck
    {
        public void MainIF_rb_ENGCheck(string stringConnectionBD, string sql_s, 
            bool RoleMode, bool CheckHelp, out string _out)
        {
            SqlDataReader read;
            SqlConnection Con = new SqlConnection(stringConnectionBD);
            SqlCommand Cmd = new SqlCommand(sql_s, Con);
            string sWord = "";
            string sWordPlus = "";
            Con.Open();
            read = Cmd.ExecuteReader();
            while (read.Read())
            {
                object oWord = read.GetValue(1);
                object oWordPlus = read.GetValue(2);
                sWord = Convert.ToString(oWord);
                sWordPlus = Convert.ToString(oWordPlus);
            }
            Con.Close();
            if (RoleMode == true)
            {
                if (CheckHelp == false)
                {
                    _out = sWord + "( " + sWordPlus + " )";

                }
                else
                {
                    _out = sWord;
                }

            }
            else
            {
                _out = sWord;
            }
        }
        public void MainELSE_rb_ENGCheck(string stringConnectionBD, string sql_s, string RANDWORD, string WORD
           ,out object _bcColor, out object _fColor, out object _text, string sqlUpdate)
        {
            Update up = new Update();
            SqlDataReader read;
            SqlConnection Con = new SqlConnection(stringConnectionBD);
            SqlCommand Cmd = new SqlCommand(sql_s, Con);
            Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters["@sENG"].Value = Convert.ToString(RANDWORD);
            Cmd.Parameters["@sRUS"].Value = Convert.ToString(WORD);
            string sEng = "";
            string sRus = "";
            string sRus2 = "";
            string sRus3 = "";
            Con.Open();
            read = Cmd.ExecuteReader();
            while (read.Read())
            {
                object oEng = read.GetValue(1);
                object oRus = read.GetValue(2);
                object oRus2 = read.GetValue(5);
                object oRus3 = read.GetValue(6);
                sEng = Convert.ToString(oEng);
                sRus = Convert.ToString(oRus);
                sRus2 = Convert.ToString(oRus2);
                sRus3 = Convert.ToString(oRus3);
            }
            if (sRus == "" && sRus2 == "" && sRus3 == "")
            {
                _bcColor = Color.Red;
                _fColor = Color.Black;
                _text = "BAD";
                up.upStatus(2, RANDWORD, stringConnectionBD, sqlUpdate);
            }
            else
            {
                _bcColor = Color.Green;
                _fColor = Color.White;
                _text = "GOOD";
                up.upStatus(1, RANDWORD, stringConnectionBD, sqlUpdate);
            }
        }
    }
}
