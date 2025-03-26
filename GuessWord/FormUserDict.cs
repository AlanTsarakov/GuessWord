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
    public partial class FormUserDict : Form
    {
        List<string> words = FormLearning.dict;
        public FormUserDict()
        {
            InitializeComponent();
            dataGridViewDict.Dock = DockStyle.Fill;

            // Добавление столбцов
            dataGridViewDict.Columns.Add("ColumnOssetian", "Слово на осетинском"); // Заголовок на осетинском
            dataGridViewDict.Columns.Add("ColumnRussian", "Слово на русском"); // Заголовок на русском
            dataGridViewDict.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDict.Columns[0].FillWeight = 50; // Первый столбец занимает 50% ширины
            dataGridViewDict.Columns[1].FillWeight = 50; // Второй столбец занимает 50% ширины

            // Запрет изменения размеров столбцов и строк
            dataGridViewDict.AllowUserToResizeColumns = false;
            dataGridViewDict.AllowUserToResizeRows = false;

            // Запрет изменения размеров заголовков
            dataGridViewDict.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDict.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void FormUserDict_Load(object sender, EventArgs e)
        {
            dataGridViewDict.RowCount = words.Count;
            dataGridViewDict.ColumnCount = 2;
            for (int i = 0; i < words.Count; i++)
            {
                dataGridViewDict[0, i].Value = words[i].Split('%')[0];
                dataGridViewDict[1, i].Value = words[i].Split('%')[1];
            }
            
        }

        private void dataGridViewDict_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
