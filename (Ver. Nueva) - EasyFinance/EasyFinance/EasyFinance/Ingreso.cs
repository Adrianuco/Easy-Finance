using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFinance
{
    internal class Ingreso
    {
        public string nombre { get; set; }
        public double monto { get; set; }
        public DateTime fecha { get; set; }

        public Ingreso(string nombre, double monto, DateTime fecha)
        {
            this.nombre = nombre;
            this.monto = monto;
            this.fecha = fecha;
        }

        public static void registrarIngreso(List<Ingreso> ingresos, string nombre, double monto, DateTime fecha)
        {
            ingresos.Add(new Ingreso(nombre, monto, fecha));
        }
    }
}
