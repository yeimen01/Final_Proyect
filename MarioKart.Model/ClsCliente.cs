using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MarioKart.Model
{
    public class ClsCliente
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public ClsVehiculo Vehiculo { get; set; }

    }
}
