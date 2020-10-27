﻿using Emgu.CV;
using SmartSaver.Controllers;
using SmartSaver.Desktop;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SmartSaver
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Debug.WriteLine( CvInvoke.CheckLibraryLoaded() );

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
            //(new ImageRecognizer()).RecognizeTestImages();
        }
    }
}
