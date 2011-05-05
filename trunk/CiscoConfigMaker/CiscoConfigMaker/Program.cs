/*
 * Written by David Higgins - X00003549
 * Program is provided as-is
 * All rights reserved
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CiscoConfigMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
