using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Asalariado : Empleado, IExportable
    {
        public double Basico { get;  set; }
        public double AportesPrevisionales { get;  set; }
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

        public string Exportar()
        {
            return $"Asalariado;{DNI};{Nombre};{Basico};{AportesPrevisionales}";

        }
        override public string ToString()
        {
            return $"{Nombre}({DNI})";
        }
        public override string[] GenerarRecibo()
        {
            double importe = CalcularImportarAPagar();
            List<String> exporte = new List<String>();

            exporte.Add($"Nombre: {Nombre}- DNI: {DNI}");
            exporte.Add($"Basico: ${Basico}");
            exporte.Add($"Aporte: ${AportesPrevisionales}");
            exporte.Add($"Total: ${importe}");

            return exporte.ToArray();
        }
    }
}
