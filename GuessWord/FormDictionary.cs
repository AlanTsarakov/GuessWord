using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWord
{
    public partial class FormDictionary : Form
    {
        string[] translatedWords;
        string[] words;
        public FormDictionary()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void FormDictionary_Load(object sender, EventArgs e)
        {
            string file2 = @"data\translatedWords.txt";
            if (File.Exists(file2))
            {
                string str = File.ReadAllText(file2);
                translatedWords = str.Split();
            }
            string file = @"data\words.txt";
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                words = str.Split();
            }
            dataGridViewDictionary.RowCount = translatedWords.Length;
            for (int i = 0; i < dataGridViewDictionary.RowCount; i++)
            {
                dataGridViewDictionary[0, i].Value = words[i];
                dataGridViewDictionary[1, i].Value = translatedWords[i];
            }

            if (FormMenu.lang == "russian")
            {
                this.Text = "Словарь";
                dataGridViewDictionary.Columns[0].HeaderText = "Cлово на осетинском";
                dataGridViewDictionary.Columns[1].HeaderText = "Слово на русском";

            }
            if (FormMenu.lang == "ossetian")
            {
                this.Text = "Дзырдуат";
                dataGridViewDictionary.Columns[0].HeaderText = "Дзырд иронау";
                dataGridViewDictionary.Columns[1].HeaderText = "Дзырд уырыссагау";
            }
        }

        private void dataGridViewDictionary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
