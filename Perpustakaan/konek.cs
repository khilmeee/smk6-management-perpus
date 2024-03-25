using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan
{
    class konek
    {
        public static string conn = "Data Source=MIWON\\SQLEXPRESS;Initial Catalog=perpustakaan_hilmi;Integrated Security=True;";
    }

    public class GlobalVar
    {
        public static string username { get; set; }
        public static string name { get; set; }
    }
}
