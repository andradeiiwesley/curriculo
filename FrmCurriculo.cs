using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projetoweb_Currículo
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalvarCurriculo()
        {
            var linha =

           "Nome: " +
           txtNome.Text + "; " + "\n" +
           "Sobrenome: " +
           txtSobrenome.Text + "; " + "\n" +
           "Data de nascimento: " +
           mskData.Text + "; " + "\n" +
           "Email: " +
           textEmail.Text + "; " + "\n" +
           "Telefone: " +
           mskTel.Text + "; " + "\n" +
           "CEP: " +
           mskCEP.Text + "; " + "\n" +
           "Logradouro: " +
           txtLogradouro.Text + "; " + "\n" +
           "Cidade: " +
           txtCidade.Text + "; " + "\n" +
           "Número: " +
           textNum.Text + "; " + "\n" +
           "Bairro: " +
           txtBairro.Text + "; " + "\n" +
           "UF: " +
           txtUF.Text + ";" + "\n" +
           "Está se candidatando para primeiro emprego: " +
           cmbEmp.Text + "; " + "\n" +
           "Interesse no trabalho remoto: " +
           cmbRem.Text + "; " + "\n" +
           "Remuneração pretendida: " +
           mskRemuneração.Text + "; " + "\n" +
           "Possui site ou blog: " +
           cmbSite.Text + "; " + "\n" +
           "URL: " +
           textUrl.Text + "; " + "\n" +
           "Qualidades: " +
           textQualidade1.Text + "; " +  
           textQualidade2.Text + "; " + 
           textQualidade3.Text + "; " +
           textQualidade4.Text + "; " + "\n" + 
           "Cursos: " +
           textCurso1.Text + "; " + 
           textCursos.Text + "; ";

            MessageBox.Show(linha); using (StreamWriter arquivo = new StreamWriter(@"C:\\out\\Curriculo.txt", true))
                arquivo.WriteLine(linha);


        }

        private void LimparCurriculo()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            mskData.Text = "";
            textEmail.Text = "";
            mskTel.Text = "";
            mskCEP.Text = "";
            txtLogradouro.Text = "";
            txtCidade.Text = "";
            textNum.Text = "";
            txtBairro.Text = "";
            txtUF.Text = "";
            cmbEmp.SelectedIndex = -1;
            cmbRem.SelectedIndex = -1;
            mskRemuneração.Text = "";
            cmbSite.SelectedIndex = -1;
            textUrl.Text = "";
            textQualidade1.Text = "";
            textQualidade2.Text = "";
            textQualidade3.Text = "";
            textQualidade4.Text = "";
            textCurso1.Text = "";
            textCursos.Text = "";
            txtNome.Focus();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                if(MessageBox.Show("Deseja salvar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Currículo salvo com sucesso!");
                    SalvarCurriculo();
                    LimparCurriculo();

                }
                else
                {
                    MessageBox.Show("Operação cancelada!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimparCurriculo();
                }
                
               


            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskTextDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {



            if (Util.validarEMAIL(textEmail.Text))
            {
                textEmail.BackColor = Color.Green;
            }
            else
            {
                textEmail.BackColor = Color.Red;

            }
        }

        private void maskTextCell_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskTextCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textRem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textUrl_TextChanged(object sender, EventArgs e)
        {
            if (Util.validarSite_Blog(textUrl.Text))
            {
                textUrl.BackColor = Color.Green;
            }
            else
            {
                textUrl.BackColor = Color.Red;

            }
        }

        private void textCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is FrmMenu)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private bool validarForm()
        {
            bool formValido;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu nome.");
                txtNome.Focus();
                formValido = false;
            }
            else if (txtSobrenome.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu sobrenome.");
                txtSobrenome.Focus();
                formValido = false;
            }
            else if (mskData.Text == "")
            {
                MessageBox.Show("Por favor, informe a sua data de nascimento.");
                mskData.Focus();
                formValido = false;
            }
            else if (textEmail.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu email.");
                textEmail.Focus();
                formValido = false;
            }
            else if (mskTel.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu número de telefone.");
                mskTel.Focus();
                formValido = false;
            }
            else if (mskCEP.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu CEP.");
                mskCEP.Focus();
                formValido = false;
            }
            else if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu logradouro.");
                txtLogradouro.Focus();
                formValido = false;
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Por favor, informe sua cidade");
                txtCidade.Focus();
                formValido = false;
            }
            else if (textNum.Text == "")
            {
                MessageBox.Show("Por favor, informe o número do seu endereço.");
                textNum.Focus();
                formValido = false;
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu bairro.");
                txtBairro.Focus();
                formValido = false;
            }
            else if (txtUF.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu UF.");
                txtUF.Focus();
                formValido = false;
            }
            else if (txtUF.Text == "")
            {
                MessageBox.Show("Por favor, informe o seu UF.");
                txtUF.Focus();
                formValido = false;
            }
            else if (cmbEmp.Text == "")
            {
                MessageBox.Show("Por favor, informe se está se candidatando para seu primeiro emprego.");
                cmbEmp.Focus();
                formValido = false;
            }
            else if (cmbRem.Text == "")
            {
                MessageBox.Show("Por favor, informe se possui interesse para o trabalho remoto.");
                cmbRem.Focus();
                formValido = false;
            }
            else if (mskRemuneração.Text == "")
            {
                MessageBox.Show("Por favor, informe a sua remuneração pretendida.");
                mskRemuneração.Focus();
                formValido = false;
            }
            else if (cmbSite.Text == "")
            {
                MessageBox.Show("Por favor, informe se você possui site ou blog.");
                cmbSite.Focus();
                formValido = false;
            }
            else if (textQualidade1.Text == "")
            {
                MessageBox.Show("Por favor, informe no mínimo 3 qualidades.");
                textQualidade1.Focus();
                formValido = false;
            }
            else if (textQualidade2.Text == "")
            {
                MessageBox.Show("Por favor, informe no mínimo 3 qualidades.");
                textQualidade2.Focus();
                formValido = false;
            }
            else if (textQualidade3.Text == "")
            {
                MessageBox.Show("Por favor, informe no mínimo 3 qualidades.");
                textQualidade3.Focus();
                formValido = false;
            }
            else if (textCurso1.Text == "")
            {
                MessageBox.Show("Por favor, informe no mínimo 1 curso realizado.");
                textCurso1.Focus();
                formValido = false;
            }
            else
            {
                formValido = true;
            }

            return formValido;


        }

        private void mskRemuneração_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach(Form formAberto in Application.OpenForms)
                {
                    if (formAberto is FrmMenu)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }
    }
}
