namespace SeitonSystem.view
{
    partial class ClienteView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteView));
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_financas = new System.Windows.Forms.Button();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_tbClientes = new System.Windows.Forms.Button();
            this.linha = new System.Windows.Forms.Panel();
            this.linha2 = new System.Windows.Forms.Panel();
            this.db_clientes = new MetroFramework.Controls.MetroGrid();
            this.db_excluidos = new MetroFramework.Controls.MetroGrid();
            this.btn_tbDesativados = new System.Windows.Forms.Button();
            this.panel_excluidos = new System.Windows.Forms.Panel();
            this.btn_reativar = new System.Windows.Forms.Button();
            this.panel_clientes = new System.Windows.Forms.Panel();
            this.btn_desativar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_calda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_excluidos)).BeginInit();
            this.panel_excluidos.SuspendLayout();
            this.panel_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.White;
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.Location = new System.Drawing.Point(-1, -2);
            this.btn_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(201, 38);
            this.btn_clientes.TabIndex = 0;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_produtos
            // 
            this.btn_produtos.BackColor = System.Drawing.Color.White;
            this.btn_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_produtos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_produtos.FlatAppearance.BorderSize = 0;
            this.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produtos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.Location = new System.Drawing.Point(199, -2);
            this.btn_produtos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(209, 38);
            this.btn_produtos.TabIndex = 1;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = false;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // btn_financas
            // 
            this.btn_financas.BackColor = System.Drawing.Color.White;
            this.btn_financas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_financas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_financas.FlatAppearance.BorderSize = 0;
            this.btn_financas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_financas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_financas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_financas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financas.Location = new System.Drawing.Point(800, -2);
            this.btn_financas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_financas.Name = "btn_financas";
            this.btn_financas.Size = new System.Drawing.Size(201, 38);
            this.btn_financas.TabIndex = 2;
            this.btn_financas.Text = "Finanças";
            this.btn_financas.UseVisualStyleBackColor = false;
            this.btn_financas.Click += new System.EventHandler(this.btn_financas_Click);
            // 
            // btn_pedido
            // 
            this.btn_pedido.BackColor = System.Drawing.Color.White;
            this.btn_pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pedido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pedido.FlatAppearance.BorderSize = 0;
            this.btn_pedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedido.Location = new System.Drawing.Point(584, -2);
            this.btn_pedido.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(220, 38);
            this.btn_pedido.TabIndex = 3;
            this.btn_pedido.Text = "Pedidos";
            this.btn_pedido.UseVisualStyleBackColor = false;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(154)))), ((int)(((byte)(158)))));
            this.txt_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa.ForeColor = System.Drawing.Color.White;
            this.txt_pesquisa.Location = new System.Drawing.Point(44, 262);
            this.txt_pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pesquisa.Multiline = true;
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(919, 37);
            this.txt_pesquisa.TabIndex = 6;
            this.txt_pesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pesquisa.Visible = false;
            this.txt_pesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pesquisa_KeyUp);
            // 
            // btn_tbClientes
            // 
            this.btn_tbClientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_tbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tbClientes.FlatAppearance.BorderSize = 0;
            this.btn_tbClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tbClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_tbClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tbClientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tbClientes.ForeColor = System.Drawing.Color.White;
            this.btn_tbClientes.Location = new System.Drawing.Point(28, 220);
            this.btn_tbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tbClientes.Name = "btn_tbClientes";
            this.btn_tbClientes.Size = new System.Drawing.Size(124, 37);
            this.btn_tbClientes.TabIndex = 7;
            this.btn_tbClientes.Text = "Clientes";
            this.btn_tbClientes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_tbClientes.UseVisualStyleBackColor = false;
            this.btn_tbClientes.Click += new System.EventHandler(this.btn_tbClientes_Click);
            // 
            // linha
            // 
            this.linha.BackColor = System.Drawing.Color.White;
            this.linha.Location = new System.Drawing.Point(40, 257);
            this.linha.Margin = new System.Windows.Forms.Padding(4);
            this.linha.Name = "linha";
            this.linha.Size = new System.Drawing.Size(923, 2);
            this.linha.TabIndex = 8;
            // 
            // linha2
            // 
            this.linha2.BackColor = System.Drawing.Color.White;
            this.linha2.Location = new System.Drawing.Point(40, 299);
            this.linha2.Margin = new System.Windows.Forms.Padding(4);
            this.linha2.Name = "linha2";
            this.linha2.Size = new System.Drawing.Size(923, 2);
            this.linha2.TabIndex = 11;
            this.linha2.Visible = false;
            // 
            // db_clientes
            // 
            this.db_clientes.AllowUserToAddRows = false;
            this.db_clientes.AllowUserToDeleteRows = false;
            this.db_clientes.AllowUserToResizeRows = false;
            this.db_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.db_clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.db_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.db_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.db_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.db_clientes.EnableHeadersVisualStyles = false;
            this.db_clientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.db_clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.db_clientes.Location = new System.Drawing.Point(39, 303);
            this.db_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.db_clientes.Name = "db_clientes";
            this.db_clientes.ReadOnly = true;
            this.db_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.db_clientes.RowHeadersWidth = 51;
            this.db_clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.db_clientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.db_clientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_clientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_clientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            this.db_clientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.db_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db_clientes.Size = new System.Drawing.Size(923, 427);
            this.db_clientes.TabIndex = 36;
            this.db_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_clientes_CellContentClick);
            // 
            // db_excluidos
            // 
            this.db_excluidos.AllowUserToAddRows = false;
            this.db_excluidos.AllowUserToDeleteRows = false;
            this.db_excluidos.AllowUserToResizeColumns = false;
            this.db_excluidos.AllowUserToResizeRows = false;
            this.db_excluidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.db_excluidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.db_excluidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.db_excluidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.db_excluidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_excluidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.db_excluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_excluidos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_excluidos.DefaultCellStyle = dataGridViewCellStyle5;
            this.db_excluidos.EnableHeadersVisualStyles = false;
            this.db_excluidos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.db_excluidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.db_excluidos.Location = new System.Drawing.Point(39, 303);
            this.db_excluidos.Margin = new System.Windows.Forms.Padding(4);
            this.db_excluidos.MultiSelect = false;
            this.db_excluidos.Name = "db_excluidos";
            this.db_excluidos.ReadOnly = true;
            this.db_excluidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_excluidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.db_excluidos.RowHeadersWidth = 51;
            this.db_excluidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.db_excluidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db_excluidos.Size = new System.Drawing.Size(923, 427);
            this.db_excluidos.TabIndex = 37;
            this.db_excluidos.Visible = false;
            this.db_excluidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_excluidos_CellContentClick);
            // 
            // btn_tbDesativados
            // 
            this.btn_tbDesativados.BackColor = System.Drawing.Color.Transparent;
            this.btn_tbDesativados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tbDesativados.FlatAppearance.BorderSize = 0;
            this.btn_tbDesativados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tbDesativados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_tbDesativados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tbDesativados.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tbDesativados.ForeColor = System.Drawing.Color.White;
            this.btn_tbDesativados.Location = new System.Drawing.Point(800, 220);
            this.btn_tbDesativados.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tbDesativados.Name = "btn_tbDesativados";
            this.btn_tbDesativados.Size = new System.Drawing.Size(180, 37);
            this.btn_tbDesativados.TabIndex = 38;
            this.btn_tbDesativados.Text = "Desativados";
            this.btn_tbDesativados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_tbDesativados.UseVisualStyleBackColor = false;
            this.btn_tbDesativados.Click += new System.EventHandler(this.btn_tbDesativados_Click);
            // 
            // panel_excluidos
            // 
            this.panel_excluidos.BackgroundImage = global::SeitonSystem.Properties.Resources.retangulo;
            this.panel_excluidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_excluidos.Controls.Add(this.btn_reativar);
            this.panel_excluidos.Location = new System.Drawing.Point(584, 726);
            this.panel_excluidos.Margin = new System.Windows.Forms.Padding(4);
            this.panel_excluidos.Name = "panel_excluidos";
            this.panel_excluidos.Size = new System.Drawing.Size(196, 87);
            this.panel_excluidos.TabIndex = 43;
            this.panel_excluidos.Visible = false;
            // 
            // btn_reativar
            // 
            this.btn_reativar.BackColor = System.Drawing.Color.Transparent;
            this.btn_reativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reativar.FlatAppearance.BorderSize = 0;
            this.btn_reativar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reativar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_reativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reativar.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reativar.ForeColor = System.Drawing.Color.Black;
            this.btn_reativar.Image = global::SeitonSystem.Properties.Resources.icone_recuperar;
            this.btn_reativar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_reativar.Location = new System.Drawing.Point(24, 15);
            this.btn_reativar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reativar.Name = "btn_reativar";
            this.btn_reativar.Size = new System.Drawing.Size(147, 44);
            this.btn_reativar.TabIndex = 41;
            this.btn_reativar.Text = "    Reativar";
            this.btn_reativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reativar.UseVisualStyleBackColor = false;
            this.btn_reativar.Click += new System.EventHandler(this.btn_reativar_Click);
            // 
            // panel_clientes
            // 
            this.panel_clientes.BackgroundImage = global::SeitonSystem.Properties.Resources.retangulo;
            this.panel_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_clientes.Controls.Add(this.btn_desativar);
            this.panel_clientes.Controls.Add(this.btn_atualizar);
            this.panel_clientes.Location = new System.Drawing.Point(148, 726);
            this.panel_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.panel_clientes.Name = "panel_clientes";
            this.panel_clientes.Size = new System.Drawing.Size(196, 93);
            this.panel_clientes.TabIndex = 42;
            this.panel_clientes.Visible = false;
            // 
            // btn_desativar
            // 
            this.btn_desativar.BackColor = System.Drawing.Color.Transparent;
            this.btn_desativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desativar.FlatAppearance.BorderSize = 0;
            this.btn_desativar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_desativar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_desativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desativar.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desativar.ForeColor = System.Drawing.Color.Black;
            this.btn_desativar.Image = ((System.Drawing.Image)(resources.GetObject("btn_desativar.Image")));
            this.btn_desativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_desativar.Location = new System.Drawing.Point(29, 41);
            this.btn_desativar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_desativar.Name = "btn_desativar";
            this.btn_desativar.Size = new System.Drawing.Size(137, 34);
            this.btn_desativar.TabIndex = 39;
            this.btn_desativar.Text = "Desativar";
            this.btn_desativar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_desativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_desativar.UseVisualStyleBackColor = false;
            this.btn_desativar.Click += new System.EventHandler(this.btn_desativar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_atualizar.Image")));
            this.btn_atualizar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_atualizar.Location = new System.Drawing.Point(29, 4);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(152, 37);
            this.btn_atualizar.TabIndex = 40;
            this.btn_atualizar.Text = "   Atualizar";
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Image = global::SeitonSystem.Properties.Resources.icone_voltar2;
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.Location = new System.Drawing.Point(28, 739);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(112, 74);
            this.btn_voltar.TabIndex = 16;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar.Location = new System.Drawing.Point(788, 726);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(175, 101);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Image = global::SeitonSystem.Properties.Resources.icone_lupa;
            this.btn_pesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_pesquisar.Location = new System.Drawing.Point(412, 208);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(181, 49);
            this.btn_pesquisar.TabIndex = 10;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::SeitonSystem.Properties.Resources.logo2;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_logo.Location = new System.Drawing.Point(397, -6);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(196, 190);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 5;
            this.pic_logo.TabStop = false;
            // 
            // pic_calda
            // 
            this.pic_calda.BackColor = System.Drawing.Color.Transparent;
            this.pic_calda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_calda.BackgroundImage")));
            this.pic_calda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_calda.Location = new System.Drawing.Point(-1, 36);
            this.pic_calda.Margin = new System.Windows.Forms.Padding(4);
            this.pic_calda.Name = "pic_calda";
            this.pic_calda.Size = new System.Drawing.Size(1002, 148);
            this.pic_calda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_calda.TabIndex = 4;
            this.pic_calda.TabStop = false;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1000, 1025);
            this.Controls.Add(this.panel_excluidos);
            this.Controls.Add(this.panel_clientes);
            this.Controls.Add(this.btn_tbDesativados);
            this.Controls.Add(this.db_excluidos);
            this.Controls.Add(this.db_clientes);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.linha2);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.linha);
            this.Controls.Add(this.btn_tbClientes);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.pic_calda);
            this.Controls.Add(this.btn_pedido);
            this.Controls.Add(this.btn_financas);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.btn_clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ClienteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seiton System";
            ((System.ComponentModel.ISupportInitialize)(this.db_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_excluidos)).EndInit();
            this.panel_excluidos.ResumeLayout(false);
            this.panel_clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_financas;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.PictureBox pic_calda;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_tbClientes;
        private System.Windows.Forms.Panel linha;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Panel linha2;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        private MetroFramework.Controls.MetroGrid db_clientes;
        private MetroFramework.Controls.MetroGrid db_excluidos;
        private System.Windows.Forms.Button btn_tbDesativados;
        private System.Windows.Forms.Button btn_desativar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_reativar;
        private System.Windows.Forms.Panel panel_clientes;
        private System.Windows.Forms.Panel panel_excluidos;
    }
}