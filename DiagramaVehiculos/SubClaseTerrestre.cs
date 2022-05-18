using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaVehiculos
{
    internal class SubClaseTerrestre
    {
        private int cantidadLlantas;
        private string nombreTerrestre;
        private int nombrePersonas;

        public SubClaseTerrestre
            (int cantidadLlantas, int nombrePersonas,
            string nombreTerrestre)
        { 
        this.cantidadLlantas = cantidadLlantas;
        }
    }
}
