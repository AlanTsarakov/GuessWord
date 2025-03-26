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
    public partial class FormRating : Form
    {
        public FormRating()
        {
            InitializeComponent();
        }

        private void FormRating_Load(object sender, EventArgs e)
        {
            string[] quality;
            int j = 0;
            int l = FormMenu.users.Count();
            dataGridViewTop.RowCount = l;
            dataGridViewTop.ColumnCount = 3;




            foreach (var item in FormMenu.users)
            {
                
                string file = $@"users/{item}";
                if (File.Exists(file))
                {
                    dataGridViewTop[0, j].Value = item;
                    string str = File.ReadAllText(file);
                    quality = str.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                    for (int i = 1; i < 3; i++)
                    {
                        dataGridViewTop[i, j].Value = Convert.ToInt32(quality[i-1]);
                    }
                    j++;

                }
            }
            dataGridViewTop.Columns[2].ValueType = typeof(int);
            dataGridViewTop.Sort(dataGridViewTop.Columns[2], ListSortDirection.Descending);
            //for (int i = 0; i < l; i++)
            //{
            //    dataGridViewDictionary[0, i].Value = words[i];
            //    dataGridViewDictionary[1, i].Value = translatedWords[i];
            //}
            //dataGridViewDictionary.Sort(dataGridViewDictionar.Columns[0], ListSortDirection.Ascending);



            if (FormMenu.lang == "russian")
            {
                this.Text = "Словарь";
                dataGridViewTop.Columns[0].HeaderText = "Имя";
                dataGridViewTop.Columns[1].HeaderText = "Игр";
                dataGridViewTop.Columns[2].HeaderText = "Побед"; 

            }
            if (FormMenu.lang == "ossetian")
            {
                this.Text = "Дзырдуат";
                dataGridViewTop.Columns[0].HeaderText = "Ном";
                dataGridViewTop.Columns[1].HeaderText = "Хъӕзтытӕ";
                dataGridViewTop.Columns[2].HeaderText = "Уӕлахизтӕ";
            }
        }
    }
}
