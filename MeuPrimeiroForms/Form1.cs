using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroForms
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        

       
        private void btnEnviar(object sender, EventArgs e)
        {
            popupEnviar.ShowDialog();
            
        }


        private string verificaCheckbox(CheckBox valida,string tipo)
        {


            if (tipo == "Github")
            {
                if (valida.Checked == true)
                {
                    return "Github";

                }
                else
                {
                    return " ";
                }
            }
            else
            {
                if (valida.Checked == true)
                {
                    return "Linkedin";

                }
                else
                {
                    return " ";
                }
               
            }


            

        }





        private void SalvarArquivoLocal(object sender, CancelEventArgs e)
        {
            string caminho = popupEnviar.FileName;
            string a = "Nome: " + campoNome.Text + "\nSexo: " + campoSexo.Text + "\nProfissão: " + CampoProfissao.Text + "\nEndereço: " + campoEndereco.Text
                + "\nNascimento: " + campoCalendario.Text + "\nEmail: " + campoEmail.Text + "\nTelefone: " + campoTelefone.Text + "\nPretensao Salarial: " + campoSalario.Text
                + "\nRedes Sociais: " + "\n" + verificaCheckbox(campoGithub, "Github") + verificaCheckbox(campoLinkedin, "Linkedin") + "\nObservações: " + campoObservacoes.Text;
            File.WriteAllText(caminho,a);
          //  txtTeste.Text = a;
            MessageBox.Show("Arquivo salvo com sucesso na pasta: " + caminho);
        }
    }
}
