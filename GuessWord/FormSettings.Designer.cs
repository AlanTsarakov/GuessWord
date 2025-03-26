
namespace GuessWord
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.labelLang = new System.Windows.Forms.Label();
            this.radioButtonClavOn = new System.Windows.Forms.RadioButton();
            this.radioButtonClavOff = new System.Windows.Forms.RadioButton();
            this.labelClavs = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOset = new System.Windows.Forms.Button();
            this.buttonRussian = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLang.Location = new System.Drawing.Point(12, 133);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(225, 36);
            this.labelLang.TabIndex = 0;
            this.labelLang.Text = "Равзар ӕвзаг:";
            // 
            // radioButtonClavOn
            // 
            this.radioButtonClavOn.AutoSize = true;
            this.radioButtonClavOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonClavOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonClavOn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonClavOn.Location = new System.Drawing.Point(3, 12);
            this.radioButtonClavOn.Name = "radioButtonClavOn";
            this.radioButtonClavOn.Size = new System.Drawing.Size(168, 29);
            this.radioButtonClavOn.TabIndex = 3;
            this.radioButtonClavOn.TabStop = true;
            this.radioButtonClavOn.Text = "Скусын кӕнын";
            this.radioButtonClavOn.UseVisualStyleBackColor = true;
            this.radioButtonClavOn.CheckedChanged += new System.EventHandler(this.radioButtonClavOn_CheckedChanged);
            // 
            // radioButtonClavOff
            // 
            this.radioButtonClavOff.AutoSize = true;
            this.radioButtonClavOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonClavOff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonClavOff.Location = new System.Drawing.Point(190, 12);
            this.radioButtonClavOff.Name = "radioButtonClavOff";
            this.radioButtonClavOff.Size = new System.Drawing.Size(206, 29);
            this.radioButtonClavOff.TabIndex = 4;
            this.radioButtonClavOff.TabStop = true;
            this.radioButtonClavOff.Text = "Ныххуысын кӕнын";
            this.radioButtonClavOff.UseVisualStyleBackColor = true;
            this.radioButtonClavOff.CheckedChanged += new System.EventHandler(this.radioButtonClavOff_CheckedChanged);
            // 
            // labelClavs
            // 
            this.labelClavs.AutoSize = true;
            this.labelClavs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClavs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClavs.Location = new System.Drawing.Point(12, 19);
            this.labelClavs.Name = "labelClavs";
            this.labelClavs.Size = new System.Drawing.Size(203, 36);
            this.labelClavs.TabIndex = 5;
            this.labelClavs.Text = "Клавиатурӕ:";
            this.labelClavs.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(18, 315);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(231, 36);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(255, 315);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(159, 36);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButtonClavOff);
            this.panel1.Controls.Add(this.radioButtonClavOn);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(18, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 60);
            this.panel1.TabIndex = 9;
            // 
            // buttonOset
            // 
            this.buttonOset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOset.FlatAppearance.BorderSize = 0;
            this.buttonOset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOset.Image = ((System.Drawing.Image)(resources.GetObject("buttonOset.Image")));
            this.buttonOset.Location = new System.Drawing.Point(18, 186);
            this.buttonOset.Name = "buttonOset";
            this.buttonOset.Size = new System.Drawing.Size(186, 99);
            this.buttonOset.TabIndex = 1;
            this.buttonOset.Text = "\r\n";
            this.buttonOset.UseVisualStyleBackColor = true;
            this.buttonOset.Click += new System.EventHandler(this.buttonOset_Click);
            // 
            // buttonRussian
            // 
            this.buttonRussian.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonRussian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRussian.FlatAppearance.BorderSize = 0;
            this.buttonRussian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRussian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRussian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRussian.Image = ((System.Drawing.Image)(resources.GetObject("buttonRussian.Image")));
            this.buttonRussian.Location = new System.Drawing.Point(228, 186);
            this.buttonRussian.Name = "buttonRussian";
            this.buttonRussian.Size = new System.Drawing.Size(186, 99);
            this.buttonRussian.TabIndex = 2;
            this.buttonRussian.UseVisualStyleBackColor = false;
            this.buttonRussian.Click += new System.EventHandler(this.buttonRussian_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(444, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelClavs);
            this.Controls.Add(this.buttonRussian);
            this.Controls.Add(this.buttonOset);
            this.Controls.Add(this.labelLang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Нaтройкӕтӕ";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.Button buttonOset;
        private System.Windows.Forms.RadioButton radioButtonClavOn;
        private System.Windows.Forms.Label labelClavs;
        private System.Windows.Forms.RadioButton radioButtonClavOff;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRussian;
    }
}