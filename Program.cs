using System;
using System.Windows.Forms;
using QL_SinhVIen.Views;

namespace QL_SinhVIen
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
