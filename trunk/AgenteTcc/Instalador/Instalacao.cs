using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Instalador
{
    public partial class Instalacao : Form
    {
        public Instalacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Installer.TargetPath = txtDestinoExecutavel.Text;
                Installer.TamanhoLog = Convert.ToInt32(txtTamanhoLog.Text);
                Installer.IntervaloEnvio = Convert.ToInt32(txtIntervalo.Text);
                Installer.NumeroSerie = txtNumeroSerie.Text;
                Installer.DestinoLog = txtDestinoLog.Text;

                Installer.EmailDestinatario = txtEmailDestinatario.Text;
                Installer.EmailRemetente = txtEmailRemetente.Text;
                Installer.AssuntoEmail = txtAssuntoEmail.Text;
                Installer.CorpoEmail = txtCorpoEmail.Text;
                Installer.SenhaEmail = txtSenhaEmail.Text;
                Installer.ServidorEmail = txtServidorEmail.Text;
                Installer.Smtp = Convert.ToInt32(txtSmtp.Text);
                Installer.Ssl = checkSsl.Checked;
                Installer.UsuarioEmail = txtUsuarioEmail.Text;

                foreach (var item in listBox1.SelectedItems)
                {
                    Installer.ListaSoftwares = string.Format("{0}{1};",Installer.ListaSoftwares,item.ToString().Split('/').Last());
                }
               Installer.ListaSoftwares =  Installer.ListaSoftwares.Remove(Installer.ListaSoftwares.Count() - 1);

                progressBar1.Maximum = 15;
                progressBar1.Value = 0;

                Installer.ProgressBarInstalacao = progressBar1;


                Installer.Install();
                MessageBox.Show("Instalação concluida com sucesso!");

                if (checkBox2.Checked)
                {
                    Process.Start(string.Format("{0}\\Agente.exe",txtDestinoExecutavel.Text));
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(string.Format("Não foi possivel concluir a instação!\nErro:", er.Message));
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
