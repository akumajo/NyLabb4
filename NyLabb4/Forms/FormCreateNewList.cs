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
    public partial class FormCreateNewList : Form
    {
        public event EventHandler AddNewList;
        public string ListName { get; private set; }
        string[] languages;
        public FormCreateNewList()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddNewList_Click(object sender, EventArgs e)
        {
            CreateNewList();
        }

        private void CreateNewList()
        {
            Regex forbiddenChars = new Regex("[^A-Öa-ö]+");
            languages = textBoxLanguages.Text.Split('\n');
            ListName = forbiddenChars.Replace(textBoxListName.Text, "").Trim();

            if (ListName == "" || languages.Length < 2)
            {
                MessageBox.Show("A list needs a proper name and atleast two translations.", "Error");
                return;
            }

            for (int i = 0; i < languages.Length; i++)
            {
                languages[i] = forbiddenChars.Replace(languages[i], "").Trim();
                if (languages[i] == "")
                {
                    MessageBox.Show("Languages can only contain characters from a-ö. Try again.", "Error");
                    return;
                }
            }

            WordList newList = new WordList(ListName, languages);
            newList.Save();
            AddNewList?.Invoke(this, null);

            MessageBox.Show($"{ListName} successfully created!");
            Close();
        }
    }
}
