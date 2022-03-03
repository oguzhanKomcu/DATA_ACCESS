using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_BankDb_Project.Intfrastructure.Repositories.Abstract
{
    public class KernelRepository
    {
        string connectionString = @"Server= DESKTOP-97DV3CH\SQLEXPRESS; Database = BankDatabase;Integrated Security=True;";

        public IDbConnection con { get; set; }

        public KernelRepository()
        {
            con = new SqlConnection(connectionString);

        }









    }
}
