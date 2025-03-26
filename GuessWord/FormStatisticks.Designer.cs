
namespace GuessWord
{
    partial class FormStatisticks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatisticks));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelGames = new System.Windows.Forms.Label();
            this.labelPercentOfWins = new System.Windows.Forms.Label();
            this.labelWins = new System.Windows.Forms.Label();
            this.labelAverageTime = new System.Windows.Forms.Label();
            this.labelCurrentStreak = new System.Windows.Forms.Label();
            this.labelBestStreak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(216, 348);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(494, 230);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // labelGames
            // 
            this.labelGames.AutoSize = true;
            this.labelGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGames.Location = new System.Drawing.Point(114, 92);
            this.labelGames.Name = "labelGames";
            this.labelGames.Size = new System.Drawing.Size(35, 38);
            this.labelGames.TabIndex = 1;
            this.labelGames.Text = "0";
            this.labelGames.Click += new System.EventHandler(this.labelGames_Click);
            // 
            // labelPercentOfWins
            // 
            this.labelPercentOfWins.AutoSize = true;
            this.labelPercentOfWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPercentOfWins.Location = new System.Drawing.Point(728, 92);
            this.labelPercentOfWins.Name = "labelPercentOfWins";
            this.labelPercentOfWins.Size = new System.Drawing.Size(35, 38);
            this.labelPercentOfWins.TabIndex = 2;
            this.labelPercentOfWins.Text = "0";
            // 
            // labelWins
            // 
            this.labelWins.AutoSize = true;
            this.labelWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWins.Location = new System.Drawing.Point(440, 91);
            this.labelWins.Name = "labelWins";
            this.labelWins.Size = new System.Drawing.Size(35, 38);
            this.labelWins.TabIndex = 3;
            this.labelWins.Text = "0";
            // 
            // labelAverageTime
            // 
            this.labelAverageTime.AutoSize = true;
            this.labelAverageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAverageTime.Location = new System.Drawing.Point(61, 212);
            this.labelAverageTime.Name = "labelAverageTime";
            this.labelAverageTime.Size = new System.Drawing.Size(143, 38);
            this.labelAverageTime.TabIndex = 4;
            this.labelAverageTime.Text = "00:00:00";
            // 
            // labelCurrentStreak
            // 
            this.labelCurrentStreak.AutoSize = true;
            this.labelCurrentStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentStreak.Location = new System.Drawing.Point(440, 212);
            this.labelCurrentStreak.Name = "labelCurrentStreak";
            this.labelCurrentStreak.Size = new System.Drawing.Size(35, 38);
            this.labelCurrentStreak.TabIndex = 5;
            this.labelCurrentStreak.Text = "0";
            this.labelCurrentStreak.Click += new System.EventHandler(this.labelCurrentStreak_Click);
            // 
            // labelBestStreak
            // 
            this.labelBestStreak.AutoSize = true;
            this.labelBestStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBestStreak.Location = new System.Drawing.Point(760, 212);
            this.labelBestStreak.Name = "labelBestStreak";
            this.labelBestStreak.Size = new System.Drawing.Size(35, 38);
            this.labelBestStreak.TabIndex = 6;
            this.labelBestStreak.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(199, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "#1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(199, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "#2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(199, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "#3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(199, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "#4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(199, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "#5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(199, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "#6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(301, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Распределение лучших попыток";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(371, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "🏆 Выиграно игр";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(720, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "📈 % Побед";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(63, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "🕹️ Всего игр";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(693, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "⚡️ Лучшая серия";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(371, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "🔥 Текущая серия";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(45, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "⭐ Среднее время";
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProfile.Location = new System.Drawing.Point(43, 9);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(167, 38);
            this.labelProfile.TabIndex = 22;
            this.labelProfile.Text = "Профиль:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "ТОП игроков";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormStatisticks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(978, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelBestStreak);
            this.Controls.Add(this.labelCurrentStreak);
            this.Controls.Add(this.labelAverageTime);
            this.Controls.Add(this.labelWins);
            this.Controls.Add(this.labelPercentOfWins);
            this.Controls.Add(this.labelGames);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStatisticks";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.FormStatisticks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label labelGames;
        private System.Windows.Forms.Label labelPercentOfWins;
        private System.Windows.Forms.Label labelWins;
        private System.Windows.Forms.Label labelAverageTime;
        private System.Windows.Forms.Label labelCurrentStreak;
        private System.Windows.Forms.Label labelBestStreak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Button button1;
    }
}