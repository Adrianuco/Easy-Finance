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
        private Form2 ventana1;
        private Form3 ventana2;
        private Form4 ventana3;

        public static List<Categoria> categorias = new List<Categoria>(6)
        {
            new Categoria("Comida", 1000, 0.0f),
            new Categoria("Transporte", 1000, 0.0f),
            new Categoria("Entretenimiento", 1000, 0.0f),
            new Categoria("Educación", 1000, 0.0f),
            new Categoria("Salud", 1000, 0.0f),
            new Categoria("Otros", 1000, 0.0f)
        };

        public Form1()
        {
            InitializeComponent();
            ventana1 = new Form2(this);
            ventana2 = new Form3(this);
            ventana3 = new Form4(this);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventana1.Visible = true;
        }

        private void btnCategorías_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventana2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventana3.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
