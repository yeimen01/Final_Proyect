using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MarioKart.Data;
using MarioKart.Model;

namespace MarioKart.Pages
{
    public class RegistroDeClientesModel : PageModel
    {
        public IClientes ClientesService;
        public IList<ClsCliente> Clientes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string NombreCliente { get; set; }

        public RegistroDeClientesModel(IClientes clientes)
        {
            ClientesService = clientes;
        }

        public void OnGet()
        {
            //this.Clientes = ClientesService.GetClientesPorNombre(NombreCliente);
        }
    }
}