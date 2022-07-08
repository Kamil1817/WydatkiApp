using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WydatkiApp
{
    static class Program
    {
        /// <summary>
        ///  Punkt startowy aplikacji. Wyświetlanie okna z rejestracją.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRegister());
        }
    }
}
