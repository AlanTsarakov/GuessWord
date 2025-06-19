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
    
    public partial class FormMenu : Form
    {
        public static int easterEgg = 0;
        public static List<UserProfile> Users = new List<UserProfile>();
        public static UserProfile User;
        public static SettingsManager SettingsManager = new SettingsManager();
        string[] langList = new string[] { };


        public FormMenu()
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Users.Clear();
            if (File.Exists(@"settings/users.txt"))
            {
                string[] readText = File.ReadAllLines(@"settings/users.txt", Encoding.UTF8);
                foreach (var item in readText)
                {
                    Users.Add(new UserProfile(item));
                }
                foreach (var item in Users)
                {
                    comboBoxUsers.Items.Add(item.Name);
                }


            }





            using (StreamReader readtext = new StreamReader("settings/language.txt"))
            {
                SettingsManager.Language = readtext.ReadLine();
            }
            if (SettingsManager.Language == "russian")
            {
                this.Text = "Угадай слово";
                buttonPlay.Text = "Играть";
                buttonLearning.Text = "Учиться";
                buttonInformation.Text = "Об игре";
                button1.Text = "Выход";
                labelUser.Text = "Пользователь";
                langList = new string[] { "Введите имя пользователя!", "Такой пользователь уже существует!", "Вы уверены, что хотите удалить пользователя?", "Выберите профиль, который хотите удалить!", "Да", "Нет", "Ок" };
                label1.Text = "Введите имя пользователя";
                buttonPanelClose.Text = "Отмена";
                buttonAddUser.Text = "Добавить нового пользователя";
            }
            if (SettingsManager.Language == "ossetian")
            {
                this.Text = "Базон дзырд";
                buttonPlay.Text = "Хъазын";
                buttonLearning.Text = "Ахуыр кӕнын";
                buttonInformation.Text = "Хъазты тыххай";
                button1.Text = "Рахизӕн";
                labelUser.Text = "Хъазӕг";
                langList = new string[] { "Ныффыссут пайдагӕнӕджы ном!", "Ахӕм пайдагӕнӕг ныридӕгӕн ис!", "Бӕлвырд уӕ фӕнды пайдагӕнӕг аиуварс кӕнын?", "Равзарут, адде кӕнын уӕ цы профиль фӕнды, уый!", "О", "Наа", "Хорз"};
                label1.Text = "Пайдагӕнӕгӕн йӕ ном";
                buttonPanelClose.Text = "Фӕстӕмӕ";
                buttonAddUser.Text = "Ног пайдагӕнӕг бафтауын";
            }

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedItem == null || (comboBoxUsers.SelectedItem.ToString() == "Новый пользователь"))
            {
                MessageBox.Show(langList[0]);
            }
            else
            {
                User = new UserProfile(comboBoxUsers.SelectedItem.ToString());
                this.Visible = false;
                FormMain form = new FormMain();
                form.Location = this.Location;
                form.ShowDialog();
            }
            
        }
        
        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            buttonInformation.Visible = false;//сброс фокуса
            buttonInformation.Visible = true;
            TopMost = false;
            FormInformation info = new FormInformation();
            info.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            easterEgg++;
            if (easterEgg>100)
            {
                easterEgg = 0;
                FormEasterEgg form = new FormEasterEgg();
                form.Show();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
            
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (var user in Users)
            {
                if (user.Name == textBoxNewUser.Text)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                if (textBoxNewUser.Text != "")
                {
                    comboBoxUsers.Items.Clear();
                    Users.Add(new UserProfile(textBoxNewUser.Text));
                    comboBoxUsers.Items.AddRange(Users.ToArray());
                    comboBoxUsers.SelectedItem = textBoxNewUser.Text;

                    StreamWriter streamWriter = new StreamWriter(@"settings/users.txt");
                    foreach (var item in Users)
                    {
                        streamWriter.WriteLine(item.Name);
                    }
                    streamWriter.Close();
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show(langList[0]);
                }
                
            }
            else
            {
                MessageBox.Show(langList[1]);
            }
            
        }

        private void comboBoxUsers_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonPanelClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(langList[2], "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (comboBoxUsers.SelectedItem != null)
                {
                    File.Delete($@"users/{comboBoxUsers.SelectedItem}");

                    for (var i = 0; i < Users.Count; i++)
                    {
                        if (Users[i].Name == comboBoxUsers.SelectedItem.ToString())
                        {
                            Users.Remove(Users[i]);
                        }
                    }
                
                    comboBoxUsers.Text = "";
                    comboBoxUsers.Items.Clear();
                    comboBoxUsers.Items.AddRange(Users.ToArray());
                }
                else
                {
                    MessageBox.Show(langList[3]);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void buttonLearning_Click(object sender, EventArgs e)
        {
            FormLearning form = new FormLearning();
            form.ShowDialog();
        }
    }
}
