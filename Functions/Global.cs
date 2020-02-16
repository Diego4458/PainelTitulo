using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePainel.Functions
{
    class Global
    {

        public static string DbTank()
        { return Convert.ToString(ConfigurationManager.ConnectionStrings["DbTank"]); }
        public static string Tank_1()
        { return Convert.ToString(ConfigurationManager.ConnectionStrings["Tank_1"]); }
    }
}
