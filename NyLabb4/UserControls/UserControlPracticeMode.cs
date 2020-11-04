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
using System.Reflection;

namespace NyLabb4
{
    public partial class UserControlPracticeMode : UserControl
    {
        PracticeGUI practice;
        public event EventHandler ButtonEndPracticeClicked;
        private WordList LoadedList;

        public UserControlPracticeMode()
        {
            InitializeComponent();
        }

        public void PracticeWords(WordList loadedList)
        {
            textBoxInputWord.Text = null;

            LoadedList = loadedList;
            var randomWord = LoadedList.GetWordToPractice();
            practice = new PracticeGUI(randomWord, loadedList);

            labelTranslateThisToThis.Text = practice.Play();
            labelShowHowManyWords.Text = practice.PrintTotalScore();
        }

        private void buttonEndpractice_Click(object sender, EventArgs e)
        {
            ButtonEndPracticeClicked?.Invoke(this, null);
        }

        private void textBoxInputWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            string userInput = textBoxInputWord.Text;
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                MessageBox.Show(practice.PrintRightorWrong(userInput));
                PracticeWords(LoadedList);
            }
        }
       
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            ResetPractice();
            PracticeWords(LoadedList);
        }

        public void ResetPractice()
        {
            PracticeGUI.AmountOfTotalGuesses = 0;
            PracticeGUI.AmountOfRightGuesses = 0;
        }
    }
}