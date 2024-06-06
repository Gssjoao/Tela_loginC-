using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_login_3;
using System.Text.RegularExpressions;

namespace Sistema_login_3
{
    public partial class FormCadastro : Form
    {
        CoreBrige B = new CoreBrige();
        
        public FormCadastro()
        {
            InitializeComponent();
            this.label1.ForeColor = System.Drawing.Color.Black;
            TxtPassword.PasswordChar = '*';
        }

        private void BtmCadastrar_Click(object sender, EventArgs e)
        {
            B.User = TxtUser.Text.Trim();
            B.Password = TxtPassword.Text.Trim();
            B.email = Txtemail.Text.Trim();
            B.CPF = txtmaskCPF.Text;
            B.Phone = TxtmaskPhone.Text;

            


            if (B.Condiçoes())
            {
                this.label1.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("A senha tem que ter pelo menos 8 caracter");
                txtmaskCPF.Clear();
                Txtemail.Clear();
                TxtmaskPhone.Clear();
                TxtPassword.Clear();
                TxtUser.Clear();
                this.label1.ForeColor = System.Drawing.Color.Black;
                return;                
            }
         
        
            if (!string.IsNullOrEmpty(B.User) && !string.IsNullOrEmpty(B.Password) && !string.IsNullOrEmpty(B.email) && !string.IsNullOrEmpty(B.CPF) && !string.IsNullOrEmpty(B.Phone))
            {

               GerenciadorLogin.AdicionarLogin(B);
                MessageBox.Show("Login cadastrado com sucesso!");
                this.Hide();
                formlogin login = new formlogin();
                login.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }
        

        private void BtmExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtmLimpar_Click(object sender, EventArgs e)
        {
            txtmaskCPF.Clear();
            Txtemail.Clear();
            TxtmaskPhone.Clear();
            TxtPassword.Clear();
            TxtUser.Clear();
        }

        private void BtmCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar está operação", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }

            
        }
    }
}
