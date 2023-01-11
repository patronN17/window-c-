using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace программа_с_оконками_из_практической
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = MessageBox.Show("Леон топ ? ","Siiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (key == DialogResult.Yes)
                MessageBox.Show("леон лучше ");
            else
                MessageBox.Show("ошибся с выбором ботик)))");

        }
    }
}
