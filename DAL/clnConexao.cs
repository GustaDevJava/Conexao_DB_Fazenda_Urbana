using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clnConexao
    {
    
        private static SqlConnection con;

         private static string caminho =
            "Data source=DESKTOP-CD2EH39; initial catalog=PimFazendaUrbana; Integrated Security=True";
       
        public static SqlConnection getConexao()
    {
            try
            {
                con = new SqlConnection(caminho);
                return con;
            }
            catch(Exception)
            {
                throw;
            }


    }



    }
}
