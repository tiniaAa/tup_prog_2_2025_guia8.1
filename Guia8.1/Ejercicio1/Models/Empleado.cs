using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Empleado : IComparable
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }

        public Empleado(int dni, string nombre ) 
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }

        abstract public double CalcularImportarAPagar();
        abstract public string[] GenerarRecibo();
        abstract public string ToString();
        public int CompareTo(object? obj ) 
        {
            Empleado empleado = obj as Empleado;
            if ( empleado != null)
            {
                return DNI.CompareTo( empleado.DNI );
            }
            return -1;
        }
    }
}
