namespace SeitonSystem.view
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.panel_dados = new System.Windows.Forms.Panel();
            this.pic_calda = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_titulo = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_limpar
            // 
            resources.ApplyResources(this.btn_limpar, "btn_limpar");
            this.btn_limpar.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_atualizar
            // 
            resources.ApplyResources(this.btn_atualizar, "btn_atualizar");
            this.btn_atualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            // 
            // panel_dados
            // 
            resources.ApplyResources(this.panel_dados, "panel_dados");
            this.panel_dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.panel_dados.Controls.Add(this.textBox1);
            this.panel_dados.Controls.Add(this.txt_nome);
            this.panel_dados.Controls.Add(this.btn_titulo);
            this.panel_dados.Controls.Add(this.pic_logo);
            this.panel_dados.Controls.Add(this.btn_limpar);
            this.panel_dados.Controls.Add(this.btn_atualizar);
            this.panel_dados.ForeColor = System.Drawing.Color.White;
            this.panel_dados.Name = "panel_dados";
            // 
            // pic_calda
            // 
            resources.ApplyResources(this.pic_calda, "pic_calda");
            this.pic_calda.BackColor = System.Drawing.Color.Transparent;
            this.pic_calda.Name = "pic_calda";
            this.pic_calda.TabStop = false;
            // 
            // pic_logo
            // 
            resources.ApplyResources(this.pic_logo, "pic_logo");
            this.pic_logo.BackgroundImage = global::SeitonSystem.Properties.Resources.logo2;
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.TabStop = false;
            // 
            // btn_titulo
            // 
            resources.ApplyResources(this.btn_titulo, "btn_titulo");
            this.btn_titulo.BackColor = System.Drawing.Color.Transparent;
            this.btn_titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_titulo.FlatAppearance.BorderSize = 0;
            this.btn_titulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_titulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_titulo.ForeColor = System.Drawing.Color.White;
            this.btn_titulo.Name = "btn_titulo";
            this.btn_titulo.UseVisualStyleBackColor = false;
            this.btn_titulo.Click += new System.EventHandler(this.btn_titulo_Click);
            // 
            // txt_nome
            // 
            resources.ApplyResources(this.txt_nome, "txt_nome");
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome.ForeColor = System.Drawing.Color.LightGray;
            this.txt_nome.Name = "txt_nome";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Name = "textBox1";
            // 
            // LoginView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel_dados);
            this.Controls.Add(this.pic_calda);
            this.Name = "LoginView";
            this.panel_dados.ResumeLayout(false);
            this.panel_dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Panel panel_dados;
        private System.Windows.Forms.PictureBox pic_calda;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_titulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_nome;
    }
}