using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EasyFinance
{
    public partial class Form4 : Form
    {
        private Form1 ventana1;

        public Form4(Form1 menu)
        {
            InitializeComponent();
            ventana1 = menu;
        }

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            this.Close();
            ventana1.Visible = true;
        }

        private void RegresarMenu3(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
