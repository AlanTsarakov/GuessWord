using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace GuessWord
{

    public partial class FormStatisticks : Form
    {
        public FormStatisticks()
        {
            InitializeComponent();
        }
        int countNumbers(string a, char b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    count++;
                }
            }
            return count;
        }


        int sumList(List<int> l)
        {
            int sum = 0;
            foreach (var item in l)
            {
                sum += item;
            }
            return sum;
        }
        private void FormStatisticks_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            labelProfile.Text += " " + FormMenu.user;
            labelGames.Text = " " + FormMain.countGames;
            labelWins.Text = " " + FormMain.countWins;
            labelAverageTime.Text = " " + TimeSpan.FromSeconds(sumList(FormMain.timeList) / FormMain.countGames).ToString(@"h\:mm\:ss");
            labelBestStreak.Text = FormMain.maxStreak.ToString();
            labelCurrentStreak.Text = FormMain.currentStreak.ToString();


            if (FormMenu.lang == "russian")
            {
                label10.Text = "🕹️ Всего игр";
                label2.Text = "🏆 Выиграно игр";
                label9.Text = "📈 % Побед";
                label1.Text = "Распределение лучших попыток";
                label13.Text = "⭐ Среднее время";
                label12.Text = "🔥 Текущая серия";
                label11.Text = "⚡️ Лучшая серия";
                button1.Text = "ТОП игроков";
            }
            if (FormMenu.lang == "ossetian")
            {
                label10.Text = "🕹 Ӕдӕппӕт хъӕзтытӕ";
                label2.Text = "🏆 Рамбылдта хъӕзтытӕ";
                label9.Text = "📈 % Уӕлахизты";
                label1.Text = "Хуыздӕр фӕлтӕрӕнты байуӕрст";
                label13.Text = "⭐ Рӕстӕмбис рӕстӕг";
                label12.Text = "🔥 Цӕугӕ сери";
                label11.Text = "⚡️ Хуыздӕр сери";
                button1.Text = "Хуыздӕр хъазджытӕ";
            }

            if (FormMain.countGames == 0)
            {
                labelPercentOfWins.Text = " " + 0 + "%";
            }
            else
            {
                labelPercentOfWins.Text = " " + (int)((double)FormMain.countWins / FormMain.countGames * 100)+"%";
            }

            chart.Series.Add(new Series("ColumnSeries")
            {
                ChartType = SeriesChartType.Bar
            });

            string steps = FormMain.winsForSteps;
            
            string[] WinsForSteps = { "Побед за 1 ход", "Побед за 2 ход", "Побед за 3 ход", "Побед за 4 ход", "Побед за 5 ход", "Побед за 6 ход"};
            double[] countWins = { countNumbers(steps, '0') / (double)FormMain.countGames*100, (double)countNumbers(steps, '1') / FormMain.countGames * 100, (double)countNumbers(steps, '2') / FormMain.countGames * 100, (double)countNumbers(steps, '3') / FormMain.countGames * 100, (double)countNumbers(steps, '4') / FormMain.countGames * 100, (double)countNumbers(steps, '5') / FormMain.countGames * 100 };
       

            chart.Series["ColumnSeries"].Points.DataBindXY(WinsForSteps, countWins);
            chart.Series["ColumnSeries"]["PieLabelStyle"] = "Disabled";
            chart.Series["ColumnSeries"].IsVisibleInLegend = false;
            chart.ChartAreas[0].AxisY.Maximum = 100;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            //chart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void labelCurrentStreak_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRating f = new FormRating();
            f.ShowDialog();
        }

        private void labelGames_Click(object sender, EventArgs e)
        {

        }
    }
}
