using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace FormInvisivel
{
    public partial class Formulario : Form
    {

        [DllImport("user32.dll", SetLastError = true)]
        //  [return: MarshalAs(UnmanagedType.Bool)]
        // static extern bool ExitWindowsEx(ExitWindows uFlags, ShutdownReason dwReason);
        static extern bool ExitWindowsEx(uint uFlags, uint
     dwReason);


        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public Formulario()
        {
            InitializeComponent();
            // this.ControlBox = false; 

        }


        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Environment.UserName);
            
            
            //ExitWindowsEx(ExitWindows.ShutDown,0);
            //  ExitWindowsEx(8, 0);
            //  Process.Start("shutdown", "/s /t 0");
              Application.Exit();
        }

        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing)
                e.Cancel = true;
        }


    }
}
