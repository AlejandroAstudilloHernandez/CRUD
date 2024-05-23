using CRUD.BussinessLayer;
using CRUD.DataAccessLayer;
using CRUD.Models;

namespace CRUD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            CRUDContext context = new CRUDContext();
            Data data = new Data(context);
            Bussiness bussiness = new Bussiness(data);
            Application.Run(new CRUD(bussiness));
        }
    }
}