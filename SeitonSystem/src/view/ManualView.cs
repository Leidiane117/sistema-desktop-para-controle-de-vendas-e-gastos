using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SeitonSystem.src.view
{
    public partial class ManualView : Form
    {
        public ManualView()
        {
            InitializeComponent();
            webBrowser1.Navigate(string.Format(@"file://{0}\manual.pdf", Application.StartupPath));
        }

    }

          



    }

