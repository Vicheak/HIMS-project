using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIMS_Project.Helpers;
using HIMS_Project.Patients;

namespace HIMS_Project
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
            Application.Run(new FrmBed());
        }

        public static SqlConnection Connection { get => new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=HIMS;Integrated Security=True;"); }
    }
}
