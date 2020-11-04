using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordLibrary;

namespace NyLabb4
{
    public partial class FormMain : Form
    {
        UserControlPrintSelectedList printSelectedList = new UserControlPrintSelectedList();
        UserControlPracticeMode practiceMode = new UserControlPracticeMode();
        FormLoadLists loadList = new FormLoadLists();
        FormAddWord addWord = new FormAddWord();
        WordList LoadedList;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AddEvents();
            PanelSetup();
            loadList.ShowDialog();
            ShowWordList(LoadedList);
        }

        private void loadList_ButtonSelectClicked(object sender, EventArgs e)
        {
            LoadedList = loadList.LoadedList;
            ShowWordList(LoadedList);
        }

        private void practiceMode_ButtonEndPracticeClicked(object sender, EventArgs e)
        {
            ShowWordList(LoadedList);
        }

        private void printSelectedList_ButtonStartPracticeClicked(object sender, EventArgs e)
        {
            if (LoadedList == null) { return; }
            if (LoadedList.Count() < 1) { MessageBox.Show($"This list doesn't contain any words."); return; }
            ShowPracticeMode(LoadedList);
        }

        private void PanelSetup()
        {
            panel1.Controls.Add(printSelectedList);
            panel1.Controls.Add(practiceMode);
            printSelectedList.Dock = DockStyle.Fill;
            practiceMode.Dock = DockStyle.Fill;
        }

        private void AddEvents()
        {
            loadList.ButtonSelectClicked += loadList_ButtonSelectClicked;
            printSelectedList.ButtonStartPracticeClicked += printSelectedList_ButtonStartPracticeClicked;
            practiceMode.ButtonEndPracticeClicked += practiceMode_ButtonEndPracticeClicked;
        }

        private void ShowPracticeMode(WordList LoadedList)
        {
            practiceMode.ResetPractice();
            practiceMode.PracticeWords(LoadedList);

            printSelectedList.Visible = false;
            practiceMode.Visible = true;
        }

        private void ShowWordList(WordList loadedList)
        {
            printSelectedList.PrintToDataGrid(loadedList);

            printSelectedList.Visible = true;
            practiceMode.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wikihow.com/Use-a-Dictionary");
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedList == null) { return; }
            addWord.PrintLanguagesDataGrid(LoadedList);
            addWord.AddTranslationsDataGrid(LoadedList);
            addWord.ShowDialog();
            ShowWordList(LoadedList);
        }

        private void deleteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadedList == null) { return; }
            printSelectedList.RemoveWord();
            ShowWordList(LoadedList);
        }

        private void createNewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateNewList createNew = new FormCreateNewList();
            createNew.ShowDialog();
            if(createNew.ListName != null)
            {
                LoadedList = WordList.LoadList(createNew.ListName);
                ShowWordList(LoadedList);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadList.ShowDialog();
        }

    }
}