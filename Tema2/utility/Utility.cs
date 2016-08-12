using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2.utility
{
    class Utility
    {
        public static void PrintErrorMessage(string msgError)
        {
            MessageBox.Show(msgError, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void PrintSuccesMessage(string msgSucces)
        {
            MessageBox.Show(msgSucces, "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
