using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMCForms.Entities
{
    class Valores
    {
        public int Id { get; set; }
        public double Peso { get; set; }
        public double Talla { get; set; }
        public double IMC { get => Math.Round(Peso / Math.Pow(Talla,2),2); }
        public DateTime Fecha { get; set; }
        public long PacienteId { get; set; }
    }
}
