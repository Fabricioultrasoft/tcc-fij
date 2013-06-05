using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgenteTcc
{
    public partial class AjusteHorario : Form
    {
        public AjusteHorario()
        {
            InitializeComponent();
            SetFormValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarForm())
            {
                MessageBox.Show("É necessario preencher todos os campos");
                return;
            }


            var day = int.Parse(txtDia.Text);

            var month = int.Parse(txtMes.Text);
            var year = int.Parse(txtAno.Text);


            var hour = int.Parse(txtHora.Text);
            var minute = int.Parse(txtMinuto.Text);

            Horario.MudarHorarioWindows(day, month, year, hour, minute, 0);
            this.Close();
        }

        private bool ValidarForm()
        {
            if (string.IsNullOrEmpty(txtHora.Text) || string.IsNullOrEmpty(txtMinuto.Text) || string.IsNullOrEmpty(txtAno.Text) || string.IsNullOrEmpty(txtDia.Text) || string.IsNullOrEmpty(txtMes.Text))
            {
                return false;
            }
            return true;
        }

        private void SetFormValues()
        {
            txtAno.Text = DateTime.Now.Year.ToString();
            txtMes.Text = DateTime.Now.Month.ToString();
            txtDia.Text = DateTime.Now.Day.ToString();
            txtHora.Text = DateTime.Now.Hour.ToString();
            txtMinuto.Text = DateTime.Now.Minute.ToString();
        }
    }
}
