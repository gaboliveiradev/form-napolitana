namespace WFNapolitana
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picCalda = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCalda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // picCalda
            // 
            this.picCalda.Dock = System.Windows.Forms.DockStyle.Top;
            this.picCalda.Image = ((System.Drawing.Image)(resources.GetObject("picCalda.Image")));
            this.picCalda.Location = new System.Drawing.Point(0, 0);
            this.picCalda.Margin = new System.Windows.Forms.Padding(2);
            this.picCalda.Name = "picCalda";
            this.picCalda.Size = new System.Drawing.Size(852, 144);
            this.picCalda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCalda.TabIndex = 0;
            this.picCalda.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(17, 36);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(271, 232);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.lblMsgErro);
            this.pnFooter.Controls.Add(this.btnEntrar);
            this.pnFooter.Controls.Add(this.txt_senha);
            this.pnFooter.Controls.Add(this.lblSenha);
            this.pnFooter.Controls.Add(this.txt_usuario);
            this.pnFooter.Controls.Add(this.lblUsuario);
            this.pnFooter.Controls.Add(this.picLogo);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 170);
            this.pnFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(852, 311);
            this.pnFooter.TabIndex = 2;
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgErro.ForeColor = System.Drawing.Color.Red;
            this.lblMsgErro.Location = new System.Drawing.Point(319, 20);
            this.lblMsgErro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(0, 17);
            this.lblMsgErro.TabIndex = 7;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(323, 224);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(494, 44);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Logar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(323, 159);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(2);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '●';
            this.txt_senha.Size = new System.Drawing.Size(495, 44);
            this.txt_senha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(317, 127);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 31);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(323, 68);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(495, 44);
            this.txt_usuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(317, 36);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(108, 31);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário";
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(8, 8);
            this.picClose.Margin = new System.Windows.Forms.Padding(2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 481);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.picCalda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Napolitana - Fazer Login";
            ((System.ComponentModel.ISupportInitialize)(this.picCalda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCalda;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblMsgErro;
    }
}

