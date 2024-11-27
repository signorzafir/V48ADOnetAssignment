using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V48ADOnetAssignment
{
    internal class DataBaseConnection
    {
        internal SqlConnection Connection { get; set; }
        public DataBaseConnection(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
        }
        
    }


}
