using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using FuelStationApp.Impl;
using FuelStationApp.WUI;
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
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WizardForm wizardForm = new WizardForm();
            Application.Run(wizardForm);
            if (wizardForm.DialogResultSpecific == DialogResult.OK)
                Application.Run(wizardForm.StartApplication());
        }
    }
}
