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
    public partial class FormLearnWords : Form
    {
        List<string> words = FormLearning.learningWords;
        int currentWord = 0;
        int steps = 0;
        public FormLearnWords()
        {
            InitializeComponent();
            DrawWord(currentWord);
            
            button1.Visible = false;
            if (words.Count == 1)
            {
                buttonNext.Visible = false;
            }
        }
        void DrawWord(int currentWord)
        {
            pictureBox.BackgroundImage = Image.FromFile(@words[currentWord].Split('%')[2]);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            label.Text = words[currentWord].Split('%')[1];//+ " / " + words[currentWord].Split('%')[0];
            labelNum.Text = (currentWord + 1).ToString() + "/" + words.Count;
            buttonNext.Visible = true;
            button1.Visible = true;

        }
        private void FormLearnWords_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentWord + 1 < words.Count)
            {
                currentWord++;
                DrawWord(currentWord);
            }
            if (currentWord == words.Count-1)
            {
                buttonNext.Visible = false;
            }
  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        if (currentWord-1 >= 0 && currentWord < words.Count)
            {
                currentWord--;
                DrawWord(currentWord);
            }
        if (currentWord == 0)
            {
                button1.Visible = false;
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void FormLearnWords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            steps++;
            label.Text = words[currentWord].Split('%')[steps%2];
        }
    }
}
