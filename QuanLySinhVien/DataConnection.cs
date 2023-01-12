using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source=SHUN;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        }


        public SqlConnection GetConnection() 
        {
            return new SqlConnection(conStr);
        }
    }

}
