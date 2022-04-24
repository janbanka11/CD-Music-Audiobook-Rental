using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental
{
    public static class TextBoxExtensions
    {
        public static void CorrectHeight(this TextBox txtbox)
        {
            if (txtbox.BorderStyle == BorderStyle.None)
            {
                txtbox.BorderStyle = BorderStyle.FixedSingle;
                var heightWithBorder = txtbox.ClientRectangle.Height;
                txtbox.BorderStyle = BorderStyle.None;
                txtbox.AutoSize = false;
                txtbox.Height = heightWithBorder;
            }
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       
            [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginWin());
            
            Application.Exit();
        }
    }
}
