using System.Collections.Generic;

namespace MarioKart.Model
{
    public class Marca
    {
        public int Id_Marca { get; set; }
        public string Nombre { get; set; }
        public List<MarcaMecanico> MarcaMecanico { get; set; }
    }
}