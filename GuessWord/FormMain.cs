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
    
    public partial class FormMain : System.Windows.Forms.Form
    {
       
        static public List<int> timeList = new List<int>();
        int timerCounter = 0;
        int fullScreen = 0;
        int currentColumn = 0;
        Timer timer = new Timer();

        WordManager wordManager = new WordManager();

        int currentRow = 0;
        int rightAnswer = 0;
        char[,] field = new char[6, 5];
        
        string[] langList = new string[] { };


        public FormMain()
        {
            InitializeComponent();

            createNewTime();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            toolTipFullScreen.SetToolTip(buttonFullScreen, "F11");

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormMain_KeyDown);



            

            FormMenu.User.ImportProfile();

            wordManager.ImortData();
            wordManager.NewWord();
        }
        void loadClavsSettings()
        {
            string clavs;
            using (StreamReader readtext = new StreamReader("settings/keyboard.txt"))
            {
                clavs = readtext.ReadLine();
            }
            if (clavs == "on")
                panelKeyboard.Visible = true;
            else
                panelKeyboard.Visible = false;

        }
        
        //void importProfile()
        //{
        //    if (File.Exists(path))
        //    {
        //        string[] readText = File.ReadAllLines(path, Encoding.UTF8);
        //        FormMenu.User.CountGames = Convert.ToInt32(readText[0]);
        //        FormMenu.User.CountWins = Convert.ToInt32(readText[1]);
        //        FormMenu.User.CurrentStreak = Convert.ToInt32(readText[2]);
        //        FormMenu.User.MaxStreak = Convert.ToInt32(readText[3]);
        //        FormMenu.User.WinsForSteps = readText[4];
        //        string[] arrayTime = readText[5].Split('#');
        //        timeList.Clear();
        //        foreach (var item in arrayTime)
        //        {
        //            timeList.Add(Convert.ToInt32(item));
        //        }
        //    }
        //    else
        //    {
        //        FormMenu.User.CountGames = 0;
        //        FormMenu.User.CountWins = 0;
        //        FormMenu.User.CurrentStreak = 0;
        //        FormMenu.User.MaxStreak = 0;
        //        FormMenu.User.WinsForSteps = "";
        //    }
        //}
        private void FormMain_Load(object sender, EventArgs e)
        {

            panelKeyboard.BorderStyle = BorderStyle.None;


           
            timer.Stop();

            
            dataGridViewWordsField.RowCount = 6;
            //LoadLanguageSettings();
            LoadLanguageSettings();
            LoadKeyboardSettings();
            loadClavsSettings();

            int width = dataGridViewWordsField.Width / 6;
            for (int i = 0; i < 6; i++)
            {
                DataGridViewRow row = dataGridViewWordsField.Rows[i];
                
                row.MinimumHeight = width;
            }
            dataGridViewWordsField.Height = width * 6+3;
            System.Windows.Forms.InputLanguage.CurrentInputLanguage = System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
        }




        public void LoadLanguageSettings()
        {
        
            if (FormMenu.SettingsManager.Language == "russian")
            {
                this.Text = "Угадай слово";
                toolTipFullScreen.ToolTipTitle = "Полноэкранный режим";
                langList = new string[] { "Букв меньше, чем надо", "Вы выиграли! Перевод слова: ", "Вы проиграли! Загаданное слово: ", ". Перевод: ", "Такого слова не существует! Если вы считаете, что это не так, то, пожалуйста, пишите на почту alantsarakov@vk.com", "Вы ещё не сыграли!" };

            }
            if (FormMenu.SettingsManager.Language == "ossetian")
            {
                this.Text = "Базон дзырд";
                toolTipFullScreen.ToolTipTitle = "Анахъан экран режим";
                langList = new string[] { "Дамгъӕтӕ, цас хъӕуы, уымӕй къаддӕр сты!", "Рамбылдтат! Дзырды тӕлмац: ", "Фембылды стут! Дзырд уырыссагау: ", ". Тӕлмац: ", "Ахӕм дзырд нӕй! Кӕд дӕм афтӕ нӕ кӕсы, уӕд, табуафси, фысс почтӕмӕ alantsarakov@vk.com", "Нӕма ахъазыдыстут!" };
            }
        }

        void LoadKeyboardSettings()
        {
            string clavs;
            using (StreamReader readtext = new StreamReader("settings/keyboard.txt"))
            {
                clavs = readtext.ReadLine();
            }
            if (clavs == "on")
                panelKeyboard.Visible = true;
            if (clavs == "off")
                panelKeyboard.Visible = false;
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



        public void createNewTime()
        {
            
            timer.Interval = 1000; //интервал между срабатываниями 1000 миллисекунд
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        


        void newGame()
        {
            currentColumn = 0;
            currentRow = 0;
            field = new char[6, 5];
            dataGridViewWordsField.Rows.Clear();
            dataGridViewWordsField.RowCount = 6;
            wordManager.NewWord();
            DrawTable(field);
            timeList.Add(timerCounter);
            timerCounter = 0;
            labelTime.Text = "0:00:00";
            timer.Stop();

            string stringTime = string.Join("#", timeList.ToArray());

            FormMenu.User.ExportProfile();
        }



        bool isExistingWord()
        {
            string enteredWord = "";

            for (int i = 0; i < 5; i++)
            {
                enteredWord += field[currentRow, i];
            }

            if (wordManager.ExistWords.Contains(enteredWord))
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
                if (field[currentRow, k] == wordManager.Word[k])
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
                        if (wordManager.Word[i] == wordManager.Word[j])
                        {
                            mas[i]++;
                        }
                    }
                }
                
                for (int k = 0; k < 5; k++)
                {
                    if (Convert.ToChar(dataGridViewWordsField[k, currentRow].Value) == wordManager.Word[k])
                    {
                        mas[k]=mas[k]-1;
                    }

                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((wordManager.Word[i] == Convert.ToChar(dataGridViewWordsField[j, currentRow].Value) && (mas[i] > 0)))
                        {
                            dataGridViewWordsField[j, currentRow].Style.BackColor = Color.Orange;
                            mas[i] = mas[i] - 1;
                        }
                    }
                }
                for (int k = 0; k < 5; k++)
                {
                    if (Convert.ToChar(dataGridViewWordsField[k, currentRow].Value) == wordManager.Word[k])
                    {
                        dataGridViewWordsField[k, currentRow].Style.BackColor = Color.Green;
                    }
                    
                }
            }
        }
        private void dataGridViewWordsField_KeyPress(object sender, KeyPressEventArgs e)
        { 
            
        }

        private void dataGridViewWordsField_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridViewWordsField.ClearSelection();
        }

        private void dataGridViewWordsField_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }




        private void buttonFullScreen_Click(object sender, EventArgs e)
        {
            
            fullScreen++;
            if (fullScreen%2!=0) 
            { 
                TopMost = true;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                int width = dataGridViewWordsField.Width;
                for (int i = 0; i < dataGridViewWordsField.ColumnCount; i++)
                {
                    dataGridViewWordsField.Rows[i].Height = width / dataGridViewWordsField.ColumnCount;
                    dataGridViewWordsField.RowTemplate.MinimumHeight = width*6;
                }

            }
            else
            {
                TopMost = false;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                WindowState = FormWindowState.Normal;
                int width = dataGridViewWordsField.Width;
                for (int i = 0; i < dataGridViewWordsField.ColumnCount; i++)
                {
                    DataGridViewColumn column = dataGridViewWordsField.Columns[i];
                    column.Width = width / dataGridViewWordsField.ColumnCount ;
                    
                }
               

            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                fullScreen++;
                if (fullScreen % 2 != 0)
                {
                    TopMost = true;
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    int width = dataGridViewWordsField.Width;
                    for (int i = 0; i < dataGridViewWordsField.ColumnCount; i++)
                    {
                        dataGridViewWordsField.Rows[i].Height = width / dataGridViewWordsField.ColumnCount;
                        dataGridViewWordsField.RowTemplate.MinimumHeight = 400;
                    }

                }
                else
                {
                    TopMost = false;
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    WindowState = FormWindowState.Normal;
                    int width = dataGridViewWordsField.Width;
                    for (int i = 0; i < dataGridViewWordsField.ColumnCount; i++)
                    {
                        DataGridViewColumn column = dataGridViewWordsField.Columns[i];
                        column.Width = width / dataGridViewWordsField.ColumnCount;

                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTipSettings_Popup(object sender, PopupEventArgs e)
        {

        }

        private void labelGameName_Click(object sender, EventArgs e)
        {

        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            timer.Start();
            Button button = (Button)sender;
            button.Visible = false;//сброс фокуса
            button.Visible = true;
            if (currentColumn < 5)
            {
                field[currentRow, currentColumn] = Convert.ToChar(button.Text);
                currentColumn++;
                DrawTable(field);
            }
            
        }



        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            buttonBackspace.Visible = false;//сброс фокуса
            buttonBackspace.Visible = true;

            if (currentColumn > 0 && currentColumn <= 5)//backspace
            {
                currentColumn--;
                field[currentRow, currentColumn] = ' ';
                DrawTable(field);
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (currentColumn < 5)
            {
                MessageBox.Show(langList[0]);
                //FormMessage form = new FormMessage("Букв меньше, чем надо");
                //form.ShowDialog();
            }
            else
            {
                if (countRightAnswers() == 5)//enter
                {
                    timer.Stop();
                    toColor();
                    MessageBox.Show(langList[1] + wordManager.Word);
                    FormMenu.User.CurrentStreak++;
                    if (FormMenu.User.CurrentStreak > FormMenu.User.MaxStreak)
                        FormMenu.User.MaxStreak = FormMenu.User.CurrentStreak;

                    FormMenu.User.WinsForSteps += currentRow;
                    FormMenu.User.CountGames++;
                    FormMenu.User.CountWins++;
                    newGame();

                }
                else
                {
                    if (isExistingWord())
                    {
                        if (currentRow == 5)
                        {
                            toColor();
                            timer.Stop();
                            MessageBox.Show(langList[2] + wordManager.Word + langList[3] + wordManager.TranslatedWord);
                            if (FormMenu.User.CurrentStreak > FormMenu.User.MaxStreak)
                                FormMenu.User.MaxStreak = FormMenu.User.CurrentStreak;
                            FormMenu.User.CurrentStreak = 0;
                            newGame();
                            FormMenu.User.CountGames++;
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

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            buttonSettings.Visible = false;//сброс фокуса
            buttonSettings.Visible = true;
            //string lang;
            //string clavs;
            TopMost = false;
            FormSettings settings = new FormSettings();
            settings.ShowDialog();
            //using (StreamReader readtext = new StreamReader("settings/language.txt"))
            //{
            //    lang = readtext.ReadLine();
            //}
            //if (lang == "russian")
            //{
            //    this.Text = "Угадай слово";
            //    labelGameName.Text = "Угадай слово";
            //}
            //else
            //{     
            //    this.Text = "Базон дзырд";
            //    labelGameName.Text = "Базон дзырд";
            //}
            LoadLanguageSettings();
            //using (StreamReader readtext = new StreamReader("settings/keyboard.txt"))
            //{
            //    clavs = readtext.ReadLine();
            //}
            //if (clavs == "on")
            //    panelKeyboard.Visible = true;
            //else
            //    panelKeyboard.Visible = false;
            LoadKeyboardSettings();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDictionary_Click(object sender, EventArgs e)
        {
            buttonDictionary.Visible = false; //сброс фокуса
            buttonDictionary.Visible = true;
            FormDictionary form = new FormDictionary();
            form.ShowDialog();
        }

        private void dataGridViewWordsField_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
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
                        MessageBox.Show(langList[1] + wordManager.TranslatedWord);
                        FormMenu.User.CurrentStreak++;
                        if (FormMenu.User.CurrentStreak > FormMenu.User.MaxStreak)
                            FormMenu.User.MaxStreak = FormMenu.User.CurrentStreak;
                        FormMenu.User.WinsForSteps += currentRow;
                        FormMenu.User.CountGames++;
                        FormMenu.User.CountWins++;
                        newGame();


                    }
                    else
                    {
                        if (isExistingWord())
                        {
                            if (currentRow == 5)
                            {
                                toColor();
                                MessageBox.Show(langList[2]+ wordManager.Word + langList[3] + wordManager.TranslatedWord);
                                if (FormMenu.User.CurrentStreak > FormMenu.User.MaxStreak)
                                    FormMenu.User.MaxStreak = FormMenu.User.CurrentStreak;
                                FormMenu.User.CurrentStreak = 0;
                                FormMenu.User.CountGames++;
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
            buttonSettings.Visible = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            buttonStatistics.Visible = false;
            buttonStatistics.Visible = true;
            if (FormMenu.User.CountGames > 0)
            {
                FormStatisticks form = new FormStatisticks();
                form.Show();
                
            }
            else
            {
                MessageBox.Show(langList[5]);
            }
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //labelTime.Text = (++timerCounter).ToString();
            labelTime.Text = TimeSpan.FromSeconds(++timerCounter).ToString(@"h\:mm\:ss");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMenu menu = new FormMenu();
            menu.Show();

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
