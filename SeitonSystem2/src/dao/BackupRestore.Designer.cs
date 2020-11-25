namespace SeitonSystem.src.dao
{
    partial class BackupRestore
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
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(71, 241);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(171, 81);
            this.btn_backup.TabIndex = 0;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Location = new System.Drawing.Point(416, 241);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(171, 81);
            this.btn_Restore.TabIndex = 1;
            this.btn_Restore.Text = "Restore";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.btn_backup);
            this.Name = "BackupRestore";
            this.Text = "BackupRestore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_Restore;
    }
}