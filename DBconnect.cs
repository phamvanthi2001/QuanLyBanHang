using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=LAPTOP-OBS3DN09;Initial Catalog=QLBH;Integrated Security=True");
    }
}