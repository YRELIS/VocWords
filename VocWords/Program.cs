using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocWords
{
    static class Program
    {
       public static string stringConnectionBD = @"Data Source = DESKTOP-1K4LJJS\SQLEXPRESS; Initial Catalog = VocWords; Integrated Security = True";
       public static string commandSQLSelect_1 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
       public static string commandSQLSelect_2 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
       public static string commandSQLSelect_3 = "SELECT TOP 1 * FROM WORDS ORDER BY NEWID()";
       public static string commandSQLSelect_4 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
       public static string commandSQLSelect_5 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
       public static string commandSQLSelect_6 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 ORDER BY NEWID()";
       public static string commandSQLSelect_7 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
       public static string commandSQLSelect_8 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
       public static string commandSQLSelect_9 = "SELECT TOP 1 * FROM WORDS WHERE idStatus = 2 OR idStatus = 3 ORDER BY NEWID()";
       public static string commandSQLSelect_10 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS OR sRUS2 = @sRUS OR sRUS3 = @sRUS";
       public static string commandSQLSelect_11 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS";
       public static string commandSQLSelect_12 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS OR sRUS2 = @sRUS OR sRUS3 = @sRUS";
       public static string commandSQLSelect_13 = "SELECT * FROM WORDS WHERE sENG = @sENG AND sRUS = @sRUS";

       public static string commandSQLSelect_14 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 1";
       public static string commandSQLSelect_15 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 2";
       public static string commandSQLSelect_16 = "SELECT COUNT(*) FROM WORDS WHERE idStatus = 3";

       public static string commandSQLUpdate_1 = "UPDATE WORDS SET idStatus = @id WHERE sRUS = @word";
       public static string commandSQLUpdate_2 = "UPDATE WORDS SET idStatus = @id WHERE sENG = @word";
       public static string commandSQLUpdate_3 = "UPDATE WORDS SET idStatus = 3";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fSelection());
        }
    }
}
