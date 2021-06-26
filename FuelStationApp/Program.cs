using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using FuelStationApp.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FuelStationApp {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new MainForm());
            Employee employee = new Employee(new Person(new Entity(),"A","B"),
                new Dates(DateTime.Now,DateTime.MaxValue),1000);
            employee._person.Name = "Haris";
        }
    }
}
