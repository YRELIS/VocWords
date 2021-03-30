using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;

namespace VocWords
{
    public partial class fSelection : Form
    {
        public fSelection()
        {
            InitializeComponent();
        }
        string stringConnectionBD = @"Data Source = DESKTOP-1K4LJJS\SQLEXPRESS; Initial Catalog = VocWords; Integrated Security = True";
        string commandSQLSelect_1 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
        string commandSQLSelect_2 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
        string commandSQLSelect_3 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
        string commandSQLSelect_4 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
        string commandSQLSelect_5 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
        string commandSQLSelect_6 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
        string commandSQLSelect_7 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
        string commandSQLSelect_8 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
        string commandSQLSelect_9 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
        string commandSQLSelect_10 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS OR sRUS2 = @sRUS OR sRUS3 = @sRUS";
        string commandSQLSelect_11 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS";
        string commandSQLSelect_12 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS OR sRUS2 = @sRUS OR sRUS3 = @sRUS";
        string commandSQLSelect_13 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS";

        string commandSQLSelect_14 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 1";
        string commandSQLSelect_15 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 2";
        string commandSQLSelect_16 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 3";

        string commandSQLUpdate_1 = "UPDATE WORDS SET idStatus = @id WHERE sRUS = @word";
        string commandSQLUpdate_2 = "UPDATE WORDS SET idStatus = @id WHERE sENG = @word";
        string commandSQLUpdate_3 = "UPDATE WORDS SET idStatus = 3";

        private void fSelection_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vocWordsDataSet.FullTableWords". При необходимости она может быть перемещена или удалена.
            this.fullTableWordsTableAdapter.Fill(this.vocWordsDataSet.FullTableWords);
            CountBadAndGood();
        }

        #region CHECK
        private void btn_Check_Click(object sender, EventArgs e)
        {
            SendCheck();
            txb_WORD.Focus();
        }

