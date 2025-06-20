﻿using System;
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
            labelProfile.Text += " " + FormMenu.User;
            labelGames.Text = " " + FormMenu.User.CountGames;
            labelWins.Text = " " + FormMenu.User.CountWins;
            //labelAverageTime.Text = " " + TimeSpan.FromSeconds(sumList(FormMain.timeList) / FormMain.countGames).ToString(@"h\:mm\:ss");
            labelBestStreak.Text = FormMenu.User.MaxStreak.ToString();
            labelCurrentStreak.Text = FormMenu.User.CurrentStreak.ToString();


            if (FormMenu.SettingsManager.Language == "russian")
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
            if (FormMenu.SettingsManager.Language == "ossetian")
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

            if (FormMenu.User.CountGames == 0)
            {
                labelPercentOfWins.Text = " " + 0 + "%";
            }
            else
            {
                labelPercentOfWins.Text = " " + (int)((double)FormMenu.User.CountWins / FormMenu.User.CountGames * 100)+"%";
            }

            chart.Series.Add(new Series("ColumnSeries")
            {
                ChartType = SeriesChartType.Bar
            });

            string steps = FormMenu.User.WinsForSteps;
            
            string[] WinsForSteps = { "Побед за 1 ход", "Побед за 2 ход", "Побед за 3 ход", "Побед за 4 ход", "Побед за 5 ход", "Побед за 6 ход"};
            double[] countWins = { countNumbers(steps, '0') / (double)FormMenu.User.CountGames *100, (double)countNumbers(steps, '1') / FormMenu.User.CountGames * 100, (double)countNumbers(steps, '2') / FormMenu.User.CountGames * 100, (double)countNumbers(steps, '3') / FormMenu.User.CountGames * 100, (double)countNumbers(steps, '4') / FormMenu.User.CountGames * 100, (double)countNumbers(steps, '5') / FormMenu.User.CountGames * 100 };
       

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
