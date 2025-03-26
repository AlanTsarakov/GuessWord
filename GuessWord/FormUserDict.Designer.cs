
namespace GuessWord
{
    partial class FormUserDict
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserDict));
            this.dataGridViewDict = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDict)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDict
            // 
            this.dataGridViewDict.AllowUserToAddRows = false;
            this.dataGridViewDict.AllowUserToDeleteRows = false;
            this.dataGridViewDict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDict.Location = new System.Drawing.Point(-8, 161);
            this.dataGridViewDict.Name = "dataGridViewDict";
            this.dataGridViewDict.ReadOnly = true;
            this.dataGridViewDict.RowHeadersVisible = false;
            this.dataGridViewDict.RowHeadersWidth = 51;
            this.dataGridViewDict.RowTemplate.Height = 24;
            this.dataGridViewDict.Size = new System.Drawing.Size(590, 297);
            this.dataGridViewDict.TabIndex = 0;
            this.dataGridViewDict.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDict_CellContentClick);
            // 
            // FormUserDict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.dataGridViewDict);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserDict";
            this.Text = "Изученные слова";
            this.Load += new System.EventHandler(this.FormUserDict_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDict;
    }
}