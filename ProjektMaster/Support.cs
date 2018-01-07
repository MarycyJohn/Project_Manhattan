using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMaster
{
    public static class Support
    {
        public static string CnnVal(string name)  //to nazwa streamu polaczenia
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
