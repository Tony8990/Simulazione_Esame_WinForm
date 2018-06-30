using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Simulazione_Esame_WinForm.Class
{
    public class DBConnect
    {
        public string ConnectionString { get; set; }
        public DBConnect(string Conn)
        {
            ConnectionString = ConfigurationSettings.AppSettings["SQl_Connection"];
        }
         
    }
           
}


