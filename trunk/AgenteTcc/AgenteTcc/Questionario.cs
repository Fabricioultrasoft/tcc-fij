using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AgenteTcc
{
    public partial class Questionario : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        //  [return: MarshalAs(UnmanagedType.Bool)]
        // static extern bool ExitWindowsEx(ExitWindows uFlags, ShutdownReason dwReason);
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        public Questionario()
        {
            InitializeComponent();
        }



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

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                btnAvancar.Hide();

            if (tabControl1.SelectedIndex == 0)
                btnVoltar.Show();

            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                btnVoltar.Hide();

            if (tabControl1.SelectedIndex == 2)
                btnAvancar.Show();

            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void Questionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.TaskManagerClosing)
                e.Cancel = true;
        }



        private void Questionario_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("Você utilizou o laptop por {0} horas e {1} minutos. Durante esse tempo,", Horario.GetSystemUptime().Hours, Horario.GetSystemUptime().Minutes);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarQuestoes();
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Não foi possivel concluir a instação!\nErro: {0}", er.Message));
            }

            Log log = new Log()
            {
                IsShutdown = true,
                DataHoraEncerramento = DateTime.Now
            };

            log.RespostaPergunta1 = string.Format("{0}{1}{2}", Convert.ToInt32(checkAtividadesEscolares.Checked),
                                                              Convert.ToInt32(checkAtividadesLazer.Checked),
                                                              Convert.ToInt32(checkOutrasAtividades.Checked));

            log.RespostaPergunta2 = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", Convert.ToInt32(checkLinguaPortuguesa.Checked),
                                                              Convert.ToInt32(checkMatematica.Checked),
                                                              Convert.ToInt32(checkCiencias.Checked),
                                                              Convert.ToInt32(checkHistoria.Checked),
                                                              Convert.ToInt32(checkGeografia.Checked),
                                                              Convert.ToInt32(checkIngles.Checked),
                                                              Convert.ToInt32(checkArtes.Checked),
                                                              Convert.ToInt32(checkEduFisica.Checked),
                                                              Convert.ToInt32(checkEspanhol.Checked),
                                                              Convert.ToInt32(checkOutrasQ2.Checked));

            log.RespostaPergunta3 = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}", Convert.ToInt32(checkApresenCultural.Checked),
                                                              Convert.ToInt32(checkAulaPasseio.Checked),
                                                              Convert.ToInt32(checkDinamica.Checked),
                                                              Convert.ToInt32(checkEntrevista.Checked),
                                                              Convert.ToInt32(checkExcursaoCultural.Checked),
                                                              Convert.ToInt32(checkExercicio.Checked),
                                                              Convert.ToInt32(checkExposicao.Checked),
                                                              Convert.ToInt32(checkJogos.Checked),
                                                              Convert.ToInt32(checkLeitura.Checked),
                                                              Convert.ToInt32(checkPalestra.Checked),
                                                              Convert.ToInt32(checkPesquisa.Checked),
                                                              Convert.ToInt32(checkProdMaterial.Checked),
                                                              Convert.ToInt32(checkOutrosQ3.Checked));

            log.RespostaPergunta4 = string.Format("{0}{1}", Convert.ToInt32(checkSozinho.Checked),
                                                          Convert.ToInt32(checkEmGrupo.Checked));

            log.RespostaPergunta5 = string.Format("{0}{1}{2}{3}{4}{5}{6}", Convert.ToInt32(checkSalaAula.Checked),
                                                            Convert.ToInt32(checkBiblioteca.Checked),
                                                            Convert.ToInt32(checkPatioEscola.Checked),
                                                            Convert.ToInt32(checkLaboratorio.Checked),
                                                            Convert.ToInt32(checkCasa.Checked),
                                                            Convert.ToInt32(checkPasseioEscolar.Checked),
                                                            Convert.ToInt32(checkPasseioParticular.Checked));

            log.RespostaPergunta6 = cbxConseguiuConcluir.SelectedIndex.ToString();

            log.RespostaPergunta7 = cbxDuvidasUtilizacao.SelectedIndex.ToString();

            log.RespostaPergunta8 = txtComentarioUtilizacao.Text;

            log.Append();

        }

  

        private void ValidarQuestoes()
        {
            if (GetAll(panelQuestao1, typeof(CheckBox)).Count() == 0)
            {
                throw new Exception("É necessário preencher a questão 1");
            }
            if (GetAll(panelQuestao2, typeof(CheckBox)).Count() == 0)
            {
                throw new Exception("É necessário preencher a questão 2");
            }
            if (GetAll(panelQuestao3, typeof(CheckBox)).Count() == 0)
            {
                throw new Exception("É necessário preencher a questão 3");
            }
            if (GetAll(panelQuestao4, typeof(CheckBox)).Count() == 0)
            {
                throw new Exception("É necessário preencher a questão 4");
            }
            if (GetAll(panelQuestao5, typeof(CheckBox)).Count() == 0)
            {
                throw new Exception("É necessário preencher a questão 5");
            }

            if(string.IsNullOrEmpty((string)cbxConseguiuConcluir.SelectedItem))
                throw new Exception("É necessário preencher a questão 6");

            if (string.IsNullOrEmpty((string)cbxDuvidasUtilizacao.SelectedItem))
                throw new Exception("É necessário preencher a questão 7");

        }

        public IEnumerable<CheckBox> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<CheckBox>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type && c.Checked);
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                btnVoltar.Hide();
                btnAvancar.Show();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                btnVoltar.Show();
                btnAvancar.Show();
                
            }
            if (tabControl1.SelectedIndex == 2)
            {
                btnVoltar.Show();
                btnAvancar.Hide();

            }

          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                btnVoltar.Hide();
                btnAvancar.Show();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                btnVoltar.Show();
                btnAvancar.Show();

            }
            if (tabControl1.SelectedIndex == 2)
            {
                btnVoltar.Show();
                btnAvancar.Hide();

            }
        }


    }
}
