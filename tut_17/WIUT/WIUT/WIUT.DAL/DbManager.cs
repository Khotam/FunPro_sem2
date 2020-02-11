using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace WIUT.DAL
{
    public class DbManager
    {
        protected SqlCeConnection Connection
        {
            get
            {
                return new SqlCeConnection(Properties.Settings.Default.ConnectionString);
            }
        }

    }
}
