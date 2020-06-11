using System;
using System.Collections.Generic;
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
                    showViews();
                    break;
                case 2:
                    showSp();
                    break;
                case 3:
                    showCreate();
                    break;
                case 4:
                    showUpdate();
                    break;
                case 5:
                    showDelete();
                    break;
                case 6:
                    showCreate();
                    break;
                case 7:
                    showUpdate();
                    break;
                case 8:
                    showDelete();
                    break;
                case 9:
                    showCreate();
                    break;
                case 10:
                    showUpdate();
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
