namespace SeitonSystem.src.view.Pedido
{
    partial class PedidoView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoView));
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.btn_financas = new System.Windows.Forms.Button();
            this.linha = new System.Windows.Forms.Panel();
            this.btn_tbPedidos = new System.Windows.Forms.Button();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.linha2 = new System.Windows.Forms.Panel();
            this.db_pedidos = new MetroFramework.Controls.MetroGrid();
            this.coluna_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_dataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_pedidos = new System.Windows.Forms.Panel();
            this.btn_redirecionar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.cb_situacao = new System.Windows.Forms.ComboBox();
            this.lbl_situacao = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_calda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_pedidos)).BeginInit();
            this.panel_pedidos.SuspendLayout();
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
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(151, 31);
            this.btn_clientes.TabIndex = 1;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
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
            this.btn_produtos.Location = new System.Drawing.Point(149, -2);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(157, 31);
            this.btn_produtos.TabIndex = 2;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = false;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
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
            this.btn_pedido.Location = new System.Drawing.Point(438, -2);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(165, 31);
            this.btn_pedido.TabIndex = 4;
            this.btn_pedido.Text = "Pedidos";
            this.btn_pedido.UseVisualStyleBackColor = false;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedidos_Click);
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
            this.btn_financas.Location = new System.Drawing.Point(600, -2);
            this.btn_financas.Name = "btn_financas";
            this.btn_financas.Size = new System.Drawing.Size(151, 31);
            this.btn_financas.TabIndex = 5;
            this.btn_financas.Text = "Finanças";
            this.btn_financas.UseVisualStyleBackColor = false;
            this.btn_financas.Click += new System.EventHandler(this.btn_financas_Click);
            // 
            // linha
            // 
            this.linha.BackColor = System.Drawing.Color.White;
            this.linha.Location = new System.Drawing.Point(30, 206);
            this.linha.Name = "linha";
            this.linha.Size = new System.Drawing.Size(692, 2);
            this.linha.TabIndex = 9;
            // 
            // btn_tbPedidos
            // 
            this.btn_tbPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btn_tbPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tbPedidos.FlatAppearance.BorderSize = 0;
            this.btn_tbPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tbPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_tbPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tbPedidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tbPedidos.ForeColor = System.Drawing.Color.White;
            this.btn_tbPedidos.Location = new System.Drawing.Point(21, 174);
            this.btn_tbPedidos.Name = "btn_tbPedidos";
            this.btn_tbPedidos.Size = new System.Drawing.Size(93, 30);
            this.btn_tbPedidos.TabIndex = 10;
            this.btn_tbPedidos.Text = "Pedidos";
            this.btn_tbPedidos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_tbPedidos.UseVisualStyleBackColor = false;
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(154)))), ((int)(((byte)(158)))));
            this.txt_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa.ForeColor = System.Drawing.Color.White;
            this.txt_pesquisa.Location = new System.Drawing.Point(33, 210);
            this.txt_pesquisa.Multiline = true;
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(689, 35);
            this.txt_pesquisa.TabIndex = 40;
            this.txt_pesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pesquisa.Visible = false;
            this.txt_pesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pesquisa_KeyUp);
            // 
            // linha2
            // 
            this.linha2.BackColor = System.Drawing.Color.White;
            this.linha2.Location = new System.Drawing.Point(30, 246);
            this.linha2.Name = "linha2";
            this.linha2.Size = new System.Drawing.Size(692, 2);
            this.linha2.TabIndex = 41;
            this.linha2.Visible = false;
            // 
            // db_pedidos
            // 
            this.db_pedidos.AllowUserToAddRows = false;
            this.db_pedidos.AllowUserToDeleteRows = false;
            this.db_pedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.db_pedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.db_pedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.db_pedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.db_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.db_pedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.db_pedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.db_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna_id,
            this.coluna_nome,
            this.coluna_tipo,
            this.coluna_valorTotal,
            this.coluna_dataEntrega,
            this.coluna_dataPagamento,
            this.coluna_situacao});
            this.db_pedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_pedidos.DefaultCellStyle = dataGridViewCellStyle10;
            this.db_pedidos.EnableHeadersVisualStyles = false;
            this.db_pedidos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.db_pedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.db_pedidos.Location = new System.Drawing.Point(31, 248);
            this.db_pedidos.Name = "db_pedidos";
            this.db_pedidos.ReadOnly = true;
            this.db_pedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.db_pedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.db_pedidos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.db_pedidos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.db_pedidos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_pedidos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_pedidos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            this.db_pedidos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.db_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db_pedidos.Size = new System.Drawing.Size(692, 376);
            this.db_pedidos.TabIndex = 46;
            this.db_pedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_pedidos_CellContentClick);
            // 
            // coluna_id
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.coluna_id.DefaultCellStyle = dataGridViewCellStyle3;
            this.coluna_id.HeaderText = "Id ";
            this.coluna_id.Name = "coluna_id";
            this.coluna_id.ReadOnly = true;
            this.coluna_id.Width = 50;
            // 
            // coluna_nome
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.coluna_nome.DefaultCellStyle = dataGridViewCellStyle4;
            this.coluna_nome.HeaderText = "Cliente";
            this.coluna_nome.Name = "coluna_nome";
            this.coluna_nome.ReadOnly = true;
            // 
            // coluna_tipo
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.coluna_tipo.DefaultCellStyle = dataGridViewCellStyle5;
            this.coluna_tipo.HeaderText = "Pedido";
            this.coluna_tipo.Name = "coluna_tipo";
            this.coluna_tipo.ReadOnly = true;
            // 
            // coluna_valorTotal
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.coluna_valorTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.coluna_valorTotal.HeaderText = "Total";
            this.coluna_valorTotal.Name = "coluna_valorTotal";
            this.coluna_valorTotal.ReadOnly = true;
            this.coluna_valorTotal.Width = 70;
            // 
            // coluna_dataEntrega
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.coluna_dataEntrega.DefaultCellStyle = dataGridViewCellStyle7;
            this.coluna_dataEntrega.HeaderText = "Entrega";
            this.coluna_dataEntrega.Name = "coluna_dataEntrega";
            this.coluna_dataEntrega.ReadOnly = true;
            this.coluna_dataEntrega.Width = 110;
            // 
            // coluna_dataPagamento
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.coluna_dataPagamento.DefaultCellStyle = dataGridViewCellStyle8;
            this.coluna_dataPagamento.HeaderText = "Pagamento";
            this.coluna_dataPagamento.Name = "coluna_dataPagamento";
            this.coluna_dataPagamento.ReadOnly = true;
            this.coluna_dataPagamento.Width = 110;
            // 
            // coluna_situacao
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.coluna_situacao.DefaultCellStyle = dataGridViewCellStyle9;
            this.coluna_situacao.HeaderText = "Situação";
            this.coluna_situacao.Name = "coluna_situacao";
            this.coluna_situacao.ReadOnly = true;
            this.coluna_situacao.Width = 110;
            // 
            // panel_pedidos
            // 
            this.panel_pedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.panel_pedidos.Controls.Add(this.btn_redirecionar);
            this.panel_pedidos.Controls.Add(this.btn_salvar);
            this.panel_pedidos.Controls.Add(this.cb_situacao);
            this.panel_pedidos.Controls.Add(this.lbl_situacao);
            this.panel_pedidos.Location = new System.Drawing.Point(111, 634);
            this.panel_pedidos.Name = "panel_pedidos";
            this.panel_pedidos.Size = new System.Drawing.Size(474, 68);
            this.panel_pedidos.TabIndex = 47;
            this.panel_pedidos.Visible = false;
            // 
            // btn_redirecionar
            // 
            this.btn_redirecionar.BackColor = System.Drawing.Color.Transparent;
            this.btn_redirecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_redirecionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_redirecionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_redirecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.btn_redirecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redirecionar.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_redirecionar.Location = new System.Drawing.Point(388, 15);
            this.btn_redirecionar.Name = "btn_redirecionar";
            this.btn_redirecionar.Size = new System.Drawing.Size(71, 35);
            this.btn_redirecionar.TabIndex = 42;
            this.btn_redirecionar.Text = "...";
            this.btn_redirecionar.UseVisualStyleBackColor = false;
            this.btn_redirecionar.Click += new System.EventHandler(this.btn_redirecionar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(302, 15);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(70, 35);
            this.btn_salvar.TabIndex = 41;
            this.btn_salvar.Text = "Ok";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // cb_situacao
            // 
            this.cb_situacao.AllowDrop = true;
            this.cb_situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_situacao.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_situacao.ForeColor = System.Drawing.Color.Black;
            this.cb_situacao.FormattingEnabled = true;
            this.cb_situacao.Items.AddRange(new object[] {
            "Pendente",
            "Em Andamento",
            "Finalizado",
            "Cancelado"});
            this.cb_situacao.Location = new System.Drawing.Point(104, 19);
            this.cb_situacao.Name = "cb_situacao";
            this.cb_situacao.Size = new System.Drawing.Size(172, 29);
            this.cb_situacao.TabIndex = 40;
            // 
            // lbl_situacao
            // 
            this.lbl_situacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_situacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_situacao.FlatAppearance.BorderSize = 0;
            this.lbl_situacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lbl_situacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lbl_situacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_situacao.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacao.ForeColor = System.Drawing.Color.Black;
            this.lbl_situacao.Location = new System.Drawing.Point(13, 17);
            this.lbl_situacao.Name = "lbl_situacao";
            this.lbl_situacao.Size = new System.Drawing.Size(106, 30);
            this.lbl_situacao.TabIndex = 39;
            this.lbl_situacao.Text = "Situação: ";
            this.lbl_situacao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_situacao.UseVisualStyleBackColor = false;
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
            this.btn_cadastrar.Location = new System.Drawing.Point(591, 631);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(131, 82);
            this.btn_cadastrar.TabIndex = 45;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
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
            this.btn_voltar.Location = new System.Drawing.Point(21, 642);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(84, 60);
            this.btn_voltar.TabIndex = 44;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
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
            this.btn_pesquisar.Location = new System.Drawing.Point(309, 164);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(136, 40);
            this.btn_pesquisar.TabIndex = 43;
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
            this.pic_logo.Location = new System.Drawing.Point(298, -5);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(147, 154);
            this.pic_logo.TabIndex = 7;
            this.pic_logo.TabStop = false;
            // 
            // pic_calda
            // 
            this.pic_calda.BackColor = System.Drawing.Color.Transparent;
            this.pic_calda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_calda.BackgroundImage")));
            this.pic_calda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_calda.Location = new System.Drawing.Point(-1, 29);
            this.pic_calda.Name = "pic_calda";
            this.pic_calda.Size = new System.Drawing.Size(752, 123);
            this.pic_calda.TabIndex = 6;
            this.pic_calda.TabStop = false;
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(750, 723);
            this.Controls.Add(this.panel_pedidos);
            this.Controls.Add(this.db_pedidos);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.linha2);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.btn_tbPedidos);
            this.Controls.Add(this.linha);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.pic_calda);
            this.Controls.Add(this.btn_financas);
            this.Controls.Add(this.btn_pedido);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.btn_clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PedidoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seiton System";
            ((System.ComponentModel.ISupportInitialize)(this.db_pedidos)).EndInit();
            this.panel_pedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.Button btn_financas;
        private System.Windows.Forms.PictureBox pic_calda;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel linha;
        private System.Windows.Forms.Button btn_tbPedidos;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Panel linha2;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_cadastrar;
        private MetroFramework.Controls.MetroGrid db_pedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_dataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_dataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_situacao;
        private System.Windows.Forms.Panel panel_pedidos;
        private System.Windows.Forms.ComboBox cb_situacao;
        private System.Windows.Forms.Button lbl_situacao;
        private System.Windows.Forms.Button btn_redirecionar;
        private System.Windows.Forms.Button btn_salvar;
    }
}