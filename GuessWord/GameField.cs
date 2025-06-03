using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GuessWord
{
    class GameField : DataGridView
    {
        public GameField()
        {

            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //this.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            //this.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            //this.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //this.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnHeadersVisible = false;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Location = new System.Drawing.Point(317, 128);
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "dataGridViewWordsField";
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            //dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //his.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.RowTemplate.Height = 24;
            this.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Size = new System.Drawing.Size(468, 499);
            this.StandardTab = true;
            this.TabIndex = 0;
            //this.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWordsField_CellContentClick);
            //this.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewWordsField_EditingControlShowing);
            //this.SelectionChanged += new System.EventHandler(this.dataGridViewWordsField_SelectionChanged);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewWordsField_KeyPress);
        }

    }
}
