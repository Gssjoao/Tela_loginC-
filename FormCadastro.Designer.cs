
namespace Sistema_login_3
{
    partial class FormCadastro
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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.Txtemail = new System.Windows.Forms.TextBox();
            this.BtmCadastrar = new System.Windows.Forms.Button();
            this.BtmExcluir = new System.Windows.Forms.Button();
            this.BtmCancelar = new System.Windows.Forms.Button();
            this.IblUser = new System.Windows.Forms.Label();
            this.IblPassword = new System.Windows.Forms.Label();
            this.IblEmail = new System.Windows.Forms.Label();
            this.IblCpf = new System.Windows.Forms.Label();
            this.IblPhone = new System.Windows.Forms.Label();
            this.txtmaskCPF = new System.Windows.Forms.MaskedTextBox();
            this.TxtmaskPhone = new System.Windows.Forms.MaskedTextBox();
            this.BtmLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(33, 66);
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(203, 27);
            this.TxtUser.TabIndex = 0;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(296, 66);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(222, 27);
            this.TxtPassword.TabIndex = 1;
            // 
            // Txtemail
            // 
            this.Txtemail.Location = new System.Drawing.Point(33, 159);
            this.Txtemail.Multiline = true;
            this.Txtemail.Name = "Txtemail";
            this.Txtemail.Size = new System.Drawing.Size(410, 31);
            this.Txtemail.TabIndex = 3;
            // 
            // BtmCadastrar
            // 
            this.BtmCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtmCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmCadastrar.Location = new System.Drawing.Point(415, 253);
            this.BtmCadastrar.Name = "BtmCadastrar";
            this.BtmCadastrar.Size = new System.Drawing.Size(104, 32);
            this.BtmCadastrar.TabIndex = 5;
            this.BtmCadastrar.Text = "Cadastrar";
            this.BtmCadastrar.UseVisualStyleBackColor = true;
            this.BtmCadastrar.Click += new System.EventHandler(this.BtmCadastrar_Click);
            // 
            // BtmExcluir
            // 
            this.BtmExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtmExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmExcluir.Location = new System.Drawing.Point(414, 308);
            this.BtmExcluir.Name = "BtmExcluir";
            this.BtmExcluir.Size = new System.Drawing.Size(104, 32);
            this.BtmExcluir.TabIndex = 6;
            this.BtmExcluir.Text = "Excluir";
            this.BtmExcluir.UseVisualStyleBackColor = true;
            this.BtmExcluir.Click += new System.EventHandler(this.BtmExcluir_Click);
            // 
            // BtmCancelar
            // 
            this.BtmCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtmCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmCancelar.Location = new System.Drawing.Point(414, 412);
            this.BtmCancelar.Name = "BtmCancelar";
            this.BtmCancelar.Size = new System.Drawing.Size(104, 32);
            this.BtmCancelar.TabIndex = 7;
            this.BtmCancelar.Text = "Cancelar";
            this.BtmCancelar.UseVisualStyleBackColor = true;
            this.BtmCancelar.Click += new System.EventHandler(this.BtmCancelar_Click);
            // 
            // IblUser
            // 
            this.IblUser.AutoSize = true;
            this.IblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblUser.Location = new System.Drawing.Point(12, 45);
            this.IblUser.Name = "IblUser";
            this.IblUser.Size = new System.Drawing.Size(50, 20);
            this.IblUser.TabIndex = 8;
            this.IblUser.Text = "User:";
            // 
            // IblPassword
            // 
            this.IblPassword.AutoSize = true;
            this.IblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblPassword.Location = new System.Drawing.Point(276, 45);
            this.IblPassword.Name = "IblPassword";
            this.IblPassword.Size = new System.Drawing.Size(88, 20);
            this.IblPassword.TabIndex = 9;
            this.IblPassword.Text = "Password:";
            // 
            // IblEmail
            // 
            this.IblEmail.AutoSize = true;
            this.IblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblEmail.Location = new System.Drawing.Point(12, 139);
            this.IblEmail.Name = "IblEmail";
            this.IblEmail.Size = new System.Drawing.Size(62, 20);
            this.IblEmail.TabIndex = 10;
            this.IblEmail.Text = "E-mail:";
            // 
            // IblCpf
            // 
            this.IblCpf.AutoSize = true;
            this.IblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblCpf.Location = new System.Drawing.Point(12, 253);
            this.IblCpf.Name = "IblCpf";
            this.IblCpf.Size = new System.Drawing.Size(47, 20);
            this.IblCpf.TabIndex = 11;
            this.IblCpf.Text = "CPF:";
            // 
            // IblPhone
            // 
            this.IblPhone.AutoSize = true;
            this.IblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblPhone.Location = new System.Drawing.Point(12, 352);
            this.IblPhone.Name = "IblPhone";
            this.IblPhone.Size = new System.Drawing.Size(123, 20);
            this.IblPhone.TabIndex = 12;
            this.IblPhone.Text = "Phone-number:";
            // 
            // txtmaskCPF
            // 
            this.txtmaskCPF.Location = new System.Drawing.Point(33, 277);
            this.txtmaskCPF.Mask = "000 . 000 . 000 - 00";
            this.txtmaskCPF.Name = "txtmaskCPF";
            this.txtmaskCPF.Size = new System.Drawing.Size(158, 22);
            this.txtmaskCPF.TabIndex = 13;
            // 
            // TxtmaskPhone
            // 
            this.TxtmaskPhone.Location = new System.Drawing.Point(33, 375);
            this.TxtmaskPhone.Mask = "(00) 00000 - 0000";
            this.TxtmaskPhone.Name = "TxtmaskPhone";
            this.TxtmaskPhone.Size = new System.Drawing.Size(158, 22);
            this.TxtmaskPhone.TabIndex = 14;
            // 
            // BtmLimpar
            // 
            this.BtmLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtmLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmLimpar.Location = new System.Drawing.Point(414, 365);
            this.BtmLimpar.Name = "BtmLimpar";
            this.BtmLimpar.Size = new System.Drawing.Size(104, 32);
            this.BtmLimpar.TabIndex = 15;
            this.BtmLimpar.Text = "Limpar";
            this.BtmLimpar.UseVisualStyleBackColor = true;
            this.BtmLimpar.Click += new System.EventHandler(this.BtmLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(293, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = " deve ter pelo menos 8 caracteres";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtmLimpar);
            this.Controls.Add(this.TxtmaskPhone);
            this.Controls.Add(this.txtmaskCPF);
            this.Controls.Add(this.IblPhone);
            this.Controls.Add(this.IblCpf);
            this.Controls.Add(this.IblEmail);
            this.Controls.Add(this.IblPassword);
            this.Controls.Add(this.IblUser);
            this.Controls.Add(this.BtmCancelar);
            this.Controls.Add(this.BtmExcluir);
            this.Controls.Add(this.BtmCadastrar);
            this.Controls.Add(this.Txtemail);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox Txtemail;
        private System.Windows.Forms.Button BtmCadastrar;
        private System.Windows.Forms.Button BtmExcluir;
        private System.Windows.Forms.Button BtmCancelar;
        private System.Windows.Forms.Label IblUser;
        private System.Windows.Forms.Label IblPassword;
        private System.Windows.Forms.Label IblEmail;
        private System.Windows.Forms.Label IblCpf;
        private System.Windows.Forms.Label IblPhone;
        private System.Windows.Forms.MaskedTextBox txtmaskCPF;
        private System.Windows.Forms.MaskedTextBox TxtmaskPhone;
        private System.Windows.Forms.Button BtmLimpar;
        private System.Windows.Forms.Label label1;
    }
}