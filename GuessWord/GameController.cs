using System;
using System.Collections.Generic;
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
        Form form = new Form();
        Label labelTime = new Label();

        public GameController(Form form)
        {
            this.form = form;
            form.Controls.Add(labelTime);

            ImportData();
            ImportProfile();
            NewWord();
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
