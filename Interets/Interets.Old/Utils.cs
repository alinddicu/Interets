using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.IO;

namespace Interets.New
{
    public class Utils
    {
        public const string VIRGULE = ",";
        public const string PARANTHESE_GAUCHE = "(";
        public const string PARANTHESE_DROITE = ")";
        public const string SIMPLE_QUOTE = "\'";
        public const string ESPACE = " ";
        public const string ANTISLASH = "\\";
        public const string RETOUR_CHARIOT = "\r\n";
        public const string DOUBLE_QUOTE = "\"";
        public const string NOUVELLE_LIGNE = "\n";
        public const string TABULATION = "\t";

        public const string SEPARATEUR_CHAINES_DATE = SEPARATEUR_SLASH;

        public const string SEPARATEUR_DOUBLE_QUOTE = "\"";
        public const string SEPARATEUR_SIMPLE_QUOTE = "'";
        public const string SEPARATEUR_SLASH = "/";
        public const string SEPARATEUR_ANTISLASH = @"\";
        public const string SEPARATEUR_POINT_VIRGULE = ";";
        public const string SEPARATEUR_VIRGULE = ",";
        public const string SEPARATEUR_POINT = ".";
        public const string SEPARATEUR_POURCENT = "%";
        public const string SEPARATEUR_EGAL = "=";
        public const string SEPARATEUR_PLUS = "+";
        public const string AROND_BASE = "@";

        public const string EXTENSION_EXCEL = "XLS";
        public const string EXTENSION_CSV = "csv";
        public const string MODELE_NOM_EXCEL = "E1234567.XLS";

        private const string PREFIX_ANNEE_2000 = "20";
        private const string FORMAT_DATE_GL_VALIDE = "1aammdd";

        public const string FORMATE_DATE_TXT = "{0:dd/MM/yyyy HH:mm:ss}";
        public const string FORMAT_DATE_jj_mm_aaaa = "jj/mm/aaaa";
        public const string FORMAT_DATE_yyyy_MM_dd = "{0:yyyyMMdd}";

        public static DateTime DATE_MIN = DateTime.MinValue;

        public static String RemoveDiacritics(String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString();
        }

        public static void MaximizeForm(Form form)
        {
            form.WindowState = FormWindowState.Maximized;
        }

        public static void SetFixedBorderWindow(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
        }

        public static void SetCheckedListCheckOnClick(CheckedListBox checkedListBox)
        {
            checkedListBox.CheckOnClick = true;
        }

        public static void SetBorderForm(Form form, FormBorderStyle borderStyle)
        {
            form.FormBorderStyle = borderStyle;
        }

        public static string ApplicationStartUpPath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }

        public static void CentrerForm(Form form)
        {
            form.Location = new System.Drawing.Point(
            System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - form.Width / 2,
            System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2 - form.Height / 2);
        }

        public static void SortirAplliSurInit(Form form, string message, string caption, MessageBoxButtons buttons)
        {
            DialogResult result =
                MessageBox.Show(form, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.RightAlign);

            if (result == DialogResult.OK)
            {
                Environment.Exit(1);
            }
        }

        public static string EncadrerParDoubleQuote(string chaine)
        {
            return DOUBLE_QUOTE + chaine + DOUBLE_QUOTE;
        }

        public static bool IsStringNonVide(string str)
        {
            return str != null && !String.Empty.Equals(str);
        }

        public static void RajouterColonneImage(DataGridView dataGridView, string nomCol, string iconeCol, string titreCol, int width, int displayIndex)
        {
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Name = nomCol;
            imageCol.HeaderText = titreCol;
            imageCol.Image = Image.FromFile(System.IO.Path.Combine(ApplicationStartUpPath(), iconeCol));
            imageCol.Resizable = DataGridViewTriState.False;
            imageCol.Width = width;
            imageCol.DisplayIndex = displayIndex;

            dataGridView.Columns.Add(imageCol);
        }

        public static void CheckUncheckCheckedList(CheckedListBox liste, bool check)
        {
            for (int i = 0; i < liste.Items.Count; i++)
            {
                liste.SetItemChecked(i, check);
            }
        }

        public static class Generator
        {
            private static Random _random = new Random();

            public static string RandomString(int size)
            {

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < size; i++)
                {
                    //26 letters in the alfabet, ascii + 65 for the capital letters
                    builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * _random.NextDouble() + 65))));

                }
                return builder.ToString();
            }
        }

        public static void RemplirDataGridView(DataGridView dataGridView, List<string> entetes, List<List<string>> donnees, string prefixNomColonne)
        {
            DataTable dt = new DataTable();

            for (int i = 0; i < entetes.Count; i++)
            {
                dt.Columns.Add(prefixNomColonne + i);
                dt.Columns[prefixNomColonne + i].ColumnName = entetes[i];
            }

            DataRow dr = null;
            for (int i = 0; i < donnees.Count; i++)
            {
                List<string> ligne = donnees[i];
                dr = dt.NewRow();

                for (int j = 0; j < ligne.Count; j++)
                {
                    dr[j] = ligne[j];
                }

                dt.Rows.Add(dr);
            }

            dataGridView.DataSource = dt;
        }

        public static List<string[]> parseCSV(string path, char separator)
        {
            List<string[]> parsedData = new List<string[]>();

            try
            {
                using (StreamReader readFile = new StreamReader(path))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(separator);
                        parsedData.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return parsedData;
        }

        public static string FormatterMsgNonInsert(string causeErr, string[] ligne)
        {
            return "Ligne non insérée à cause de " + causeErr + " pour la ligne '" + string.Join(SEPARATEUR_POINT_VIRGULE, ligne) + "'";
        }
    }
}
