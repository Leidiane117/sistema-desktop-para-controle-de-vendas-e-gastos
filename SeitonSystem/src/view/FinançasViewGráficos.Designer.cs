using SeitonSystem.src.dto;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinançasViewGráficos));
            this.button9 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
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
            this.button9.Location = new System.Drawing.Point(21, 823);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 74);
            this.button9.TabIndex = 119;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SeitonSystem.src.view.RelatorioFinancas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1032, 912);
            this.reportViewer1.TabIndex = 120;
            // 
            // FinançasViewGráficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(156)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1032, 912);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinançasViewGráficos";
            this.Text = "Seiton System";
            this.Load += new System.EventHandler(this.FinançasViewGráficos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}