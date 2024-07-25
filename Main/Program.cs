// Threaded Project 2 Workshop 4 
// Created by Robbie Soriano
// Defines our program entry point

using TravelExpertsData.DataAccess;
using TravelExpertsData.Repository;

namespace Main
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

            var context = new TravelExpertsContext();
            var unitOfWork = new UnitOfWork(context);

            Application.Run(new Main(unitOfWork));
        }
    }
}