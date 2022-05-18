using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaVehiculos
{
    internal class SuperClaseVehiculos
    {
        private string nombreVehiculo;
        private string tipoMotor;
        private int cantidadPersonas;

        public SuperClaseVehiculos(string nombreVehiculo, 
            string tipoMotor, int cantidadPersonas)

        {   this.nombreVehiculo = nombreVehiculo;
            this.tipoMotor = tipoMotor;
            this.cantidadPersonas = cantidadPersonas;
        }


        public string getNombreVehiculo()

        { return nombreVehiculo; }
        public void setNombreVehiculo(string nombreVehiculo)
        { this.nombreVehiculo = nombreVehiculo; }


        public string getTipoMotor()
        { return tipoMotor; }
        public void setTipoMotor(string tipoMotor)
        { this.tipoMotor = tipoMotor; }

        public int getCantidadPersonas()
        { return cantidadPersonas; }
        public void setCantidadPersonas(int cantidadPersonas) 
        { this.cantidadPersonas = cantidadPersonas; }

    }

}
