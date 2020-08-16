using System.ComponentModel.DataAnnotations.Schema;

namespace MarioKart.Model
{
    public class ClsVehiculo
    {
        public int Id_Vehiculo { get; set; }
        [ForeignKey("Marca_Id")]
        public string Marca_Id { get; set; }
        public Marca Marca { get; set; } 
        public string Modelo { get; set; }
        public string Color { get; set; }
        public EnTipo_Transmision Tranmision { get; set; }
        public int Anio { get; set; }
        public int Millaje { get; set; }
        public int Cliente_Id { get; set; }
        [ForeignKey("Cliente_Id")]
        public virtual ClsCliente Cliente { get; set; }

    }
}