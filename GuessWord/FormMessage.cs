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
    public partial class FormMessage : Form
    {
        public FormMessage(string s)
        {
            InitializeComponent();
            Location = new System.Drawing.Point(100,100);
            richTextBox.Text = s;
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
