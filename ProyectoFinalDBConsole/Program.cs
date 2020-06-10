using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinalDBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DeathStar\SQLEXPRESS; Initial Catalog=ProyectoFinal;Integrated Security=True;");

            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM t_maestros", sqlCon);

            DataTable dTbl = new DataTable();
            sqlDA.Fill(dTbl);
            foreach(DataRow row in dTbl.Rows)
            {
                Console.WriteLine(row["nomina"]);
            }
            Console.ReadKey();
        }
    }
}
