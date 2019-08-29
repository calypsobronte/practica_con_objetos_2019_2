using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_con_objetos_2019_2
{
    public class Nomina
    {
        internal int txtSalarioDia;
        private int diasLaborados;
        public int DiasLaborados { get; set; }

        /* Método que me permite  calculatr la nomina*/

        public decimal CalcularNomina(int dialabor, decimal valordia)
        {


            if (dialabor > 20)
            {
                decimal TotalSalario = dialabor * valordia * 2;
                return TotalSalario;
            }
            else
            {
                decimal TotalSalario = dialabor * valordia;
                return TotalSalario;
            }

        }
    }
}
