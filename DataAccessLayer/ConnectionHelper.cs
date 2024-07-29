using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal static class ConnectionHelper
    {
        public static string ConnectionString
        {
            get
            {
                 return ConfigurationManager.ConnectionStrings["CookBookConnectionString"].ConnectionString;
            }
        }
    }
}
