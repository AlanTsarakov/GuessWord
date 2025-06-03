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
        char[,] field = new char[6, 5];
        public GameField(Form form)
        {
            form.Controls.Add(this);
        }

    }
}
