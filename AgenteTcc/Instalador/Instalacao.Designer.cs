namespace Instalador
{
    partial class Instalacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinoExecutavel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamanhoLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.txtDestinoLog = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailDestinatario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServidorEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkSsl = new System.Windows.Forms.CheckBox();
            this.txtUsuarioEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSenhaEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCorpoEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAssuntoEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmailRemetente = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho destino do executavel";
            // 
            // txtDestinoExecutavel
            // 
            this.txtDestinoExecutavel.Location = new System.Drawing.Point(12, 29);
            this.txtDestinoExecutavel.Name = "txtDestinoExecutavel";
            this.txtDestinoExecutavel.Size = new System.Drawing.Size(347, 20);
            this.txtDestinoExecutavel.TabIndex = 1;
            this.txtDestinoExecutavel.Text = "C:\\Memore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamanho minimo do arquivo log (para envio)";
            // 
            // txtTamanhoLog
            // 
            this.txtTamanhoLog.Location = new System.Drawing.Point(12, 82);
            this.txtTamanhoLog.Name = "txtTamanhoLog";
            this.txtTamanhoLog.Size = new System.Drawing.Size(41, 20);
            this.txtTamanhoLog.TabIndex = 3;
            this.txtTamanhoLog.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "kb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Intervalo para tentativa de envio";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(12, 135);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(59, 20);
            this.txtIntervalo.TabIndex = 6;
            this.txtIntervalo.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Minutos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "N° de serie do laptop";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Location = new System.Drawing.Point(11, 179);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(348, 20);
            this.txtNumeroSerie.TabIndex = 9;
            // 
            // txtDestinoLog
            // 
            this.txtDestinoLog.Location = new System.Drawing.Point(11, 230);
            this.txtDestinoLog.Name = "txtDestinoLog";
            this.txtDestinoLog.Size = new System.Drawing.Size(348, 20);
            this.txtDestinoLog.TabIndex = 11;
            this.txtDestinoLog.Text = "C:\\Memore\\logs\\log.txt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Caminho destino do arquivo de log";
            // 
            // txtEmailDestinatario
            // 
            this.txtEmailDestinatario.Location = new System.Drawing.Point(9, 46);
            this.txtEmailDestinatario.Name = "txtEmailDestinatario";
            this.txtEmailDestinatario.Size = new System.Drawing.Size(220, 20);
            this.txtEmailDestinatario.TabIndex = 13;
            this.txtEmailDestinatario.Text = "nome@dominio.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email destinatario do arquivo de log";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(9, 96);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(116, 20);
            this.txtSmtp.TabIndex = 15;
            this.txtSmtp.Text = "23";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "SMTP";
            // 
            // txtServidorEmail
            // 
            this.txtServidorEmail.Location = new System.Drawing.Point(9, 156);
            this.txtServidorEmail.Name = "txtServidorEmail";
            this.txtServidorEmail.Size = new System.Drawing.Size(220, 20);
            this.txtServidorEmail.TabIndex = 17;
            this.txtServidorEmail.Text = "smtp.servidor.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Servidor de email";
            // 
            // checkSsl
            // 
            this.checkSsl.AutoSize = true;
            this.checkSsl.Location = new System.Drawing.Point(156, 99);
            this.checkSsl.Name = "checkSsl";
            this.checkSsl.Size = new System.Drawing.Size(73, 17);
            this.checkSsl.TabIndex = 19;
            this.checkSsl.Text = "Ativa SSL";
            this.checkSsl.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioEmail
            // 
            this.txtUsuarioEmail.Location = new System.Drawing.Point(6, 104);
            this.txtUsuarioEmail.Name = "txtUsuarioEmail";
            this.txtUsuarioEmail.Size = new System.Drawing.Size(220, 20);
            this.txtUsuarioEmail.TabIndex = 21;
            this.txtUsuarioEmail.Text = "usuario do email de envio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Usuario";
            // 
            // txtSenhaEmail
            // 
            this.txtSenhaEmail.Location = new System.Drawing.Point(6, 148);
            this.txtSenhaEmail.Name = "txtSenhaEmail";
            this.txtSenhaEmail.Size = new System.Drawing.Size(220, 20);
            this.txtSenhaEmail.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCorpoEmail);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtAssuntoEmail);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkSsl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtServidorEmail);
            this.groupBox1.Controls.Add(this.txtEmailDestinatario);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSmtp);
            this.groupBox1.Location = new System.Drawing.Point(369, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 396);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Corpo do email";
            // 
            // txtCorpoEmail
            // 
            this.txtCorpoEmail.Location = new System.Drawing.Point(265, 96);
            this.txtCorpoEmail.Multiline = true;
            this.txtCorpoEmail.Name = "txtCorpoEmail";
            this.txtCorpoEmail.Size = new System.Drawing.Size(254, 80);
            this.txtCorpoEmail.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Assunto do email";
            // 
            // txtAssuntoEmail
            // 
            this.txtAssuntoEmail.Location = new System.Drawing.Point(265, 46);
            this.txtAssuntoEmail.Name = "txtAssuntoEmail";
            this.txtAssuntoEmail.Size = new System.Drawing.Size(254, 20);
            this.txtAssuntoEmail.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEmailRemetente);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtUsuarioEmail);
            this.groupBox2.Controls.Add(this.txtSenhaEmail);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(9, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 194);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credenciais";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Email remetente";
            // 
            // txtEmailRemetente
            // 
            this.txtEmailRemetente.Location = new System.Drawing.Point(6, 54);
            this.txtEmailRemetente.Name = "txtEmailRemetente";
            this.txtEmailRemetente.Size = new System.Drawing.Size(348, 20);
            this.txtEmailRemetente.TabIndex = 26;
            this.txtEmailRemetente.Text = "nome@dominio.com";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 536);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(154, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Executar após a instalação";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "Instalar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 641);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(889, 23);
            this.progressBar1.TabIndex = 31;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Google Chrome/chrome.exe",
            "Internet Explorer/iexplore.exe",
            "Mozilla Firefox/firefox.exe",
            "Word/winword.exe",
            "Power Point/powerpnt.exe",
            "Excel/excel.exe"});
            this.listBox1.Location = new System.Drawing.Point(10, 331);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(349, 199);
            this.listBox1.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Lista de softwares a serem monitorados";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(226, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Adicionar processo (Formato: Nome/processo)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 20);
            this.button2.TabIndex = 36;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Instalacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 709);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDestinoLog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTamanhoLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestinoExecutavel);
            this.Controls.Add(this.label1);
            this.Name = "Instalacao";
            this.Text = "Instalador Memore";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinoExecutavel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamanhoLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.TextBox txtDestinoLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailDestinatario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServidorEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkSsl;
        private System.Windows.Forms.TextBox txtUsuarioEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSenhaEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCorpoEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAssuntoEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmailRemetente;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
    }
}

