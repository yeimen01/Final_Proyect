using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MarioKart.Model
{
    public class MarcaMecanico
    {
        public int Marca_Id { get; set; }
        public Marca Marca { get; set; }
        public int Mecanico_Id { get; set; }
        public ClsMecanico Mecanico { get; set; }
    }
}