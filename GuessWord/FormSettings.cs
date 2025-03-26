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
    public partial class FormSettings : System.Windows.Forms.Form
    {
        string clavs;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

            LoadLanguageSettings();

            using (StreamReader readtext = new StreamReader("settings/keyboard.txt"))
            {
                clavs = readtext.ReadLine();
            }

            if (clavs == "on")
            {
                radioButtonClavOn.Checked = true;
            }
            if (clavs == "off")
            {
                radioButtonClavOff.Checked = true;
            }
        }

        void LoadLanguageSettings()
        {
            using (StreamReader readtext = new StreamReader("settings/language.txt"))
            {
                FormMenu.lang = readtext.ReadLine();
            }

            if (FormMenu.lang == "russian")
            {
                this.Text = "Настройки";
                labelLang.Text = "Выберите язык:";
                labelClavs.Text = "Клавитура:";
                radioButtonClavOn.Text = "Включить";
                radioButtonClavOff.Text = "Выключить";
                buttonRussian.FlatAppearance.BorderSize = 1;
                buttonOset.FlatAppearance.BorderSize = 0;
                buttonRussian.FlatAppearance.BorderColor = Color.Black;
                buttonSave.Text = "Сохранить";
                buttonClose.Text = "Отмена";
            }
            if (FormMenu.lang == "ossetian")
            {
                this.Text = "Нaтройкӕтӕ";
                labelLang.Text = "Равзар ӕвзаг:";
                labelClavs.Text = "Клавиатурӕ:";
                radioButtonClavOn.Text = "Скусын кӕнын";
                radioButtonClavOff.Text = "Ныххуысын кӕнын";
                buttonSave.Text = "Ныхъхъуыды кӕнын";
                buttonClose.Text = "Аивд";
                buttonOset.FlatAppearance.BorderSize = 1;
                buttonRussian.FlatAppearance.BorderSize = 0;
                buttonOset.FlatAppearance.BorderColor = Color.Black;
            }
        }
        private void buttonRussian_Click(object sender, EventArgs e)
        {
            FormMenu.lang = "russian";
            buttonOset.FlatAppearance.BorderSize = 0;
            buttonRussian.FlatAppearance.BorderSize = 1;
            buttonRussian.FlatAppearance.BorderColor = Color.Black;
            //this.Text = "Настройки";
            //labelLang.Text = "Выберите язык:";
            //labelClavs.Text = "Клавитура:";
            //radioButtonClavOn.Text = "Включить";
            //radioButtonClavOff.Text = "Выключить";

            //using (StreamWriter writetext = new StreamWriter("settings/language.txt"))
            //{
            //    writetext.WriteLine("russian");
            //}
            buttonRussian.BackColor = Color.Azure;
        }

        private void buttonOset_Click(object sender, EventArgs e)
        {
            FormMenu.lang = "ossetian";
            buttonOset.FlatAppearance.BorderSize = 1;
            buttonRussian.FlatAppearance.BorderSize = 0;
            buttonOset.FlatAppearance.BorderColor = Color.Black;
            //this.Text = "Нaтройкӕтӕ";
            //labelLang.Text = "Равзар ӕвзаг:";
            //labelClavs.Text = "Клавиатурӕ:";
            //radioButtonClavOn.Text = "Скусын кӕнын";
            //radioButtonClavOff.Text = "Ныххуысын кӕнын";

            //using (StreamWriter writetext = new StreamWriter("settings/language.txt"))
            //{
            //    writetext.WriteLine("ossetian");
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("settings/language.txt"))
            {
                writetext.WriteLine(FormMenu.lang);
                
            }

            using (StreamWriter writetext = new StreamWriter("settings/keyboard.txt"))
            {
                writetext.WriteLine(clavs);
            }
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonClavOff_CheckedChanged(object sender, EventArgs e)
        {
            clavs = "off";
        }

        private void radioButtonClavOn_CheckedChanged(object sender, EventArgs e)
        {
            clavs = "on";
        }

        private void radioButtonDictOn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
