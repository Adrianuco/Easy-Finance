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
    public partial class Form2 : Form
    {
        private Form1 ventana1;

        List<Gasto> gastos = new List<Gasto>();
        List<Ingreso> ingresos = new List<Ingreso>();

        public Form2(Form1 menu)
        {
            InitializeComponent();
            ventana1 = menu;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            int opc = 3;
            if (radGastos.Checked)
            {
                opc = 1;
            }
            else if (radIngresos.Checked)
            {
                opc = 2;
            }

            do
            { 
                switch (opc)
                {
                    case 1:
                    {
                        cmbCategoría1.Enabled = true;
                        string nombre = txtTransacción1.Text;
                        double monto = Convert.ToDouble(txtMonto1.Text);
                        string categoria = cmbCategoría1.Text;
                        DateTime fecha = dtpFecha.Value;

                        Gasto.registrarGasto(gastos, nombre, monto, fecha, categoria);
                        
                        foreach (Categoria cat in Form1.categorias)
                            {
                                if (cat.Nombre == categoria)
                                {
                                    cat.monto += monto;
                                    Categoria.calcularPorcentaje(cat);
                                    Categoria.verificarAlerta(cat);
                                    if(cat.Alerta)
                                    {
                                        MessageBox.Show("Alerta: " + cat.Nombre + " ha superado el límite de gasto");
                                    }
                                }
                            }
                            break;
                    }
                    case 2:
                    {
                        cmbCategoría1.Enabled = false;
                        string nombre = txtTransacción1.Text;
                        double monto = Convert.ToDouble(txtMonto1.Text);
                        DateTime fecha = dtpFecha.Value;

                        Ingreso.registrarIngreso(ingresos, nombre, monto, fecha);
                        break;
                    }
                    case 3:
                    {
                        MessageBox.Show("Seleccione si es un gasto o un ingreso");
                        break;
                    }
                    default:
                    {
                        break;
                    }
                } 
            } while (opc == 3);
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.Close();
            ventana1.Visible = true;
        }

        private void RegresarMenu1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
