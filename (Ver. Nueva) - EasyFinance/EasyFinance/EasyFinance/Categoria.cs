using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFinance
{
    public class Categoria
    {
        public string Nombre { get; set; }
        public double Limite_Gasto { get; set; }
        public float Porcentaje_Gasto { get; set; }
        public double monto = 0;
        public bool Alerta = false;

        public Categoria(string nombre, double limite_gasto, float porcentaje_gasto)
        {
            Nombre = nombre;
            Limite_Gasto = limite_gasto;
            Porcentaje_Gasto = porcentaje_gasto;
        }

        public static void calcularPorcentaje(Categoria categoria)
        {
            categoria.Porcentaje_Gasto =  (float)categoria.monto / (float)(categoria.Limite_Gasto);
        }


        public static void verificarAlerta(Categoria categoria)
        {
            if (categoria.Porcentaje_Gasto > 1)
            {
                categoria.Alerta = true;
            }
        }

    }
}
