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


        public static void tablaArgs(String table, String[] args, Object[] argsValue)
        {
            SqlConnection conn = sqlCon;
            String query = "SELECT * FROM " + table;

             
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(i);
                if (i == 0 && i == (args.Length - 1))
                {
                    query += "(@" + args[i] + ")";
                }
                else if (i == 0)
                {
                    query += "(@" + args[i] + ", ";
                }
                else
                {
                    if (i == (args.Length - 1))
                    {
                        query += "@" + args[i] + ")";
                    }
                    else
                    {
                        query += "@" + args[i] + ", ";
                    }
                }
            }
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            // cmd.CommandType=CommandType.StoredProcedure;  

            for (int i = 0; i < args.Length && args!=null; i++)
            {
                cmd.Parameters.AddWithValue("@"+args[i], argsValue[i]);
            }

            Console.WriteLine(query);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
           // string str = dt.Rows[0][0].ToString();
           for(int i=0; i<dt.Rows.Count; i++)
            {
                for(int j=0; j<dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j].ToString() + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine(str);
            //Response.Write(str.ToString());
        }
    }
}
