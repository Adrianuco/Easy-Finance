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
    public partial class Form1 : Form
    {
        Form2 ventana1 = new Form2();
        Form3 ventana2 = new Form3();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ventana1.Visible = true;
        }

        private void btnCategorías_Click(object sender, EventArgs e)
        {
            ventana2.Visible = true;
        }
    }
}
