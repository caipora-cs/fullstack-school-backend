using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EscolaDBWinForm.Models;
using EscolaDBWinForm.Data;
using EscolaDBWinForm.Controller;
using EscolaDBWinForm.View;

namespace EscolaDBWinForm
{
    internal static class Program
    {
        public static IConfigurationRoot _configuration;
        private static DbContextOptionsBuilder<EscolaDBWinForm.Data.EscolaDbContext> _optionsBuilder;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            BuildConfiguration();
            BuildOptions();
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IMainView view = new MainView();
            new MainController(view);
            Application.Run((Form)view);
        }

        public static void BuildConfiguration() 
        { 
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
        }

        public static void BuildOptions()
        {
            _optionsBuilder = new DbContextOptionsBuilder<EscolaDBWinForm.Data.EscolaDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("EscolaDB"));
        }

    }
}