        /// <summary>
        /// МЕТОД ПРОВЕРКИ ВЕДЕННОГО СЛОВА
        /// </summary>
        public void SendCheck()
        {
            // Если текст кнопки ДАЛЬШЕ
            if (btn_Check.Text == "ДАЛЬШЕ")
            {
                lbl_CORRECT.Text = "";
                lbl_CORRECT.BackColor = Color.Gray;
                lbl_CORRECT.ForeColor = Color.Gray;
                // ЧЕКБОКС по всему
                if (cb_all.Checked)
                {
                    // РАДИОБАТОН по английским
                    if (rb_ENG.Checked)
                    {
                        string _out;
                        rb_ENGCheck RbEng = new rb_ENGCheck();
                        RbEng.MainIF_rb_ENGCheck(stringConnectionBD, commandSQLSelect_1, out _out);
                        lbl_RANDWORD.Text = _out;
                    }
                    // РАДИОБАТОН по русским
                    else if (rb_RUS.Checked)
                    {
                        SqlDataReader read;
                        SqlConnection Con = new SqlConnection(stringConnectionBD);
                        SqlCommand Cmd = new SqlCommand(commandSQLSelect_2, Con);
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
                        if (cb_RELAY_MODE.Checked)
                        {
                            if (cb_OFFHELP.Checked == false)
                            {
                                lbl_RANDWORD.Text = sWord + "( " + sWordPlus + " )";
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWord;
                            }
                        }
                        else
                        {
                            lbl_RANDWORD.Text = sWord;
                        }
                    }
                    // РАДИОБАТОН по ВСЕМ
                    else
                    {
                        SqlDataReader read;
                        SqlConnection Con = new SqlConnection(stringConnectionBD);
                        SqlCommand Cmd = new SqlCommand(commandSQLSelect_3, Con);
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
                            if (cb_RELAY_MODE.Checked)
                            {
                                if (cb_OFFHELP.Checked == false)
                                {
                                    lbl_RANDWORD.Text = sWordEng + "( " + sWordRus + " )";
                                }
                                else
                                {
                                    lbl_RANDWORD.Text = sWordEng;
                                }
                                
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWordEng;
                            }
                        }
                        else
                        {
                            if (cb_RELAY_MODE.Checked)
                            {
                                if (cb_OFFHELP.Checked == false)
                                {
                                    lbl_RANDWORD.Text = sWordRus + "( " + sWordEng + " )";
                                }
                                else
                                {
                                    lbl_RANDWORD.Text = sWordRus;
                                }
                                
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWordRus;
                            }
                        }

                    }
                }
                // ЧЕКБОКС по BAD
                else if (cb_bad.Checked)
                {
                    if (rb_ENG.Checked)
                    {
                        string _out;
                        rb_ENGCheck RbEng = new rb_ENGCheck();
                        RbEng.MainIF_rb_ENGCheck(stringConnectionBD, commandSQLSelect_4, out _out);
                        lbl_RANDWORD.Text = _out;
                    }
                    else if (rb_RUS.Checked)
                    {

                        SqlDataReader read;
                        SqlConnection Con = new SqlConnection(stringConnectionBD);
                        SqlCommand Cmd = new SqlCommand(commandSQLSelect_5, Con);
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
                        if (cb_RELAY_MODE.Checked)
                        {
                            if (cb_OFFHELP.Checked == false)
                            {
                                lbl_RANDWORD.Text = sWord + "( " + sWordPlus + " )";
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWord;
                            }
                        }
                        else
                        {
                            lbl_RANDWORD.Text = sWord;
                        }
                    }
                    else
                    {
                        SqlDataReader read;
                        SqlConnection Con = new SqlConnection(stringConnectionBD);
                        SqlCommand Cmd = new SqlCommand(commandSQLSelect_6, Con);
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
                            if (cb_RELAY_MODE.Checked)
                            {
                                if (cb_OFFHELP.Checked == false)
                                {
                                    lbl_RANDWORD.Text = sWordEng + "( " + sWordRus + " )";
                                }
                                else
                                {
                                    lbl_RANDWORD.Text = sWordEng;
                                }
                                
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWordEng;
                            }
                        }
                        else
                        {
                            if (cb_RELAY_MODE.Checked)
                            {
                                if (cb_OFFHELP.Checked == false)
                                {
                                    lbl_RANDWORD.Text = sWordRus + "( " + sWordEng + " )";
                                }
                                else
                                {
                                    lbl_RANDWORD.Text = sWordRus;
                                }
                                
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWordRus;
                            }
                        }

                    }
                }
                else if (cb_noGood.Checked)
                {
                    if (rb_ENG.Checked)
                    {
                        string _out;
                        rb_ENGCheck RbEng = new rb_ENGCheck();
                        RbEng.MainIF_rb_ENGCheck(stringConnectionBD, commandSQLSelect_7, out _out);
                        lbl_RANDWORD.Text = _out;
                    }
                    else if (rb_RUS.Checked)
                    {

                        SqlDataReader read;
                        SqlConnection Con = new SqlConnection(stringConnectionBD);
                        SqlCommand Cmd = new SqlCommand(commandSQLSelect_8, Con);
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
                        if (cb_RELAY_MODE.Checked)
                        {
                            if (cb_OFFHELP.Checked == false)
                            {
                                lbl_RANDWORD.Text = sWord + "( " + sWordPlus + " )";
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWord;
                            }
                        }
                        else
                        {
                            lbl_RANDWORD.Text = sWord;
                        }
                    }
                    else
                    {
                        SqlDataReader read;
                        SqlConnection Con = new SqlConnection(stringConnectionBD);
                        SqlCommand Cmd = new SqlCommand(commandSQLSelect_9, Con);
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
                            if (cb_RELAY_MODE.Checked)
                            {
                                if (cb_OFFHELP.Checked == false)
                                {
                                    lbl_RANDWORD.Text = sWordEng + "( " + sWordRus + " )";
                                }
                                else
                                {
                                    lbl_RANDWORD.Text = sWordEng;
                                }
                                
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWordEng;
                            }
                        }
                        else
                        {
                            if (cb_RELAY_MODE.Checked)
                            {
                                if (cb_OFFHELP.Checked == false)
                                {
                                    lbl_RANDWORD.Text = sWordRus + "( " + sWordEng + " )";
                                }
                                else
                                {
                                    lbl_RANDWORD.Text = sWordRus;
                                }
                                
                            }
                            else
                            {
                                lbl_RANDWORD.Text = sWordRus;
                            }
                        }

                    }
                }
                txb_WORD.Enabled = true;
            }
            else
            {
                Update up = new Update();
                var words = lbl_RANDWORD.Text.Split(new char[] { '(' });
                lbl_RANDWORD.Text = words[0];
                if (rb_ENG.Checked)
                {
                    rb_ENGCheck RbEng = new rb_ENGCheck();
                    RbEng.MainELSE_rb_ENGCheck(stringConnectionBD, commandSQLSelect_10, lbl_RANDWORD.Text, txb_WORD.Text, 
                        out object _bcColor, out object _fColor, out object _text);
                    lbl_CORRECT.BackColor = (Color)_bcColor;
                    lbl_CORRECT.ForeColor = (Color)_fColor;
                    lbl_CORRECT.Text = (String)_text;
                }
                else if (rb_RUS.Checked)
                {
                    
                    SqlDataReader read;
                    SqlConnection Con = new SqlConnection(stringConnectionBD);
                    SqlCommand Cmd = new SqlCommand(commandSQLSelect_11, Con);
                    Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
                    Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
                    Cmd.Parameters["@sENG"].Value = Convert.ToString(txb_WORD.Text);
                    Cmd.Parameters["@sRUS"].Value = Convert.ToString(lbl_RANDWORD.Text);
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
                        lbl_CORRECT.BackColor = Color.Red;
                        lbl_CORRECT.ForeColor = Color.Black;
                        lbl_CORRECT.Text = "BAD";
                        up.upStatus(2, lbl_RANDWORD.Text, stringConnectionBD, commandSQLUpdate_1);
                        //updateStatusEng(2, lbl_RANDWORD.Text);
                    }
                    else
                    {
                        lbl_CORRECT.BackColor = Color.Green;
                        lbl_CORRECT.ForeColor = Color.White;
                        lbl_CORRECT.Text = "GOOD";
                        up.upStatus(1, lbl_RANDWORD.Text, stringConnectionBD, commandSQLUpdate_1);
                        //updateStatusEng(1, lbl_RANDWORD.Text);
                    }
                }
                else
                {
                    if (LanguagetText(lbl_RANDWORD.Text) == "eng")
                    {
                        SqlDataReader read;
                        SqlConnection Con = new SqlConnection(stringConnectionBD);
                        SqlCommand Cmd = new SqlCommand(commandSQLSelect_12, Con);
                        Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
                        Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
                        Cmd.Parameters["@sENG"].Value = Convert.ToString(lbl_RANDWORD.Text);
                        Cmd.Parameters["@sRUS"].Value = Convert.ToString(txb_WORD.Text);
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
                            lbl_CORRECT.BackColor = Color.Red;
                            lbl_CORRECT.ForeColor = Color.Black;
                            lbl_CORRECT.Text = "BAD";
                            up.upStatus(2, lbl_RANDWORD.Text, stringConnectionBD, commandSQLUpdate_2);
                            //updateStatusRus(2, lbl_RANDWORD.Text);
                        }
                        else
                        {
                            lbl_CORRECT.BackColor = Color.Green;
                            lbl_CORRECT.ForeColor = Color.White;
                            lbl_CORRECT.Text = "GOOD";
                            up.upStatus(1, lbl_RANDWORD.Text, stringConnectionBD, commandSQLUpdate_2);
                            //updateStatusRus(1, lbl_RANDWORD.Text);
                        }
                    }
                    else
                    {
                        SqlDataReader read;
                        SqlConnection Con = new SqlConnection(stringConnectionBD);
                        SqlCommand Cmd = new SqlCommand(commandSQLSelect_13, Con);
                        Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
                        Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
                        Cmd.Parameters["@sENG"].Value = Convert.ToString(txb_WORD.Text);
                        Cmd.Parameters["@sRUS"].Value = Convert.ToString(lbl_RANDWORD.Text);
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
                            lbl_CORRECT.BackColor = Color.Red;
                            lbl_CORRECT.ForeColor = Color.Black;
                            lbl_CORRECT.Text = "BAD";
                            up.upStatus(2, lbl_RANDWORD.Text, stringConnectionBD, commandSQLUpdate_1);
                            //updateStatusEng(2, lbl_RANDWORD.Text);
                        }
                        else
                        {
                            lbl_CORRECT.BackColor = Color.Green;
                            lbl_CORRECT.ForeColor = Color.White;
                            lbl_CORRECT.Text = "GOOD";
                            up.upStatus(1, lbl_RANDWORD.Text, stringConnectionBD, commandSQLUpdate_1);
                            //updateStatusEng(1, lbl_RANDWORD.Text);
                        }
                    }
                }
                txb_WORD.Text = "";
                btn_Check.Text = "ДАЛЬШЕ";
                txb_WORD.Enabled = false;
                CountBadAndGood();
            }
        }

        private void txb_WORD_KeyDown(object sender, KeyEventArgs e)
        {
            btn_Check.Text = "ПРОВЕРИТЬ";
            if (e.KeyCode == Keys.Enter)
            {
                SendCheck();

            }

        }

        InputLanguage original;

        public void EngLanguage()
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        public void RusLanguage()
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("ru");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        static public string LanguagetText(string text)
        {
            bool rus = false, eng = false;

            text = text.ToLower();

            byte[] Ch = System.Text.Encoding.Default.GetBytes(text);
            foreach (byte ch in Ch)
            {
                if ((ch >= 97) && (ch <= 122)) eng = true;
                if ((ch >= 224) && (ch <= 255)) rus = true;
            }

            if (eng & !rus) return "eng";
            if (rus & !eng) return "rus";
            if (eng & rus) return "mix"; //смашанный состав
            return "uni"; // универсальный состав (например если будет только 12345)
        }

        private void txb_WORD_Enter(object sender, EventArgs e)
        {
            var words = lbl_RANDWORD.Text.Split(new char[] { '(' });
            string text = words[0];
            if (LanguagetText(text) == "eng")
            {

                RusLanguage();
            }
            else
            {
                EngLanguage();
            }
        }

        //public void updateStatusEng(int id, string word)
        //{
        //    SqlConnection Con = new SqlConnection(stringConnectionBD);
        //    SqlCommand Cmd = new SqlCommand(commandSQLUpdate_1, Con);
        //    Cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
        //    Cmd.Parameters.Add("@word", System.Data.SqlDbType.NVarChar);
        //    Cmd.Parameters["@id"].Value = id;
        //    Cmd.Parameters["@word"].Value = Convert.ToString(word);
        //    Con.Open();
        //    int RowsAffected = Cmd.ExecuteNonQuery();
        //    Con.Close();
        //}
        //public void updateStatusRus(int id, string word)
        //{
        //    SqlConnection Con = new SqlConnection(stringConnectionBD);
        //    SqlCommand Cmd = new SqlCommand(commandSQLUpdate_2, Con);
        //    Cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
        //    Cmd.Parameters.Add("@word", System.Data.SqlDbType.NVarChar);
        //    Cmd.Parameters["@id"].Value = id;
        //    Cmd.Parameters["@word"].Value = Convert.ToString(word);
        //    Con.Open();
        //    int RowsAffected = Cmd.ExecuteNonQuery();
        //    Con.Close();
        //}

        public void CountBadAndGood()
        {
            // GOOD COUNT
            SqlDataReader read;
            SqlConnection Con = new SqlConnection(stringConnectionBD);
            SqlCommand Cmd = new SqlCommand(commandSQLSelect_14, Con);
            string cGood = "";
            Con.Open();
            read = Cmd.ExecuteReader();
            while (read.Read())
            {
                object oGood = read.GetValue(0);
                cGood = Convert.ToString(oGood);
            }
            lbl_good.Text = cGood;
            Con.Close();

            // BAD COUNT
            SqlCommand Cmd2 = new SqlCommand(commandSQLSelect_15, Con);
            string cBad = "";
            Con.Open();
            read = Cmd2.ExecuteReader();
            while (read.Read())
            {
                object oBad = read.GetValue(0);
                cBad = Convert.ToString(oBad);
            }
            lbl_bad.Text = cBad;
            Con.Close();

            // X COUNT
            SqlCommand Cmd3 = new SqlCommand(commandSQLSelect_16, Con);
            string cX = "";
            Con.Open();
            read = Cmd3.ExecuteReader();
            while (read.Read())
            {
                object oX = read.GetValue(0);
                cX = Convert.ToString(oX);
            }
            lbl_x.Text = cX;
            Con.Close();
        }

        private void cb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_all.Checked)
            {
                cb_bad.Enabled = false;
                cb_all.Enabled = true;
                cb_noGood.Enabled = false;
            }
            if (cb_all.Checked == false)
            {
                cb_bad.Enabled = true;
                cb_all.Enabled = true;
                cb_noGood.Enabled = true;
            }
        }

        private void cb_bad_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_bad.Checked)
            {
                cb_bad.Enabled = true;
                cb_all.Enabled = false;
                cb_noGood.Enabled = false;
            }
            if (cb_bad.Checked == false)
            {
                cb_bad.Enabled = true;
                cb_all.Enabled = true;
                cb_noGood.Enabled = true;
            }
        }

        private void cb_noGood_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_noGood.Checked)
            {
                cb_noGood.Enabled = true;
                cb_bad.Enabled = false;
                cb_all.Enabled = false;
            }
            if (cb_noGood.Checked == false)
            {
                cb_bad.Enabled = true;
                cb_all.Enabled = true;
                cb_noGood.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            //SqlConnection Con = new SqlConnection(stringConnectionBD);
            //SqlCommand Cmd = new SqlCommand(commandSQLUpdate_3, Con);
            //Con.Open();
            //int RowsAffected = Cmd.ExecuteNonQuery();
            //Con.Close();
            up.upStatusThree(stringConnectionBD, commandSQLUpdate_3);
            CountBadAndGood();
        }

        private void cb_RELAY_MODE_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_RELAY_MODE.Checked)
            {
                commandSQLSelect_1 = "SELECT TOP 1 * FROM WORDS_ALL ORDER BY NEWID()";
                commandSQLSelect_2 = "SELECT TOP 1 * FROM WORDS_ALL ORDER BY NEWID()";
                commandSQLSelect_3 = "SELECT TOP 1 * FROM WORDS_ALL ORDER BY NEWID()";
                commandSQLSelect_4 = "SELECT TOP 1 * FROM WORDS_ALL WHERE idStatus = 2 ORDER BY NEWID()";
                commandSQLSelect_5 = "SELECT TOP 1 * FROM WORDS_ALL WHERE idStatus = 2 ORDER BY NEWID()";
                commandSQLSelect_6 = "SELECT TOP 1 * FROM WORDS_ALL WHERE idStatus = 2 ORDER BY NEWID()";
                commandSQLSelect_7 = "SELECT TOP 1 * FROM WORDS_ALL WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
                commandSQLSelect_8 = "SELECT TOP 1 * FROM WORDS_ALL WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
                commandSQLSelect_9 = "SELECT TOP 1 * FROM WORDS_ALL WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
                commandSQLSelect_10 = "SELECT * FROM WORDS_ALL WHERE sENG = @sENG AND sRUS = @sRUS";
                commandSQLSelect_11 = "SELECT * FROM WORDS_ALL WHERE sENG = @sENG AND sRUS = @sRUS";
                commandSQLSelect_12 = "SELECT * FROM WORDS_ALL WHERE sENG = @sENG AND sRUS = @sRUS";
                commandSQLSelect_13 = "SELECT * FROM WORDS_ALL WHERE sENG = @sENG AND sRUS = @sRUS";

                commandSQLSelect_14 = "SELECT COUNT(*) FROM WORDS_ALL WHERE idStatus = 1";
                commandSQLSelect_15 = "SELECT COUNT(*) FROM WORDS_ALL WHERE idStatus = 2";
                commandSQLSelect_16 = "SELECT COUNT(*) FROM WORDS_ALL WHERE idStatus = 3";

                commandSQLUpdate_1 = "UPDATE WORDS_ALL SET idStatus = @id WHERE sRUS = @word OR sRUS2 = @word OR sRUS3 = @word";
                commandSQLUpdate_2 = "UPDATE WORDS_ALL SET idStatus = @id WHERE sENG = @word";
                commandSQLUpdate_3 = "UPDATE WORDS_ALL SET idStatus = 3";
            }
            if (cb_RELAY_MODE.Checked == false)
            {
                commandSQLSelect_1 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
                commandSQLSelect_2 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
                commandSQLSelect_3 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
                commandSQLSelect_4 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
                commandSQLSelect_5 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
                commandSQLSelect_6 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
                commandSQLSelect_7 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
                commandSQLSelect_8 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
                commandSQLSelect_9 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
                commandSQLSelect_10 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS OR sRUS2 = @sRUS OR sRUS3 = @sRUS";
                commandSQLSelect_11 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS";
                commandSQLSelect_12 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS OR sRUS2 = @sRUS OR sRUS3 = @sRUS";
                commandSQLSelect_13 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS";

                commandSQLSelect_14 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 1";
                commandSQLSelect_15 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 2";
                commandSQLSelect_16 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 3";

                commandSQLUpdate_1 = "UPDATE WORDS SET idStatus = @id WHERE sRUS = @word";
                commandSQLUpdate_2 = "UPDATE WORDS SET idStatus = @id WHERE sENG = @word";
                commandSQLUpdate_3 = "UPDATE WORDS SET idStatus = 3";
            }
        }


        private void btn_DOWNLOAD_Click(object sender, EventArgs e)
        {
            List<string> wal = new List<string>();
            HtmlWeb webDoc = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = webDoc.Load("https://studynow.ru/dicta/allwords");
            foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
            {
                foreach (HtmlNode row in table.SelectNodes("tr"))
                {
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {
                        if (!int.TryParse(cell.InnerText, out int ff))
                        {
                            var words = cell.InnerText.Split(new char[] { ',' });
                            wal.Add(words[0]);
                        }
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(stringConnectionBD))
            {
                for (int i = 0; i < 10000; i++)
                {
                    string eng = wal[i].ToString();
                    string rus = wal[i + 1].ToString();
                    SqlCommand cmd = new SqlCommand("INSERT INTO WORDS_ALL(sENG, sRUS, sDESCRIPTION, idStatus) VALUES(@sENG, @sRUS, @sDESCRIPTION, 3)", conn);
                    cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@sDESCRIPTION", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters["@sENG"].Value = eng;
                    cmd.Parameters["@sRUS"].Value = rus;
                    cmd.Parameters["@sDESCRIPTION"].Value = "";
                    conn.Open();
                    int RowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    i++;
                }
            }
        }

        private void lbl_favorite_Click(object sender, EventArgs e)
        {
            string textEng = "";
            string textRus = "";
            if (LanguagetText(lbl_RANDWORD.Text) == "eng")
            {
                textEng = lbl_RANDWORD.Text;
                textRus = "";
            }
            else
            {
                textEng = "";
                textRus = lbl_RANDWORD.Text;
            }
            SqlDataReader read;
            SqlConnection Con = new SqlConnection(stringConnectionBD);
            SqlCommand Cmd = new SqlCommand("SELECT * FROM WORDS WHERE sENG = @sENG OR sRUS = @sRUS", Con);
            Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters["@sENG"].Value = Convert.ToString(textEng);
            Cmd.Parameters["@sRUS"].Value = Convert.ToString(textRus);
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
            if (sEng != "" && sRus != "")
            {
                lbl_CORRECT.Text = "MSG: такое слово уже есть.";
                lbl_CORRECT.BackColor = Color.Orange;
                lbl_CORRECT.ForeColor = Color.Black;
            }
            else
            {
                SqlDataReader read1;
                SqlConnection Con1 = new SqlConnection(stringConnectionBD);
                SqlCommand Cmd1 = new SqlCommand("SELECT * FROM WORDS_ALL WHERE sENG = @sENG OR sRUS = @sRUS", Con1);
                Cmd1.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
                Cmd1.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
                Cmd1.Parameters["@sENG"].Value = Convert.ToString(textEng);
                Cmd1.Parameters["@sRUS"].Value = Convert.ToString(textRus);
                string sEng1 = "";
                string sRus1 = "";
                Con1.Open();
                read1 = Cmd1.ExecuteReader();
                while (read1.Read())
                {
                    object oEng1 = read1.GetValue(1);
                    object oRus1 = read1.GetValue(2);
                    sEng1 = Convert.ToString(oEng1);
                    sRus1 = Convert.ToString(oRus1);
                }

                SqlConnection Con2 = new SqlConnection(stringConnectionBD);
                SqlCommand Cmd2 = new SqlCommand("INSERT INTO WORDS (sENG,sRUS,sDESCRIPTION, idStatus) VALUES(@sENG, @sRUS, @sDESCRIPTION, 3)", Con2);

                Cmd2.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
                Cmd2.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
                Cmd2.Parameters.Add("@sDESCRIPTION", System.Data.SqlDbType.NVarChar);

                Cmd2.Parameters["@sENG"].Value = Convert.ToString(sEng1);
                Cmd2.Parameters["@sRUS"].Value = Convert.ToString(sRus1);
                Cmd2.Parameters["@sDESCRIPTION"].Value = "";

                Con2.Open();
                int RowsAffected = Cmd2.ExecuteNonQuery();
                Con2.Close();
                this.fullTableWordsTableAdapter.Fill(this.vocWordsDataSet.FullTableWords);
                lbl_CORRECT.Text = "MSG: добавил.";
                lbl_CORRECT.BackColor = Color.Orange;
                lbl_CORRECT.ForeColor = Color.Black;
            }


        }
        #endregion

        #region ADDITION
        private void btn_ADD_Click(object sender, EventArgs e)
        {
            string textENG = tb_ENG.Text;
            string textRUS = tb_RUS.Text;
            string textRUS2 = tb_RUS2.Text;
            string textRUS3 = tb_RUS3.Text;
            if (textENG != "" && textRUS != "")
            {
                if (ValidationAdd() == true)
                {
                    SqlConnection Con = new SqlConnection(stringConnectionBD);
                    SqlCommand Cmd = new SqlCommand("INSERT INTO WORDS (sENG,sRUS,sDESCRIPTION, idStatus,sRUS2, sRUS3 ) VALUES(@sENG, @sRUS, @sDESCRIPTION, 3, @sRUS2, @sRUS3)", Con);

                    Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
                    Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
                    Cmd.Parameters.Add("@sRUS2", System.Data.SqlDbType.NVarChar);
                    Cmd.Parameters.Add("@sRUS3", System.Data.SqlDbType.NVarChar);
                    Cmd.Parameters.Add("@sDESCRIPTION", System.Data.SqlDbType.NVarChar);

                    Cmd.Parameters["@sENG"].Value = Convert.ToString(tb_ENG.Text);
                    Cmd.Parameters["@sRUS"].Value = Convert.ToString(tb_RUS.Text);
                    Cmd.Parameters["@sRUS2"].Value = Convert.ToString(tb_RUS2.Text);
                    Cmd.Parameters["@sRUS3"].Value = Convert.ToString(tb_RUS3.Text);
                    Cmd.Parameters["@sDESCRIPTION"].Value = Convert.ToString(tb_DESCRIPTION.Text);

                    Con.Open();
                    int RowsAffected = Cmd.ExecuteNonQuery();
                    Con.Close();
                    this.fullTableWordsTableAdapter.Fill(this.vocWordsDataSet.FullTableWords);

                    tb_ENG.Text = "";
                    tb_RUS.Text = "";
                    tb_RUS2.Text = "";
                    tb_RUS3.Text = "";
                    tb_DESCRIPTION.Text = "";
                    lbl_LOG.Text = "Добавил!";
                }
            }
            else
            {
                lbl_LOG.Text = "Одно из полей не было заполненно";
            }
        }

        private void btn_FIND_Click(object sender, EventArgs e)
        {
            string textENG = tb_ENG.Text;
            string textRUS = tb_RUS.Text;
            string textRUS2 = tb_RUS2.Text;
            string textRUS3 = tb_RUS3.Text;
            if (textENG == "" && textRUS == "" && textRUS2 == "" && textRUS3 == "")
            {
                lbl_LOG.Text = "Заполните хотя бы одно поле.";
            }
            else
            {
                SqlDataReader read;
                SqlConnection Con = new SqlConnection(stringConnectionBD);
                SqlCommand Cmd = new SqlCommand("SELECT * FROM WORDS WHERE sENG = @sENG OR sRUS = @sRUS OR sRUS2 = @sRUS2 OR sRUS3 = @sRUS3", Con);
                Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
                Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
                Cmd.Parameters.Add("@sRUS2", System.Data.SqlDbType.NVarChar);
                Cmd.Parameters.Add("@sRUS3", System.Data.SqlDbType.NVarChar);
                Cmd.Parameters["@sENG"].Value = Convert.ToString(tb_ENG.Text);
                Cmd.Parameters["@sRUS"].Value = Convert.ToString(tb_RUS.Text);
                Cmd.Parameters["@sRUS2"].Value = Convert.ToString(tb_RUS2.Text);
                Cmd.Parameters["@sRUS3"].Value = Convert.ToString(tb_RUS3.Text);
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

                lbl_LOG.Text = string.Format("Английское слово: {0} | Русское слово: {1},{2},{3}", sEng, sRus, sRus2, sRus3);
                Con.Close();
                tb_ENG.Text = "";
                tb_RUS.Text = "";
                tb_RUS2.Text = "";
                tb_RUS3.Text = "";
                tb_DESCRIPTION.Text = "";
            }
        }

        public bool ValidationAdd()
        {
            bool valid;
            SqlDataReader read;
            SqlConnection Con = new SqlConnection(stringConnectionBD);
            SqlCommand Cmd = new SqlCommand("SELECT * FROM WORDS WHERE sENG = @sENG OR sRUS = @sRUS", Con);
            Cmd.Parameters.Add("@sENG", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters.Add("@sRUS", System.Data.SqlDbType.NVarChar);
            Cmd.Parameters["@sENG"].Value = Convert.ToString(tb_ENG.Text);
            Cmd.Parameters["@sRUS"].Value = Convert.ToString(tb_RUS.Text);
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
            Con.Close();
            if (sEng != "" && sRus != "")
            {
                valid = false;
                lbl_LOG.Text = string.Format("Такое слово уже есть! {0} | {1}", sEng, sRus);
            }
            else
            {
                valid = true;
            }
            return valid;

        }

        private void tb_ENG_Enter(object sender, EventArgs e)
        {
            original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            var language = InputLanguage.FromCulture(culture);
            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                InputLanguage.CurrentInputLanguage = language;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        private void tb_ENG_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = original;
        }


        #endregion

        private void label5_Click(object sender, EventArgs e)
        {
            var words = lbl_RANDWORD.Text.Split(new char[] { '(' });
            string text = words[0];
            SpeechSynthesizer speechSynth = new SpeechSynthesizer(); // создаём объект
            var voices = speechSynth.GetInstalledVoices(new CultureInfo("en-US"));


            // установить первый попавшийся
            speechSynth.SelectVoice(voices[0].VoiceInfo.Name); speechSynth.Speak(text); // озвучка женским 30-летним голосом
        }
    }
}
