
namespace Sistema_login_3
{
    partial class formlogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.btmLogin = new System.Windows.Forms.Button();
            this.btmSingUp = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // btmLogin
            // 
            this.btmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLogin.Location = new System.Drawing.Point(12, 245);
            this.btmLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmLogin.Name = "btmLogin";
            this.btmLogin.Size = new System.Drawing.Size(104, 37);
            this.btmLogin.TabIndex = 2;
            this.btmLogin.Text = "Log In";
            this.btmLogin.UseVisualStyleBackColor = true;
            this.btmLogin.Click += new System.EventHandler(this.btmLogin_Click);
            // 
            // btmSingUp
            // 
            this.btmSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSingUp.Location = new System.Drawing.Point(262, 245);
            this.btmSingUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmSingUp.Name = "btmSingUp";
            this.btmSingUp.Size = new System.Drawing.Size(106, 37);
            this.btmSingUp.TabIndex = 3;
            this.btmSingUp.Text = "Sing Up";
            this.btmSingUp.UseVisualStyleBackColor = true;
            this.btmSingUp.Click += new System.EventHandler(this.btmSingUp_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(57, 164);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(253, 36);
            this.TxtPassword.TabIndex = 4;
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsername.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(57, 53);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(253, 34);
            this.TxtUsername.TabIndex = 5;
            // 
            // btmCancelar
            // 
            this.btmCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCancelar.Location = new System.Drawing.Point(132, 245);
            this.btmCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(113, 37);
            this.btmCancelar.TabIndex = 6;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            this.btmCancelar.Click += new System.EventHandler(this.btmCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(53, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 8;
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 305);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btmCancelar);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.btmSingUp);
            this.Controls.Add(this.btmLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmLogin;
        private System.Windows.Forms.Button btmSingUp;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Button btmCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}