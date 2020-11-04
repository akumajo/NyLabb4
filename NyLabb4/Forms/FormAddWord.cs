using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordLibrary;

namespace NyLabb4
{
    public partial class FormAddWord : Form
    {
        public WordList LoadedList { get; private set; }
        public event EventHandler AddWordButtonClicked;
        public FormAddWord()
        {
            InitializeComponent();
        }

        public void PrintLanguagesDataGrid(WordList loadedList)
        {
            SetupPrintLanguagesDataGrid();

            LoadedList = loadedList;

            for (int i = 0; i < loadedList.Languages.Length; i++)
            {
                dataGridView1.Rows.Add(loadedList.Languages[i].ToUpper());
                dataGridView1.Rows[i].ReadOnly = true;
            }
        }

        public void AddTranslationsDataGrid(WordList loadedList)
        {
            SetupTranslationDataGrid();

            for (int i = 0; i < loadedList.Languages.Length; i++)
            {
                dataGridView2.Rows.Add();
            }
        }

        private void buttonConfirmAdd_Click(object sender, EventArgs e)
        {
            AddWord();
        }

        private void AddWord()
        {
            Regex forbiddenChars = new Regex("[^A-Öa-ö]+");
            string[] translations = new string[LoadedList.Languages.Length];

            for (int i = 0; i < LoadedList.Languages.Length; i++)
            {
                if (dataGridView2.Rows[i].Cells[0].Value == null) { MessageBox.Show($"Missing one or more words."); return; }

                translations[i] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                translations[i] = forbiddenChars.Replace(translations[i], "").Trim();

                if (translations[i] == "")
                {
                    MessageBox.Show("Words can only contain characters from a-ö. Try again.", "Error");
                    return;
                }
            }

            LoadedList.Add(translations);
            LoadedList.Save();
            WordList.LoadList(LoadedList.Name);
            AddWordButtonClicked?.Invoke(this, null);
            Close();
        }

        private void SetupTranslationDataGrid()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView2.Columns.Add("Translation", "Translation");
        }

        private void SetupPrintLanguagesDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.Columns.Add("Language", "Language");
        }
    }
}