namespace MeuPrimeiroForms
{
    partial class frmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.botaoEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CampoProfissao = new System.Windows.Forms.TextBox();
            this.campoSexo = new System.Windows.Forms.ComboBox();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.campoSalario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.campoObservacoes = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.popupEnviar = new System.Windows.Forms.SaveFileDialog();
            this.campoCalendario = new System.Windows.Forms.DateTimePicker();
            this.campoLinkedin = new System.Windows.Forms.CheckBox();
            this.campoGithub = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(93, 125);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(162, 23);
            this.campoNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(227, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "PREENCHA COM SUAS INFORMAÇÕES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(15, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Profisão:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(15, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 4;
            // 
            // botaoEnviar
            // 
            this.botaoEnviar.BackColor = System.Drawing.Color.MintCream;
            this.botaoEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.botaoEnviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Fuchsia;
            this.botaoEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botaoEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.botaoEnviar.Location = new System.Drawing.Point(713, 539);
            this.botaoEnviar.Name = "botaoEnviar";
            this.botaoEnviar.Size = new System.Drawing.Size(85, 32);
            this.botaoEnviar.TabIndex = 7;
            this.botaoEnviar.Text = "Enviar";
            this.botaoEnviar.UseVisualStyleBackColor = false;
            this.botaoEnviar.Click += new System.EventHandler(this.btnEnviar);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nascimento:";
            // 
            // CampoProfissao
            // 
            this.CampoProfissao.Location = new System.Drawing.Point(93, 212);
            this.CampoProfissao.Name = "CampoProfissao";
            this.CampoProfissao.Size = new System.Drawing.Size(121, 23);
            this.CampoProfissao.TabIndex = 1;
            // 
            // campoSexo
            // 
            this.campoSexo.FormattingEnabled = true;
            this.campoSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não informar"});
            this.campoSexo.Location = new System.Drawing.Point(93, 166);
            this.campoSexo.Name = "campoSexo";
            this.campoSexo.Size = new System.Drawing.Size(121, 23);
            this.campoSexo.TabIndex = 10;
            this.campoSexo.Text = "Escolha";
            // 
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(529, 118);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(121, 23);
            this.campoTelefone.TabIndex = 1;
            this.campoTelefone.Text = "+55";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(458, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Possui :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(447, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email:";
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(93, 395);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(162, 23);
            this.campoEmail.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Endereço:";
            // 
            // campoEndereco
            // 
            this.campoEndereco.Location = new System.Drawing.Point(93, 265);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(121, 23);
            this.campoEndereco.TabIndex = 1;
            // 
            // campoSalario
            // 
            this.campoSalario.Location = new System.Drawing.Point(529, 172);
            this.campoSalario.Name = "campoSalario";
            this.campoSalario.Size = new System.Drawing.Size(121, 23);
            this.campoSalario.TabIndex = 1;
            this.campoSalario.Text = "R$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(441, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Observações :";
            // 
            // campoObservacoes
            // 
            this.campoObservacoes.Location = new System.Drawing.Point(551, 330);
            this.campoObservacoes.Name = "campoObservacoes";
            this.campoObservacoes.Size = new System.Drawing.Size(199, 118);
            this.campoObservacoes.TabIndex = 13;
            this.campoObservacoes.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(441, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 38);
            this.label12.TabIndex = 4;
            this.label12.Text = "Pretensão\r\n  Salarial:";
            // 
            // popupEnviar
            // 
            this.popupEnviar.FileOk += new System.ComponentModel.CancelEventHandler(this.SalvarArquivoLocal);
            // 
            // campoCalendario
            // 
            this.campoCalendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.campoCalendario.Location = new System.Drawing.Point(110, 327);
            this.campoCalendario.Name = "campoCalendario";
            this.campoCalendario.Size = new System.Drawing.Size(200, 23);
            this.campoCalendario.TabIndex = 15;
            // 
            // campoLinkedin
            // 
            this.campoLinkedin.AutoSize = true;
            this.campoLinkedin.Location = new System.Drawing.Point(551, 255);
            this.campoLinkedin.Name = "campoLinkedin";
            this.campoLinkedin.Size = new System.Drawing.Size(71, 19);
            this.campoLinkedin.TabIndex = 16;
            this.campoLinkedin.Text = "Linkedin";
            this.campoLinkedin.UseVisualStyleBackColor = true;
            // 
            // campoGithub
            // 
            this.campoGithub.AutoSize = true;
            this.campoGithub.Location = new System.Drawing.Point(551, 280);
            this.campoGithub.Name = "campoGithub";
            this.campoGithub.Size = new System.Drawing.Size(62, 19);
            this.campoGithub.TabIndex = 17;
            this.campoGithub.Text = "Github";
            this.campoGithub.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(836, 623);
            this.Controls.Add(this.campoGithub);
            this.Controls.Add(this.campoLinkedin);
            this.Controls.Add(this.campoCalendario);
            this.Controls.Add(this.campoObservacoes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.campoSalario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.campoEndereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.campoSexo);
            this.Controls.Add(this.CampoProfissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaoEnviar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoNome);
            this.Name = "frmCadastro";
            this.Text = "Cadastro de Currículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button botaoEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CampoProfissao;
        private System.Windows.Forms.ComboBox campoSexo;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campoEndereco;
        private System.Windows.Forms.TextBox campoSalario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox campoObservacoes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SaveFileDialog popupEnviar;
        private System.Windows.Forms.DateTimePicker campoCalendario;
        private System.Windows.Forms.CheckBox campoLinkedin;
        private System.Windows.Forms.CheckBox campoGithub;
    }
}

