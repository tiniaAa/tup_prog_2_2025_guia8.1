using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Asalariado : Empleado, IExportable
    {
        public double Basico { get; private set; }
        public double AportesPrevisionales { get; private set; }
        public Asalariado(int dni, string nombre, double basico, double aporte ):base(dni,nombre) 
        {
            this.Basico = basico;
            this.AportesPrevisionales= aporte;

        }
        public override double CalcularImportarAPagar()
        {
            double importe = Basico - AportesPrevisionales;

            return importe;
        }

        public string[] Exportar()
        {
            List<Asalariado> exporte = new List<Asalariado>();
            
            
            return;
        }
        public override string ToString()
        {
        }
        public override string[] GenerarRecibo()
        {
            throw new NotImplementedException();
        }
    }
}
