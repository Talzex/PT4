using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    static class Program
    {
        public static Form mainScreen;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Utils.LoadEntities();
            
            mainScreen = new ScreenConection();
            Application.Run(mainScreen);
        }
    }
}
