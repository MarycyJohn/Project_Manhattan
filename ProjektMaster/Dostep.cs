using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ProjektMaster
{
    public class Dostep
    {
        public List<Autko> GetAutko(string marka)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Support.CnnVal("Piesek")))
            {
                var output = connection.Query<Autko>($"select * from dbo.auta where marka = '{ marka }'").ToList();
                return output;
            }
            //throw new NotImplementedException();
        }
    }
}

//<add name ="SkupAut" connectionString="Server=.;Database=SkupAut;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>