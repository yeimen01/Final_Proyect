using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MarioKart.Model
{
    public class ClsMecanico
    {
        public int Id_Mecanico { get; set; }
        public string Nombre { get; set; }
        public bool Disponible { get; set; }
        public List<MarcaMecanico> MarcasMecanicos { get; set; }
    }
}
