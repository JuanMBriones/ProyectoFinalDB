using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace ProyectoFinalDBConsole
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //SqlConnector.conn();

            SqlConnector.instance("SELECT * FROM view_maestros");
            /*
            Console.WriteLine("Hello. Welcome to your agenda with professors.\nWhen you are sure of the service you desire to achieve press the number before the sentence.");
            Console.WriteLine("1.Show all registers");
            Console.WriteLine("2.Get registers");
            Console.WriteLine("3.Create/Insert registers");
            Console.WriteLine("4.Update registers");
            Console.WriteLine("5.Delete registers");
            Console.WriteLine("0. EXIT");
            int option = 0;
            do
            {
                Console.Write("Your option: ");
                option = Convert.ToInt32(Console.ReadLine());
                
            } while (!(option>=0 && option<=5));

            Console.Clear();
            switch(option)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Menu.showViews();
                    break;
                case 2:
                    Menu.showSp();
                    break;
                case 3:
                    Menu.showCreate();
                    break;
                case 4:
                    Menu.showUpdate();
                    break;
                case 5:
                    Menu.showDelete();
                    break;
            } */
        }
    }
}
