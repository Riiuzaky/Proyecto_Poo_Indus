using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace AeropuertoSofi.Aerolinea
{
    public class Conexion
    {
        protected OleDbConnection connection;

        protected OleDbConnection ConexiónBD{

            get 
            {
                connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AeropuertoSofi.accdb");
                connection.Open();
                return connection;
            
            
            }



        }
    }


}
