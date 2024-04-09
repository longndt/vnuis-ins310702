using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.Common
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the factory for the SQL data provider.
            DbProviderFactory sqlFactory = DbProviderFactories.GetFactory("System.Data.SqlClient");
        }
    }
}
