using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinalDBConsole
{
    class Menu
    {

        public static void showViews()
        {

            Console.WriteLine("----------------------------> VIEWS <----------------------------");
            Console.WriteLine("1. View all Auto Diagnostico.");
            Console.WriteLine("2. View all Professors.");
            Console.WriteLine("3. View all coming up meetings.");
            Console.WriteLine("4. View all meetings with tha name of the professor. ");
            Console.WriteLine("5. View all coming up meetings with the name of the professors. ");
            Console.WriteLine("6. View only meetings from the past.");
            Console.WriteLine("7. View up coming meetings with the average score of the auto diagnosis");
            Console.WriteLine("8. Show all information of a professor:  nomina, name, last name, rubro1 - rubro6, average, up coming and past meetings, with comments if exists and if they assisted. (nomina)");
            Console.WriteLine("9. Show professors who are below the average inserted. (value)");
            Console.WriteLine("10. Show professors who doesn't have any meeting schedule.");
            Console.WriteLine("0. EXIT");
            
            int option = 0;
            do
            {
                Console.Write("Your option: ");
                option = Convert.ToInt32(Console.ReadLine());

            } while (!(option >= 0 && option <= 10));

            Console.Clear();


            

            switch (option)
            {

                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    SqlConnector.tablaArgs("view_autodiagnostico", Enumerable.Empty<string>().ToArray(), Enumerable.Empty<Object>().ToArray());
                    break;
                case 2:
                    SqlConnector.tablaArgs("view_maestros", Enumerable.Empty<string>().ToArray(), Enumerable.Empty<Object>().ToArray());
                    break;
                case 3:
                    SqlConnector.tablaArgs("view_meetingsComingUp", Enumerable.Empty<string>().ToArray(), Enumerable.Empty<Object>().ToArray());
                    break;
                case 4:
                    SqlConnector.tablaArgs("view_meetingsDatesAndNames", Enumerable.Empty<string>().ToArray(), Enumerable.Empty<Object>().ToArray());
                    break;
                case 5:
                    SqlConnector.tablaArgs("view_meetingsDatesAndNamesUpComing", Enumerable.Empty<string>().ToArray(), Enumerable.Empty<Object>().ToArray());
                   
                    break;
                case 6:
                    SqlConnector.tablaArgs("view_meetingsPassed", Enumerable.Empty<string>().ToArray(), Enumerable.Empty<Object>().ToArray());
                                
                    break;
                case 7:
                    SqlConnector.tablaArgs("view_nextMeetingWithAverage", Enumerable.Empty<string>().ToArray(), Enumerable.Empty<Object>().ToArray());
                    
                    break;
                case 8:
                    Console.Write("Write the ID: ");
                    int nomina = Convert.ToInt32(Console.ReadLine());
                    String[] strArgs = { "@nomina" };

                    Object[] objArgs = { nomina };
                    SqlConnector.tablaArgs("fnTeachersAgendaAndInfo", strArgs, objArgs);
                    
                    break;
                case 9:
                    Console.Write("Write the ID: ");
                    float avg = float.Parse(Console.ReadLine());
                    String[] strArgs2 = { "@nomina" };
                    Object[] objArgs2 = { avg };
                    SqlConnector.tablaArgs("fnTeachersAgendaAndInfo", strArgs2, objArgs2);
                    break;
                case 10:
                    SqlConnector.tablaArgs("fnTeachersWithNoMeetings", Enumerable.Empty<string>().ToArray(), Enumerable.Empty<Object>().ToArray());
                    
                    break;
            }
        }

        public static void showSp()
        {
            Console.WriteLine("----------------------------> SP <----------------------------");
            Console.WriteLine("1.RegresaR(rango1, rango2)");
            Console.WriteLine("2.RegresaN(nombre, apellido)");
            Console.WriteLine("3.RegresaN2(nombrem apellido, fecha)");
            Console.WriteLine("4.RegresaAgendaHoy(dias)");
            Console.WriteLine("5.Reporte(Rango1fecha, rango2fecha)");
            Console.WriteLine("6.Check meetings by professor name. (nombre, apellido, fecha)");
            Console.WriteLine("0. EXIT");

            int option = 0;
            do
            {
                Console.Write("Your option: ");
                option = Convert.ToInt32(Console.ReadLine());

            } while (!(option >= 0 && option <= 10));

            Console.Clear();

            string nombre, apellido;
            DateTime inputtedDate;
            switch (option)
            {
                case 0:
                    Environment.Exit(0);
                    Console.WriteLine("1.RegresaR(rango1, rango2)");
                    Console.WriteLine("2.RegresaN(nombre, apellido)");
                    Console.WriteLine("3.RegresaN2(nombrem apellido, fecha)");
                    Console.WriteLine("4.RegresaAgendaHoy(dias)");
                    Console.WriteLine("5.Reporte(Rango1fecha, rango2fecha)");
                    Console.WriteLine("6.Check meetings by professor name. (nombre, apellido, fecha)");
                    break;
                case 1:
                    Console.Write("Rango1: ");
                    float rango1 = float.Parse(Console.ReadLine());
                    Console.Write("Rango2: ");
                    float rango2 = float.Parse(Console.ReadLine());
                    
                    String[] strArgs = { "@rango1", "@rango2" };
                    Object[] objArgs = { rango1, rango2 };
                    SqlConnector.tablaArgs("RegresaR", strArgs, objArgs);
                    break;
                case 2:
                    Console.Write("nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("apellido: ");
                    apellido = Console.ReadLine();

                    String[] strArgs2 = { "@nombre", "@apellido" };
                    Object[] objArgs2 = { nombre, apellido };
                    SqlConnector.tablaArgs("RegresaN", strArgs2, objArgs2);
                    //showAlls.viewAutodiagnostico("RegresaN(" + nombre + "," + apellido + ")");
                    break;
                case 3:
                    Console.Write("nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Fecha: ");
                    inputtedDate = DateTime.Parse(Console.ReadLine());

                    String[] strArgs3 = { "@nombre", "@apellido", "fecha" };
                    Object[] objArgs3 = { nombre, apellido, inputtedDate };
                    SqlConnector.tablaArgs("RegresaN2", strArgs3, objArgs3);

                    //showAlls.viewAutodiagnostico("RegresaN(\'" + nombre + "\',\'" + apellido + "\',\'" + inputtedDate + "\')");
                    break;
                case 4:
                    Console.Write("Dias: ");
                    int dias = Convert.ToInt32(Console.ReadLine());

                    String[] strArgs4 = { "@DaysPassed" };
                    Object[] objArgs4 = { dias };
                    SqlConnector.tablaArgs("RegresaAgendaHoy", strArgs4, objArgs4);
                    //showAlls.viewAutodiagnostico("RegresaAgendaHoy(" + dias.ToString() + ")");
                    break;
                case 5:
                    Console.Write("Fecha1: ");
                    DateTime fecha1 = DateTime.Parse(Console.ReadLine());
                    Console.Write("Fecha2: ");
                    DateTime fecha2 = DateTime.Parse(Console.ReadLine());


                    String[] strArgs5 = { "fecha1", "fecha2" };
                    Object[] objArgs5 = { fecha1, fecha2 };
                    SqlConnector.tablaArgs("Reporte", strArgs5, objArgs5);
                    //showAlls.viewAutodiagnostico("Reporte(" + fecha1 + "," + fecha2 +")");

                    break;
                case 6:
                    Console.Write("nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Fecha: ");
                    inputtedDate = DateTime.Parse(Console.ReadLine());



                    String[] strArgs6 = { "@nombre", "@apellido", "fecha" };
                    Object[] objArgs6 = { nombre, apellido, inputtedDate };
                    SqlConnector.tablaArgs("RegresaN2", strArgs6, objArgs6);
                    //showAlls.viewAutodiagnostico("RegresaN(" + nombre + "," + apellido + "," + inputtedDate + ")");
                    break;
            }
        }

        public static void showCreate()
        {
            Console.WriteLine("----------------------------> CREATE <----------------------------");
            Console.WriteLine("1.Create new professor. (nomina, nombre, apellido)");
            Console.WriteLine("2.Create new meeting. (fecha, nomina)");
            Console.WriteLine("3.Create new auto diagnosis. (nomina, rubro1, rubro2, rubro3, rubro4, rubro5, rubro6)");
            Console.WriteLine("4.InsertaComentario(nombre, apellido, comentario)");
            Console.WriteLine("5. Create a new teacher and auto diagnosis at the same time. (nomina, nombre, apellido, rubro1, rubro2, rubro3, rubro4, rubro5, rubro6)");
            Console.WriteLine("6. Create new auto diagnosis using name instead of nomina. (nombre, apellido, rubro1, rubro2, rubro3, rubro4, rubro5, rubro6)");
            Console.WriteLine("7. Create a new teacher and a new meeting. (nombre, apellido, nomina, fecha)");
            Console.WriteLine("0. EXIT");
        }

        public static void showDelete()
        {
            Console.WriteLine("----------------------------> DELETE <----------------------------");
            Console.WriteLine("1. Delete Auto Diagnosis. (nomina)");
            Console.WriteLine("2. Delete Professor. (nomina)");
            Console.WriteLine("3. Delete Meeting. (nomina, date)");
            Console.WriteLine("4.BorraComentario(nomina, fecha)");
            Console.WriteLine("0. EXIT");
        }

        public static void showUpdate()
        {
            Console.WriteLine("----------------------------> UPDATE <----------------------------");
            Console.WriteLine("1.Update Auto Diagnosis. (nomina, rubro1, rubro2, rubro3, rubro4, rubro5, rubro6)");
            Console.WriteLine("2.Update Professor. (nomina, nombre, apellido)");
            Console.WriteLine("3.Update Meeting. (meetingId, fecha, nomina, comentario, asistencia)");
            Console.WriteLine("4.ActualizaRubro(columna, nomina, nueva calif)");
            Console.WriteLine("0. EXIT");
        }

    }
}
