using Projekt_DB.DAOs;
using System.Data.SqlClient;

namespace Projekt_DB
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Starts the program
            UI ui = new UI();
            ui.Start();
        }
    }
}
