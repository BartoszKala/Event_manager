using Event_manager.Views;
using Event_manager.Models;
using Event_manager.Presenter;
using Event_manager.Repository;
using Event_manager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_manager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.



            IEventView personView = new EventView();
            IEventRepository personRepository = new EventRepository();
            new EventPresenter(personView, personRepository);
            Application.Run((Form)personView);
        }
    }
}