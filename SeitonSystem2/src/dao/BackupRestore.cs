using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeitonSystem.src.dao;
using MySql.Data.MySqlClient;

namespace SeitonSystem.src.dao
{
    public partial class BackupRestore : Form
    {
        public BackupRestore()
        {
            InitializeComponent();
        }



        private void btn_backup_Click(object sender, EventArgs e)
        {
            ConnectDAO connectDAO = new ConnectDAO();
            connectDAO.BackupMySql();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            ConnectDAO connectDAO = new ConnectDAO();
            connectDAO.RestoreMySql();
        }
    }
}
