using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUygulamasıGiriş
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());

            // Proje çalıştığı zaman ilk hangi formun çalışmasını istiyorsak buradaki formun adını değiştirmemiz gerekiyor.
        }
    }
}
