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
    class GameController
    {
        
        static public int countGames;
        static public int currentStreak = 0;
        static public int maxStreak = 0;
        static public int countWins;
        static public string winsForSteps = "";
        static public List<int> timeList = new List<int>();
        Random rnd = new Random();
        int timerCounter = 0;
        static public string lang = "";

        int fullScreen = 0;
        string path = $@"users/{FormMenu.user}";
        int currentColumn = 0;
        Timer timer = new Timer();
        int currentRow = 0;
        int rightAnswer = 0;
        string word = "";
        string translatedWord;
        string[] words;
        string[] existWords;
        string[] translatedWords;
        char[,] field = new char[6, 5];
        string[] langList = new string[] { };
        Form form;
        Label labelTime = new Label();
        GameField dataGridViewWordsField = new GameField();

        public GameController(Form form)
        {
            this.form = form;
            form.Controls.Add(dataGridViewWordsField);
            form.Controls.Add(labelTime);
            form.KeyPress += Form_KeyPress;
            ImportData();
            ImportProfile();
            NewWord();
        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.InputLanguage.CurrentInputLanguage = System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
            if (e.KeyChar >= 'А' && e.KeyChar <= 'я' && currentColumn < 5)
            {
                timer.Start();
                field[currentRow, currentColumn] = Convert.ToChar(e.KeyChar.ToString().ToUpper());
                currentColumn++;
                DrawTable(field);
            }

            if (e.KeyChar == 'Ё' || e.KeyChar == 'ё' && currentColumn < 5)
            {
                field[currentRow, currentColumn] = 'Ӕ';
                currentColumn++;
                DrawTable(field);
            }

            if (e.KeyChar == 8 && currentColumn > 0 && currentColumn <= 5)//backspace
            {
                currentColumn--;
                field[currentRow, currentColumn] = ' ';
                DrawTable(field);
            }


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (currentColumn < 5)
                {
                    MessageBox.Show(langList[0]);
                }
                else
                {
                    if (countRightAnswers() == 5)
                    {
                        toColor();
                        MessageBox.Show(langList[1] + translatedWord);
                        currentStreak++;
                        if (currentStreak > maxStreak)
                            maxStreak = currentStreak;
                        winsForSteps += currentRow;
                        countGames++;
                        countWins++;
                        newGame();


                    }
                    else
                    {
                        if (isExistingWord())
                        {
                            if (currentRow == 5)
                            {
                                toColor();
                                MessageBox.Show(langList[2] + word + langList[3] + translatedWord);
                                if (currentStreak > maxStreak)
                                    maxStreak = currentStreak;
                                currentStreak = 0;
                                countGames++;
                                newGame();

                            }
                            else
                            {
                                toColor();
                                currentColumn = 0;
                                currentRow += 1;
                            }
                        }
                        else
                        {
                            MessageBox.Show(langList[4]);
                        }
                    }
                }
            }
        }


        void DrawTable(char[,] field)
        {

            for (int row = 0; row < 6; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    dataGridViewWordsField[column, row].Value = field[row, column];
                }
            }
            for (int i = 0; i < 6; i++)
            {
                DataGridViewRow row = dataGridViewWordsField.Rows[i];
                int width = dataGridViewWordsField.Width / 6;
                row.MinimumHeight = width;
            }
        }
        void newWord()
        {
            int n = rnd.Next(words.Length);
            word = words[n];
            translatedWord = translatedWords[n];
        }
        void newGame()
        {
            currentColumn = 0;
            currentRow = 0;
            field = new char[6, 5];
            dataGridViewWordsField.Rows.Clear();
            dataGridViewWordsField.RowCount = 6;
            newWord();
            DrawTable(field);
            timeList.Add(timerCounter);
            timerCounter = 0;
            labelTime.Text = "0:00:00";
            timer.Stop();

            string stringTime = string.Join("#", timeList.ToArray());

            string[] createText = { countGames.ToString(), countWins.ToString(), currentStreak.ToString(), maxStreak.ToString(), winsForSteps, stringTime };
            File.WriteAllLines(path, createText, Encoding.UTF8);
        }
        bool isExistingWord()
        {
            string enteredWord = "";

            for (int i = 0; i < 5; i++)
            {
                enteredWord += field[currentRow, i];
            }

            if (existWords.Contains(enteredWord))
            {
                return true;
            }
            else
                return false;
        }//проверка на сушествование слова
        int countRightAnswers()
        {

            rightAnswer = 0;

            for (int k = 0; k < 5; k++)
            {
                if (field[currentRow, k] == word[k])
                {
                    rightAnswer++;
                }

            }
            return rightAnswer;
        }
        void toColor()
        {
            if (currentColumn == 5)
            {

                for (int i = 0; i < 5; i++)
                {
                    dataGridViewWordsField[i, currentRow].Style.BackColor = Color.DimGray;
                }

                int[] mas = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = i; j < 5; j++)
                    {
                        if (word[i] == word[j])
                        {
                            mas[i]++;
                        }
                    }
                }

                for (int k = 0; k < 5; k++)
                {
                    if (Convert.ToChar(dataGridViewWordsField[k, currentRow].Value) == word[k])
                    {
                        mas[k] = mas[k] - 1;
                    }

                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((word[i] == Convert.ToChar(dataGridViewWordsField[j, currentRow].Value) && (mas[i] > 0)))
                        {
                            dataGridViewWordsField[j, currentRow].Style.BackColor = Color.Orange;
                            mas[i] = mas[i] - 1;
                        }
                    }
                }
                for (int k = 0; k < 5; k++)
                {
                    if (Convert.ToChar(dataGridViewWordsField[k, currentRow].Value) == word[k])
                    {
                        dataGridViewWordsField[k, currentRow].Style.BackColor = Color.Green;
                    }

                }
            }
        }
        void ImportData()
        {
            string file1 = @"data\existWords.txt";
            if (File.Exists(file1))
            {
                string str = File.ReadAllText(file1);
                existWords = str.Split();
            }

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
        }
        void ImportProfile()
        {
            if (File.Exists(path))
            {
                string[] readText = File.ReadAllLines(path, Encoding.UTF8);
                countGames = Convert.ToInt32(readText[0]);
                countWins = Convert.ToInt32(readText[1]);
                currentStreak = Convert.ToInt32(readText[2]);
                maxStreak = Convert.ToInt32(readText[3]);
                winsForSteps = readText[4];
                string[] arrayTime = readText[5].Split('#');
                timeList.Clear();
                foreach (var item in arrayTime)
                {
                    timeList.Add(Convert.ToInt32(item));
                }
            }
            else
            {
                countGames = 0;
                countWins = 0;
                currentStreak = 0;
                maxStreak = 0;
                winsForSteps = "";
            }
        }
        public void CreateNewTime()
        {

            timer.Interval = 1000; //интервал между срабатываниями 1000 миллисекунд
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = TimeSpan.FromSeconds(++timerCounter).ToString(@"h\:mm\:ss");
        }

        void NewWord()
        {
            int n = rnd.Next(words.Length);
            word = words[n];
            translatedWord = translatedWords[n];
        }
    }
}
