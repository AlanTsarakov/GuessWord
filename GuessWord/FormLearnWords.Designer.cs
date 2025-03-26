
namespace GuessWord
{
    partial class FormLearnWords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLearnWords));
            this.label = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNum = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(137, 232);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 32);
            this.label.TabIndex = 1;
            this.label.Text = "label";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(290, 456);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(12, 25);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(31, 32);
            this.labelNum.TabIndex = 4;
            this.labelNum.Text = "1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(92, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(273, 190);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // FormLearnWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(476, 507);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLearnWords";
            this.Text = "Изучаемые слова";
            this.Load += new System.EventHandler(this.FormLearnWords_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormLearnWords_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNum;
    }
}