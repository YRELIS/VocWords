using System;
using System.Data.SqlClient;
using System.Drawing;

namespace VocWords
{
    class rb_RUSCheck
    {
        public void MainIF_rb_RUSCheck(string stringConnectionBD, string sql_s, out string _out)
        {
            fSelection fs = new fSelection();
            SqlDataReader read;
            SqlConnection Con = new SqlConnection(stringConnectionBD);
            SqlCommand Cmd = new SqlCommand(sql_s, Con);
            string sWord = "";
            string sWordPlus = "";
            Con.Open();
            read = Cmd.ExecuteReader();
            while (read.Read())
            {
                object oWord = read.GetValue(2);
                object oWordPlus = read.GetValue(1);
                sWord = Convert.ToString(oWord);
                sWordPlus = Convert.ToString(oWordPlus);

            }
            Con.Close();
            if (fs.cb_RELAY_MODE.Checked)
            {
                if (fs.cb_OFFHELP.Checked == false)
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

        public void MainELSE_rb_RUSCheck(string stringConnectionBD, string sql_s, string RANDWORD, string WORD
           , out object _bcColor, out object _fColor, out object _text, string sqlUpdate)
        {
            Update up = new Update();
            fSelection fs = new fSelection();
            SqlDataReader read;
            SqlConnection Con = new SqlConnection(stringConnectionBD);
            SqlCommand Cmd = new SqlCommand(sql_s, Con);
            Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters["@sENG"].Value = Convert.ToString(WORD);
            Cmd.Parameters["@sRUS"].Value = Convert.ToString(RANDWORD);
            string sEng = "";
            string sRus = "";
            Con.Open();
            read = Cmd.ExecuteReader();
            while (read.Read())
            {
                object oEng = read.GetValue(1);
                object oRus = read.GetValue(2);
                sEng = Convert.ToString(oEng);
                sRus = Convert.ToString(oRus);
            }
            if (sEng == "")
            {
                _bcColor = Color.Red;
                _fColor = Color.Black;
                _text = "BAD";
                up.upStatus(2, RANDWORD, stringConnectionBD, sqlUpdate);
                //updateStatusEng(2, lbl_RANDWORD.Text);
            }
            else
            {
                _bcColor = Color.Green;
                _fColor = Color.White;
                _text = "GOOD";
                up.upStatus(1, RANDWORD, stringConnectionBD, sqlUpdate);
                //updateStatusEng(1, lbl_RANDWORD.Text);
            }
        }
    }
}
