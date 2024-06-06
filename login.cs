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

namespace Sistema_login_3
{
    public partial class formlogin : Form
    {
        CoreBrige B = new CoreBrige();
        public formlogin()
        {
            InitializeComponent();
            TxtPassword.PasswordChar = '*';
        }

        private void btmLogin_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            if (TxtUsername.Text == "" && TxtPassword.Text == "")
            {
                MessageBox.Show("Campo de usuario e senha vazio");
                label3.Text = "campo vazio";
                label4.Text = "Campo vazio";
                TxtUsername.Focus();
                TxtPassword.Focus();
                return;
            }
            else if (TxtUsername.Text == "")
            {
                MessageBox.Show("Campo de usuario vazio");
                label3.Text = "campo vazio";
                TxtUsername.Focus();
                return;
            }
            else if (TxtPassword.Text == "")
            {
                MessageBox.Show("Senha não inserida");
                label4.Text = "Campo vazio";
                TxtPassword.Focus();
                return;
            }

           

              B.loginvalido = false;

            foreach (var logins in GerenciadorLogin.Logins)
            {

                if (logins.User == TxtUsername.Text && logins.Password == TxtPassword.Text)
                {
                    B.loginvalido = true;
                    break;

                }
            }
                if (B.loginvalido)
                {
                MessageBox.Show("login feito com susseso");
                this.Hide();
                Form1 inicio = new Form1();
                inicio.ShowDialog();

                }
                else
                {
                    MessageBox.Show("login não encontrado tente novamente ou cadastra-se");

                    TxtPassword.Clear();
                    TxtUsername.Clear();
                }

            

        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar está operação", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
            
            
        }

        private void btmSingUp_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.ShowDialog();
        }
    }
}
