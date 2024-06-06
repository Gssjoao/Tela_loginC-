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
    public partial class Form1 : Form
    {

        CoreBrige B = new CoreBrige();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            B.loginvalido = false;

            if (B.loginvalido)
            {
                this.Hide();
                formlogin log = new formlogin();
                log.ShowDialog();
            }

            if (B.loginvalido)
            {
                this.Show();
            }
            else
            {
                this.Hide();
              
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formlogin log = new formlogin();
            log.ShowDialog();

       
        }

        

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair da aplicação", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastro cadastro = new FormCadastro();
            cadastro.ShowDialog();
        }
    }
}
