using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace ItsAGun
{
    static class Program
    {
        public static Point centralPoint = new Point(200, 200);
        public static List<Form> forms = new List<Form>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            for (int i=0;i<=4;i++) // Add parts to the gun
            {
                forms.Add(new GunPart(i));
            }
            Application.Run(new MultiFormContext(forms.ToArray())); // Run all the forms
        }
    }
}
