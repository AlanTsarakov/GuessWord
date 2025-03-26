using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWord
{
    public partial class FormLearning : Form
    {
        List<List<string>> words = new List<List<string>>() { 
            new List<string>() { "ГОГЫЗ%ИНДЮК%images/words/word0.jpg", "УАСӔГ%ПЕТУХ%images/words/word1.jpg", "БАБЫЗ%УТКА%images/words/word2.jpg", "КУЫДЗ%СОБАКА%images/words/word3.jpg", "ХӔРӔГ%ОСЕЛ%images/words/word4.jpg", "РУВАС%ЛИСА%images/words/word5.jpg", "ХАЛОН%ВОРОНА%images/words/word6.jpg" },
            new List<string>() { "ЧЫРЫН%СУНДУК%images/words/word20.jpg", "ЦӔВӔГ%КОСА%images/words/word21.jpg", "САХАТ%ЧАСЫ%images/words/word22.jpg", "БАДӔН%СТУЛ%images/words/word23.jpg", "УИДЫГ%ЛОЖКА%images/words/word24.jpg" }
         };
        static public List<string> learningWords = new List<string>();
        static public List<string> dict = new List<string>();
        int currentWord = 0;
        int chapter = 0;

        public FormLearning()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawWord(currentWord);
        }

        void DrawWord(int currentWord)
        {
            pictureBoxWord.BackgroundImage = Image.FromFile(@words[chapter][currentWord].Split('%')[2]);
            pictureBoxWord.BackgroundImageLayout = ImageLayout.Stretch;
            labelWord.Text = words[chapter][currentWord].Split('%')[1] +" / "+ words[chapter][currentWord].Split('%')[0];


        }
        private void buttonIKnow_Click(object sender, EventArgs e)
        {
            var word = words[chapter][currentWord];
            if (!learningWords.Contains(word))
            {
                dict.Add(word);

            }
            else
            {
                MessageBox.Show("Вы уже добавили данное слово в словарь");
            }
            if (currentWord+1 < words[chapter].Count) {
               
                labelDictCount.Text = dict.Count().ToString();
                currentWord++;
                DrawWord(currentWord); 
            }
            else
            {
                MessageBox.Show("Вы изучили все слова в разделе!");
            }
        }

        private void buttonIDontKnow_Click(object sender, EventArgs e)
        {
            var word = words[chapter][currentWord];
            if (!learningWords.Contains(word))
            {
                learningWords.Add(word);

            }
            else
            {
                MessageBox.Show("Вы уже изучаете данное слово!");
            }
            if (currentWord + 1 < words[chapter].Count)
            {
                
                currentWord++;
                labelCountLearned.Text = learningWords.Count().ToString();
                DrawWord(currentWord);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (learningWords.Count != 0)
            {
                FormLearnWords form = new FormLearnWords();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Сначала выберите слова, которые хотели бы изучить!");
            }
        }

        private void comboBoxChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChapter.SelectedItem == "Животные")
            {
                chapter = 0;
                currentWord = 0;
                DrawWord(currentWord);
            }
            if (comboBoxChapter.SelectedItem == "Предметы")
            {
                chapter = 1;
                currentWord = 0;
                DrawWord(currentWord);
            }
        }

        private void buttonDictionary_Click(object sender, EventArgs e)
        {
            if (dict.Count != 0)
            {
                FormUserDict form = new FormUserDict();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Сначала выберите слова, которые вы уже знаете!");
            }
        }
    }
}
