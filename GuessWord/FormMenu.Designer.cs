
namespace GuessWord
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.textBoxNewUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPanelClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.buttonDelUser = new System.Windows.Forms.Button();
            this.buttonLearning = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.Location = new System.Drawing.Point(268, 194);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(240, 39);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Играть";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInformation.Location = new System.Drawing.Point(268, 241);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(240, 39);
            this.buttonInformation.TabIndex = 44;
            this.buttonInformation.Text = "Об игре";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(558, 44);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(230, 28);
            this.comboBoxUsers.TabIndex = 46;
            this.comboBoxUsers.SelectedValueChanged += new System.EventHandler(this.comboBoxUsers_SelectedValueChanged);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddUser.Location = new System.Drawing.Point(19, 145);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(172, 59);
            this.buttonAddUser.TabIndex = 47;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // textBoxNewUser
            // 
            this.textBoxNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewUser.Location = new System.Drawing.Point(45, 20);
            this.textBoxNewUser.Name = "textBoxNewUser";
            this.textBoxNewUser.Size = new System.Drawing.Size(350, 34);
            this.textBoxNewUser.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPanelClose);
            this.panel1.Controls.Add(this.textBoxNewUser);
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Location = new System.Drawing.Point(190, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 257);
            this.panel1.TabIndex = 49;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Введите имя пользователя        ";
            // 
            // buttonPanelClose
            // 
            this.buttonPanelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPanelClose.Location = new System.Drawing.Point(228, 145);
            this.buttonPanelClose.Name = "buttonPanelClose";
            this.buttonPanelClose.Size = new System.Drawing.Size(182, 59);
            this.buttonPanelClose.TabIndex = 49;
            this.buttonPanelClose.Text = "Отмена";
            this.buttonPanelClose.UseVisualStyleBackColor = true;
            this.buttonPanelClose.Click += new System.EventHandler(this.buttonPanelClose_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(268, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 39);
            this.button1.TabIndex = 50;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUser.Location = new System.Drawing.Point(553, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(179, 29);
            this.labelUser.TabIndex = 51;
            this.labelUser.Text = "Пользователь";
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNewUser.BackgroundImage")));
            this.buttonNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewUser.FlatAppearance.BorderSize = 0;
            this.buttonNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewUser.Location = new System.Drawing.Point(641, 83);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(66, 48);
            this.buttonNewUser.TabIndex = 52;
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // buttonDelUser
            // 
            this.buttonDelUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelUser.BackgroundImage")));
            this.buttonDelUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelUser.FlatAppearance.BorderSize = 0;
            this.buttonDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelUser.Location = new System.Drawing.Point(713, 78);
            this.buttonDelUser.Name = "buttonDelUser";
            this.buttonDelUser.Size = new System.Drawing.Size(75, 53);
            this.buttonDelUser.TabIndex = 53;
            this.buttonDelUser.UseVisualStyleBackColor = true;
            this.buttonDelUser.Click += new System.EventHandler(this.buttonDelUser_Click);
            // 
            // buttonLearning
            // 
            this.buttonLearning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLearning.Location = new System.Drawing.Point(268, 374);
            this.buttonLearning.Name = "buttonLearning";
            this.buttonLearning.Size = new System.Drawing.Size(240, 39);
            this.buttonLearning.TabIndex = 54;
            this.buttonLearning.Text = "Учиться";
            this.buttonLearning.UseVisualStyleBackColor = true;
            this.buttonLearning.Visible = false;
            this.buttonLearning.Click += new System.EventHandler(this.buttonLearning_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLearning);
            this.Controls.Add(this.buttonDelUser);
            this.Controls.Add(this.buttonNewUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 50);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Угадай слово";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TextBox textBoxNewUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPanelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Button buttonDelUser;
        private System.Windows.Forms.Button buttonLearning;
    }
}