using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonProj.Forms;
using BeautySaloonProj.ModelEF;

namespace BeautySaloonProj
{
    internal static class Program
    {
        public static DBEntities db = new DBEntities();
        public static Users currentUser = new Users();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }
    }
}
