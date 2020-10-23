namespace SeitonSystem.src.view
{
    partial class FinançasViewGráficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinançasViewGráficos));
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.btn_financas = new System.Windows.Forms.Button();
            this.pic_calda = new System.Windows.Forms.PictureBox();
            this.ButtonProdutos = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(12, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "Evolução Mensal/Vendas";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(415, 197);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.DodgerBlue};
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Vendas";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Gastos";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Lucro%";
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(352, 201);
            this.chart1.TabIndex = 100;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(16, 197);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.MediumSpringGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty};
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Pedido Kit Trufas";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Pedido Kit Ovo de Páscoa";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Pedido Kit dia dos Namorados";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Pedido Kit Bolo de Pote";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Outros";
            this.chart2.Series.Add(series17);
            this.chart2.Series.Add(series18);
            this.chart2.Series.Add(series19);
            this.chart2.Series.Add(series20);
            this.chart2.Series.Add(series21);
            this.chart2.Size = new System.Drawing.Size(393, 201);
            this.chart2.TabIndex = 102;
            // 
            // gastos
            // 
            chartArea6.Name = "ChartArea1";
            this.gastos.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.gastos.Legends.Add(legend6);
            this.gastos.Location = new System.Drawing.Point(12, 424);
            this.gastos.Name = "gastos";
            this.gastos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.gastos.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Teal};
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Transporte";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Aluguel";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Eletricidade";
            series25.ChartArea = "ChartArea1";
            series25.Legend = "Legend1";
            series25.Name = "Matéria Prima";
            series26.ChartArea = "ChartArea1";
            series26.Legend = "Legend1";
            series26.Name = "Outros";
            this.gastos.Series.Add(series22);
            this.gastos.Series.Add(series23);
            this.gastos.Series.Add(series24);
            this.gastos.Series.Add(series25);
            this.gastos.Series.Add(series26);
            this.gastos.Size = new System.Drawing.Size(397, 197);
            this.gastos.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(411, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Evolução Mensal/Lucro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Evolução Mensal/Gastos";
            // 
            // btn_clientes
            // 
            this.btn_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clientes.BackColor = System.Drawing.Color.White;
            this.btn_clientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clientes.Location = new System.Drawing.Point(-1, -1);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(180, 31);
            this.btn_clientes.TabIndex = 106;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            // 
            // btn_produtos
            // 
            this.btn_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_produtos.BackColor = System.Drawing.Color.White;
            this.btn_produtos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_produtos.FlatAppearance.BorderSize = 0;
            this.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produtos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_produtos.Location = new System.Drawing.Point(145, -1);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(179, 31);
            this.btn_produtos.TabIndex = 107;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = false;
            // 
            // btn_pedido
            // 
            this.btn_pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pedido.BackColor = System.Drawing.Color.White;
            this.btn_pedido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pedido.FlatAppearance.BorderSize = 0;
            this.btn_pedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pedido.Location = new System.Drawing.Point(410, -1);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(187, 31);
            this.btn_pedido.TabIndex = 108;
            this.btn_pedido.Text = "Pedidos";
            this.btn_pedido.UseVisualStyleBackColor = false;
            // 
            // btn_financas
            // 
            this.btn_financas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_financas.BackColor = System.Drawing.Color.White;
            this.btn_financas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_financas.FlatAppearance.BorderSize = 0;
            this.btn_financas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_financas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu;
            this.btn_financas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_financas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_financas.Location = new System.Drawing.Point(562, -1);
            this.btn_financas.Name = "btn_financas";
            this.btn_financas.Size = new System.Drawing.Size(217, 31);
            this.btn_financas.TabIndex = 109;
            this.btn_financas.Text = "Finanças";
            this.btn_financas.UseVisualStyleBackColor = false;
            // 
            // pic_calda
            // 
            this.pic_calda.BackColor = System.Drawing.Color.Transparent;
            this.pic_calda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_calda.BackgroundImage")));
            this.pic_calda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_calda.Location = new System.Drawing.Point(-61, 26);
            this.pic_calda.Name = "pic_calda";
            this.pic_calda.Size = new System.Drawing.Size(921, 123);
            this.pic_calda.TabIndex = 110;
            this.pic_calda.TabStop = false;
            // 
            // ButtonProdutos
            // 
            this.ButtonProdutos.BackColor = System.Drawing.Color.Transparent;
            this.ButtonProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProdutos.FlatAppearance.BorderSize = 0;
            this.ButtonProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProdutos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProdutos.ForeColor = System.Drawing.Color.White;
            this.ButtonProdutos.Location = new System.Drawing.Point(310, 155);
            this.ButtonProdutos.Name = "ButtonProdutos";
            this.ButtonProdutos.Size = new System.Drawing.Size(99, 32);
            this.ButtonProdutos.TabIndex = 111;
            this.ButtonProdutos.Text = "Gráficos";
            this.ButtonProdutos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ButtonProdutos.UseVisualStyleBackColor = false;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImprimir.BackColor = System.Drawing.Color.Transparent;
            this.buttonImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImprimir.BackgroundImage")));
            this.buttonImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.ForeColor = System.Drawing.Color.White;
            this.buttonImprimir.Location = new System.Drawing.Point(167, 685);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(143, 28);
            this.buttonImprimir.TabIndex = 118;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImprimir.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::SeitonSystem.Properties.Resources.icone_voltar2;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.Location = new System.Drawing.Point(16, 669);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 60);
            this.button9.TabIndex = 119;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.BackgroundImage = global::SeitonSystem.Properties.Resources.logo2;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_logo.Location = new System.Drawing.Point(310, -13);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(147, 162);
            this.pic_logo.TabIndex = 120;
            this.pic_logo.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(499, 442);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 121;
            // 
            // FinançasViewGráficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(774, 741);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.ButtonProdutos);
            this.Controls.Add(this.pic_calda);
            this.Controls.Add(this.btn_financas);
            this.Controls.Add(this.btn_pedido);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gastos);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinançasViewGráficos";
            this.Text = "Seiton System";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_calda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart gastos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.Button btn_financas;
        private System.Windows.Forms.PictureBox pic_calda;
        private System.Windows.Forms.Button ButtonProdutos;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}