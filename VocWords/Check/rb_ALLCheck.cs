using System;
using System.Data.SqlClient;
using System.Drawing;

namespace VocWords
{
    class rb_ALLCheck
    {
        public void MainIF_rb_ALLCheck(string stringConnectionBD, string sql_s, out string _out)
        {

            fSelection fs = new fSelection();
            SqlDataReader read;
            SqlConnection Con = new SqlConnection(stringConnectionBD);
            SqlCommand Cmd = new SqlCommand(sql_s, Con);
            string sWordEng = "";
            string sWordRus = "";
            Con.Open();
            read = Cmd.ExecuteReader();
            while (read.Read())
            {
                object oWordEng = read.GetValue(1);
                object oWordRus = read.GetValue(2);
                sWordEng = Convert.ToString(oWordEng);
                sWordRus = Convert.ToString(oWordRus);
            }
            Con.Close();
            Random rand = new Random();
            int rdn = rand.Next(1, 3);
            if (rdn == 1)
            {
                if (fs.cb_RELAY_MODE.Checked)
                {
                    if (fs.cb_OFFHELP.Checked == false)
                    {
                        _out = sWordEng + "( " + sWordRus + " )";
                    }
                    else
                    {
                        _out = sWordEng;
                    }

                }
                else
                {
                    _out = sWordEng;
                }
            }
            else
            {
                if (fs.cb_RELAY_MODE.Checked)
                {
                    if (fs.cb_OFFHELP.Checked == false)
                    {
                        _out = sWordRus + "( " + sWordEng + " )";
                    }
                    else
                    {
                        _out = sWordRus;
                    }

                }
                else
                {
                    _out = sWordRus;
                }
            }
        }
        //public void MainELSE_rb_ENGCheck(string stringConnectionBD, string sql_s, string RANDWORD, string WORD
        //   , out object _bcColor, out object _fColor, out object _text, string sqlUpdate)
        //{
        //    fSelection fs = new fSelection();
        //    Update up = new Update();

        //}
    }
}
