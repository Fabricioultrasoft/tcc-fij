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
                ValidarCampos();

                Installer.TargetPath = txtDestinoExecutavel.Text;
               
                Installer.QuantidadeSessoes = Convert.ToInt32(txtQtdSessoes.Text);
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

                MessageBox.Show(string.Format("Não foi possivel concluir a instação!\nErro: {0}", er.Message));
            }


        }

        private void ValidarCampos()
        {
            if (listBox1.SelectedItems.Count == 0)
               throw new Exception("É necessário selecionar no mínimo um software na lista");
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
