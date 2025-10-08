using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Jornalero : Empleado, IExportable
    {
        public int HorasTrabajadas { get; private set; }
        public double ImportePorHora { get; private set; }
        public double RetencionesImpositivas { get;private set; }

        public Jornalero(int dni,string nombre, int horasTrabajadas,double importePorHora,double retencionImpositivas):base(dni,nombre) 
        {
            this.HorasTrabajadas = horasTrabajadas;
            this.ImportePorHora = importePorHora;
            this.RetencionesImpositivas= retencionImpositivas;
        }
        public override double CalcularImportarAPagar()
        {
            double importe = HorasTrabajadas * ImportePorHora - RetencionesImpositivas;
            return importe;
        }

        public string Exportar()
        {
            return $"Nombre: {Nombre}-Dni: {DNI}-Horas Trabajadas: {HorasTrabajadas}-Importe por hora: {ImportePorHora}-Retenciones impositivos: {RetencionesImpositivas}";
        }

        public override string[] GenerarRecibo()
        {
            double importe = CalcularImportarAPagar();

            List<String> exporte = new List<String>();

            exporte.Add($"Nombre: {Nombre} - DNI: {DNI}");
            exporte.Add($"Importe en hhoras trabajadas: (10hs/$500) ${ImportePorHora}");
            exporte.Add($"Retenciones impositivos: ${RetencionesImpositivas}");
            exporte.Add($"Importe a Percibir: ${importe}");

            return exporte.ToArray();
        }

        public override string ToString()
        {
            return $"{Nombre}({DNI})";
        }
    }
}
