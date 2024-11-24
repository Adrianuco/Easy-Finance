using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyFinance
{
    public partial class Form3 : Form
    {
        private Form1 ventana1;

        public Form3(Form1 menu)
        {
            InitializeComponent();
            ventana1 = menu;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            this.Close();
            ventana1.Visible = true;
        }

        private void RegresarMenu2(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
