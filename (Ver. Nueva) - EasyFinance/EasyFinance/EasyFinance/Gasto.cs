using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EasyFinance
{
    internal class Gasto
    {
        public string Nombre { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }

        public Gasto(string nombre, double monto, DateTime fecha, string categoria)
        {
            Nombre = nombre;
            Monto = monto;
            Fecha = fecha;
            Categoria = categoria;
        }
        
        public static void registrarGasto (List<Gasto> gastos, string nombre, double monto, DateTime fecha, string categoria)
        {
            gastos.Add(new Gasto(nombre, monto, fecha, categoria));
        }
    }
}
