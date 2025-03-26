
namespace GuessWord
{
    partial class FormLearning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLearning));
            this.buttonIKnow = new System.Windows.Forms.Button();
            this.buttonIDontKnow = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCountLearned = new System.Windows.Forms.Label();
            this.comboBoxChapter = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDictCount = new System.Windows.Forms.Label();
            this.buttonDictionary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxWord = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIKnow
            // 
            this.buttonIKnow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIKnow.BackgroundImage")));
            this.buttonIKnow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIKnow.FlatAppearance.BorderSize = 0;
            this.buttonIKnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIKnow.Location = new System.Drawing.Point(35, 118);
            this.buttonIKnow.Name = "buttonIKnow";
            this.buttonIKnow.Size = new System.Drawing.Size(194, 149);
            this.buttonIKnow.TabIndex = 0;
            this.buttonIKnow.UseVisualStyleBackColor = true;
            this.buttonIKnow.Click += new System.EventHandler(this.buttonIKnow_Click);
            // 
            // buttonIDontKnow
            // 
            this.buttonIDontKnow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIDontKnow.BackgroundImage")));
            this.buttonIDontKnow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIDontKnow.FlatAppearance.BorderSize = 0;
            this.buttonIDontKnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIDontKnow.Location = new System.Drawing.Point(431, 118);
            this.buttonIDontKnow.Name = "buttonIDontKnow";
            this.buttonIDontKnow.Size = new System.Drawing.Size(194, 149);
            this.buttonIDontKnow.TabIndex = 1;
            this.buttonIDontKnow.UseVisualStyleBackColor = true;
            this.buttonIDontKnow.Click += new System.EventHandler(this.buttonIDontKnow_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(172, 7);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(122, 44);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.buttonIKnow);
            this.panel1.Controls.Add(this.buttonIDontKnow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 306);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.labelWord);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 74);
            this.panel2.TabIndex = 4;
            // 
            // labelCountLearned
            // 
            this.labelCountLearned.AutoSize = true;
            this.labelCountLearned.Location = new System.Drawing.Point(73, 63);
            this.labelCountLearned.Name = "labelCountLearned";
            this.labelCountLearned.Size = new System.Drawing.Size(16, 17);
            this.labelCountLearned.TabIndex = 6;
            this.labelCountLearned.Text = "0";
            // 
            // comboBoxChapter
            // 
            this.comboBoxChapter.FormattingEnabled = true;
            this.comboBoxChapter.Items.AddRange(new object[] {
            "Животные",
            "Предметы"});
            this.comboBoxChapter.Location = new System.Drawing.Point(528, 12);
            this.comboBoxChapter.Name = "comboBoxChapter";
            this.comboBoxChapter.Size = new System.Drawing.Size(123, 24);
            this.comboBoxChapter.TabIndex = 7;
            this.comboBoxChapter.SelectedIndexChanged += new System.EventHandler(this.comboBoxChapter_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.labelDictCount);
            this.panel3.Controls.Add(this.buttonDictionary);
            this.panel3.Controls.Add(this.labelCountLearned);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 107);
            this.panel3.TabIndex = 9;
            // 
            // labelDictCount
            // 
            this.labelDictCount.AutoSize = true;
            this.labelDictCount.Location = new System.Drawing.Point(144, 63);
            this.labelDictCount.Name = "labelDictCount";
            this.labelDictCount.Size = new System.Drawing.Size(16, 17);
            this.labelDictCount.TabIndex = 9;
            this.labelDictCount.Text = "0";
            // 
            // buttonDictionary
            // 
            this.buttonDictionary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDictionary.BackgroundImage")));
            this.buttonDictionary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDictionary.FlatAppearance.BorderSize = 0;
            this.buttonDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDictionary.Location = new System.Drawing.Point(95, 9);
            this.buttonDictionary.Name = "buttonDictionary";
            this.buttonDictionary.Size = new System.Drawing.Size(75, 71);
            this.buttonDictionary.TabIndex = 8;
            this.buttonDictionary.UseVisualStyleBackColor = true;
            this.buttonDictionary.Click += new System.EventHandler(this.buttonDictionary_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxWord
            // 
            this.pictureBoxWord.Location = new System.Drawing.Point(171, 129);
            this.pictureBoxWord.Name = "pictureBoxWord";
            this.pictureBoxWord.Size = new System.Drawing.Size(319, 300);
            this.pictureBoxWord.TabIndex = 2;
            this.pictureBoxWord.TabStop = false;
            // 
            // FormLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(663, 746);
            this.Controls.Add(this.comboBoxChapter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxWord);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLearning";
            this.Text = "Учиться";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIKnow;
        private System.Windows.Forms.Button buttonIDontKnow;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCountLearned;
        private System.Windows.Forms.ComboBox comboBoxChapter;
        private System.Windows.Forms.Button buttonDictionary;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDictCount;
        private System.Windows.Forms.PictureBox pictureBoxWord;
    }
}