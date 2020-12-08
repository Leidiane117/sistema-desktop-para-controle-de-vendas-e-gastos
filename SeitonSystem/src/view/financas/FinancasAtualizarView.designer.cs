namespace SeitonSystem.src.view
{
    partial class FinancasAtualizarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancasAtualizarView));
            this.linha = new System.Windows.Forms.Panel();
            this.btn_titulo = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_calda = new System.Windows.Forms.PictureBox();
            this.btn_pedidos = new System.Windows.Forms.Button();
            this.btn_financas = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.panel_dados = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_tipoFluxo = new System.Windows.Forms.Label();
            this.cb_atualizar = new System.Windows.Forms.ComboBox();
            this.dt_atualizar = new System.Windows.Forms.DateTimePicker();
            this.lbl_data = new System.Windows.Forms.Label();
            this.txt_atualizarValor = new System.Windows.Forms.TextBox();
            this.txt_atualizarTitulo = new System.Windows.Forms.TextBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.txt_atualizarDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).BeginInit();
            this.panel_dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // linha
            // 
            this.linha.BackColor = System.Drawing.Color.White;
            this.linha.Location = new System.Drawing.Point(32, 254);
            this.linha.Margin = new System.Windows.Forms.Padding(4);
            this.linha.Name = "linha";
            this.linha.Size = new System.Drawing.Size(933, 2);
            this.linha.TabIndex = 39;
            // 
            // btn_titulo
            // 
            this.btn_titulo.BackColor = System.Drawing.Color.Transparent;
            this.btn_titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_titulo.FlatAppearance.BorderSize = 0;
            this.btn_titulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_titulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_titulo.ForeColor = System.Drawing.Color.White;
            this.btn_titulo.Location = new System.Drawing.Point(23, 215);
            this.btn_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_titulo.Name = "btn_titulo";
            this.btn_titulo.Size = new System.Drawing.Size(391, 36);
            this.btn_titulo.TabIndex = 36;
            this.btn_titulo.Text = "Atualizar Atividade";
            this.btn_titulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_titulo.UseVisualStyleBackColor = false;
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::SeitonSystem.Properties.Resources.logo2;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_logo.Location = new System.Drawing.Point(396, -10);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(196, 190);
            this.pic_logo.TabIndex = 148;
            this.pic_logo.TabStop = false;
            // 
            // pic_calda
            // 
            this.pic_calda.BackColor = System.Drawing.Color.Transparent;
            this.pic_calda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_calda.BackgroundImage")));
            this.pic_calda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_calda.Location = new System.Drawing.Point(-3, 34);
            this.pic_calda.Margin = new System.Windows.Forms.Padding(4);
            this.pic_calda.Name = "pic_calda";
            this.pic_calda.Size = new System.Drawing.Size(1003, 151);
            this.pic_calda.TabIndex = 147;
            this.pic_calda.TabStop = false;
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.BackColor = System.Drawing.Color.White;
            this.btn_pedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pedidos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pedidos.FlatAppearance.BorderSize = 0;
            this.btn_pedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pedidos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedidos.Location = new System.Drawing.Point(583, -1);
            this.btn_pedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(220, 38);
            this.btn_pedidos.TabIndex = 146;
            this.btn_pedidos.Text = "Pedidos";
            this.btn_pedidos.UseVisualStyleBackColor = false;
            this.btn_pedidos.Click += new System.EventHandler(this.btn_pedidos_Click);
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
            this.btn_financas.Location = new System.Drawing.Point(799, -1);
            this.btn_financas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_financas.Name = "btn_financas";
            this.btn_financas.Size = new System.Drawing.Size(201, 38);
            this.btn_financas.TabIndex = 145;
            this.btn_financas.Text = "Finanças";
            this.btn_financas.UseVisualStyleBackColor = false;
            this.btn_financas.Click += new System.EventHandler(this.btn_financas_Click);
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
            this.btn_produtos.Location = new System.Drawing.Point(197, -1);
            this.btn_produtos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(209, 38);
            this.btn_produtos.TabIndex = 144;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = false;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
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
            this.btn_clientes.Location = new System.Drawing.Point(-3, -1);
            this.btn_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(201, 38);
            this.btn_clientes.TabIndex = 143;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // panel_dados
            // 
            this.panel_dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.panel_dados.Controls.Add(this.label8);
            this.panel_dados.Controls.Add(this.txt_id);
            this.panel_dados.Controls.Add(this.lbl_id);
            this.panel_dados.Controls.Add(this.lbl_tipoFluxo);
            this.panel_dados.Controls.Add(this.cb_atualizar);
            this.panel_dados.Controls.Add(this.dt_atualizar);
            this.panel_dados.Controls.Add(this.lbl_data);
            this.panel_dados.Controls.Add(this.txt_atualizarValor);
            this.panel_dados.Controls.Add(this.txt_atualizarTitulo);
            this.panel_dados.Controls.Add(this.btn_atualizar);
            this.panel_dados.Controls.Add(this.txt_atualizarDescricao);
            this.panel_dados.Controls.Add(this.label4);
            this.panel_dados.Controls.Add(this.lbl_valor);
            this.panel_dados.Controls.Add(this.label5);
            this.panel_dados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_dados.ForeColor = System.Drawing.Color.White;
            this.panel_dados.Location = new System.Drawing.Point(32, 267);
            this.panel_dados.Margin = new System.Windows.Forms.Padding(4);
            this.panel_dados.Name = "panel_dados";
            this.panel_dados.Size = new System.Drawing.Size(933, 354);
            this.panel_dados.TabIndex = 149;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(685, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 34);
            this.label8.TabIndex = 153;
            this.label8.Text = "R$";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Enabled = false;
            this.txt_id.ForeColor = System.Drawing.Color.White;
            this.txt_id.Location = new System.Drawing.Point(707, 47);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.MaxLength = 8;
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(205, 36);
            this.txt_id.TabIndex = 19;
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(703, 12);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(61, 37);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "ID:";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_tipoFluxo
            // 
            this.lbl_tipoFluxo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipoFluxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_tipoFluxo.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbl_tipoFluxo.ForeColor = System.Drawing.Color.White;
            this.lbl_tipoFluxo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tipoFluxo.Location = new System.Drawing.Point(593, 89);
            this.lbl_tipoFluxo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipoFluxo.Name = "lbl_tipoFluxo";
            this.lbl_tipoFluxo.Size = new System.Drawing.Size(201, 33);
            this.lbl_tipoFluxo.TabIndex = 48;
            this.lbl_tipoFluxo.Text = "*Tipo de Fluxo:";
            this.lbl_tipoFluxo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cb_atualizar
            // 
            this.cb_atualizar.BackColor = System.Drawing.Color.White;
            this.cb_atualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_atualizar.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F);
            this.cb_atualizar.FormattingEnabled = true;
            this.cb_atualizar.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cb_atualizar.Location = new System.Drawing.Point(599, 126);
            this.cb_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.cb_atualizar.Name = "cb_atualizar";
            this.cb_atualizar.Size = new System.Drawing.Size(312, 38);
            this.cb_atualizar.TabIndex = 152;
            this.cb_atualizar.SelectedIndexChanged += new System.EventHandler(this.cb_atualizar_SelectedIndexChanged);
            // 
            // dt_atualizar
            // 
            this.dt_atualizar.CalendarFont = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dt_atualizar.CalendarForeColor = System.Drawing.Color.White;
            this.dt_atualizar.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dt_atualizar.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dt_atualizar.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dt_atualizar.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.dt_atualizar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.dt_atualizar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_atualizar.Location = new System.Drawing.Point(681, 177);
            this.dt_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.dt_atualizar.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dt_atualizar.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dt_atualizar.Name = "dt_atualizar";
            this.dt_atualizar.Size = new System.Drawing.Size(229, 36);
            this.dt_atualizar.TabIndex = 84;
            this.dt_atualizar.Value = new System.DateTime(2020, 11, 15, 0, 0, 0, 0);
            // 
            // lbl_data
            // 
            this.lbl_data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_data.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbl_data.ForeColor = System.Drawing.Color.White;
            this.lbl_data.Location = new System.Drawing.Point(593, 177);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(89, 34);
            this.lbl_data.TabIndex = 17;
            this.lbl_data.Text = "*Data:";
            this.lbl_data.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_atualizarValor
            // 
            this.txt_atualizarValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(177)))));
            this.txt_atualizarValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_atualizarValor.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txt_atualizarValor.ForeColor = System.Drawing.Color.White;
            this.txt_atualizarValor.Location = new System.Drawing.Point(681, 234);
            this.txt_atualizarValor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_atualizarValor.Name = "txt_atualizarValor";
            this.txt_atualizarValor.Size = new System.Drawing.Size(230, 36);
            this.txt_atualizarValor.TabIndex = 15;
            this.txt_atualizarValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_atualizarTitulo
            // 
            this.txt_atualizarTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.txt_atualizarTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_atualizarTitulo.ForeColor = System.Drawing.Color.White;
            this.txt_atualizarTitulo.Location = new System.Drawing.Point(29, 46);
            this.txt_atualizarTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_atualizarTitulo.MaxLength = 327;
            this.txt_atualizarTitulo.Multiline = true;
            this.txt_atualizarTitulo.Name = "txt_atualizarTitulo";
            this.txt_atualizarTitulo.Size = new System.Drawing.Size(665, 39);
            this.txt_atualizarTitulo.TabIndex = 14;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Location = new System.Drawing.Point(681, 292);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(231, 43);
            this.btn_atualizar.TabIndex = 12;
            this.btn_atualizar.Text = "Salvar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // txt_atualizarDescricao
            // 
            this.txt_atualizarDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.txt_atualizarDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_atualizarDescricao.ForeColor = System.Drawing.Color.White;
            this.txt_atualizarDescricao.Location = new System.Drawing.Point(29, 124);
            this.txt_atualizarDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_atualizarDescricao.MaxLength = 500;
            this.txt_atualizarDescricao.Multiline = true;
            this.txt_atualizarDescricao.Name = "txt_atualizarDescricao";
            this.txt_atualizarDescricao.Size = new System.Drawing.Size(554, 147);
            this.txt_atualizarDescricao.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_valor
            // 
            this.lbl_valor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_valor.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbl_valor.ForeColor = System.Drawing.Color.White;
            this.lbl_valor.Location = new System.Drawing.Point(592, 239);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(89, 28);
            this.lbl_valor.TabIndex = 1;
            this.lbl_valor.Text = "*Valor:";
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "*Título:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FinancasAtualizarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(997, 636);
            this.Controls.Add(this.panel_dados);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.pic_calda);
            this.Controls.Add(this.btn_pedidos);
            this.Controls.Add(this.btn_financas);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.linha);
            this.Controls.Add(this.btn_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinancasAtualizarView";
            this.Text = "Seiton System";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).EndInit();
            this.panel_dados.ResumeLayout(false);
            this.panel_dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel linha;
        private System.Windows.Forms.Button btn_titulo;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pic_calda;
        private System.Windows.Forms.Button btn_pedidos;
        private System.Windows.Forms.Button btn_financas;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Panel panel_dados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_tipoFluxo;
        private System.Windows.Forms.ComboBox cb_atualizar;
        private System.Windows.Forms.DateTimePicker dt_atualizar;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.TextBox txt_atualizarValor;
        private System.Windows.Forms.TextBox txt_atualizarTitulo;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.TextBox txt_atualizarDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}