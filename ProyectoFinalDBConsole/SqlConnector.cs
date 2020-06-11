using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinalDBConsole
{
    public class SqlConnector
    {
        private static SqlConnection sqlCon = new SqlConnection(@"Data Source=DeathStar\SQLEXPRESS; Initial Catalog=ProyectoFinal;Integrated Security=True;");

        public static SqlConnection getConnection()
        {
            return sqlCon;
        }
        public static void instance(String txt)
        {
            using (SqlConnection connection = sqlCon)
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = txt;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            for(int i=0; i<reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader.GetValue(i));
                            }
                            
                        }
                    }
                }
            }
        }
        public static void conn()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DeathStar\SQLEXPRESS; Initial Catalog=ProyectoFinal;Integrated Security=True;");

            //SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM t_maestros", sqlCon);

            /*DataTable dTbl = new DataTable();
            sqlDA.Fill(dTbl);
            foreach (DataRow row in dTbl.Rows)
            {
                Console.WriteLine(row["nomina"]);
            }
            Console.ReadKey();*/
        }
    }
}
