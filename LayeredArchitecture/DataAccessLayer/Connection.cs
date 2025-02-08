using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection con  = new SqlConnection(@"Data Source=EVREM_ANKA;Initial Catalog=PersonelData;Integrated Security=True");

        
    }
}
