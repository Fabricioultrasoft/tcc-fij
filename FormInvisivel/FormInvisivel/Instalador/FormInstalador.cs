﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Instalador
{
    public partial class FormInstalador : Form
    {
        public FormInstalador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Installer.Install(txtTargetPath.Text);
        }
    }
}
