using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordLibrary;
using System.Text.RegularExpressions;

namespace NyLabb4
{
    public partial class UserControlPrintSelectedList : UserControl
    {
        FormAddWord addWord = new FormAddWord();
        public event EventHandler ButtonStartPracticeClicked;
        public WordList LoadedList { get; private set; }
        public UserControlPrintSelectedList()
        {
            InitializeComponent();
            addWord.AddWordButtonClicked += FormAdd_AddWordButtonClicked;
        }

        public void PrintToDataGrid(WordList loadedList)
        {
            ResetDataGrid();
            if (loadedList == null) { return; }

            LoadedList = loadedList;
            LoadedList.List(0, ShowTranslation);
        }

        public void RemoveWord()
        {
            int index = dataGridView1.CurrentCell.ColumnIndex;
            string word = dataGridView1.CurrentCell.Value.ToString();

            DialogResult result = MessageBox.Show($"You're about to remove the word '{word}' from the list. \nContinue?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                LoadedList.Remove(index, word);
                LoadedList.Save();
                LoadedList = WordList.LoadList(LoadedList.Name);

                PrintToDataGrid(LoadedList);
            }
        }

        private void ResetDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ShowTranslation(string showTranslation)
        {
            string[] translation = showTranslation.Remove(showTranslation.LastIndexOf(';')).Split(';');

            if (dataGridView1.Columns.Count != LoadedList.Languages.Length)
            {
                for (int i = 0; i < LoadedList.Languages.Length; i++)
                {
                    dataGridView1.Columns.Add(translation[i], translation[i].ToUpper());
                }
            }
            else
            {
                dataGridView1.Rows.Add(translation);
            }
        }

        private void FormAdd_AddWordButtonClicked(object sender, EventArgs e)
        {
            PrintToDataGrid(LoadedList);
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            if (LoadedList == null) { return; }

            addWord.PrintDataGrids(LoadedList);
            addWord.ShowDialog();
        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            ButtonStartPracticeClicked?.Invoke(this, null);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (LoadedList == null) { return; }
            if (LoadedList.Count() < 1) { MessageBox.Show($"This list doesn't contain any words."); return; };

            RemoveWord();
        }

    }
}