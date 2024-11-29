﻿namespace ta_liberado
{
    partial class LoginForm
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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelVersao = new System.Windows.Forms.Label();
            this.buttonEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonNovoUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelAlertaLogin = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(137, 143);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(182, 20);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(85, 146);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(43, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Usuário";
            this.labelUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(137, 175);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(182, 20);
            this.textBoxSenha.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(85, 178);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(38, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Senha";
            this.labelPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(83, 86);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(267, 29);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "TA LIBERADO 2 👍";
            // 
            // labelVersao
            // 
            this.labelVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersao.AutoSize = true;
            this.labelVersao.Location = new System.Drawing.Point(391, 263);
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelVersao.Size = new System.Drawing.Size(22, 13);
            this.labelVersao.TabIndex = 4;
            this.labelVersao.Text = "3.0";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Depth = 0;
            this.buttonEntrar.Location = new System.Drawing.Point(120, 218);
            this.buttonEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Primary = true;
            this.buttonEntrar.Size = new System.Drawing.Size(75, 23);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            // 
            // buttonNovoUsuario
            // 
            this.buttonNovoUsuario.Depth = 0;
            this.buttonNovoUsuario.Location = new System.Drawing.Point(211, 218);
            this.buttonNovoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNovoUsuario.Name = "buttonNovoUsuario";
            this.buttonNovoUsuario.Primary = true;
            this.buttonNovoUsuario.Size = new System.Drawing.Size(108, 23);
            this.buttonNovoUsuario.TabIndex = 5;
            this.buttonNovoUsuario.Text = "Novo Usuário";
            this.buttonNovoUsuario.UseVisualStyleBackColor = true;
            // 
            // labelAlertaLogin
            // 
            this.labelAlertaLogin.AutoSize = true;
            this.labelAlertaLogin.Depth = 0;
            this.labelAlertaLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAlertaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAlertaLogin.Location = new System.Drawing.Point(134, 126);
            this.labelAlertaLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAlertaLogin.Name = "labelAlertaLogin";
            this.labelAlertaLogin.Size = new System.Drawing.Size(0, 19);
            this.labelAlertaLogin.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ta_liberado.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(440, 285);
            this.Controls.Add(this.labelAlertaLogin);
            this.Controls.Add(this.buttonNovoUsuario);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelVersao);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsuario);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Sizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelVersao;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEntrar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNovoUsuario;
        private MaterialSkin.Controls.MaterialLabel labelAlertaLogin;
    }
}