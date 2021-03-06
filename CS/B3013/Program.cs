﻿using System;
using DevExpress.Skins;
using System.Windows.Forms;

namespace B3013 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            Application.Run(new MainForm());
        }
    }
}