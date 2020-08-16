using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarioKart.Data;
using MarioKart.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarioKart.Pages.Clientes
{
    public class CrearClienteModel : PageModel
    {

        private readonly IClientes service;
        private readonly IHtmlHelper helper;

        [BindProperty(SupportsGet = true)]
        public ClsCliente Cliente { get; set; }
        public IEnumerable<SelectListItem> Sexo { get; set; }


        //Constructor
        public CrearClienteModel(IClientes service, IHtmlHelper helper)
        {
            this.service = service;
            this.helper = helper;
        } 

        public void OnGet()
        {
            Sexo = helper.GetEnumSelectList<Sexo>();
            Cliente = new ClsCliente();
        }

        public ActionResult OnPost() 
        {
            Sexo = helper.GetEnumSelectList<Sexo>();

            if (ModelState.IsValid)
            {
                if (Cliente.Id_Cliente == 0)
                {
                    //Cliente = service.CrearCliente(Cliente);
                    TempData["Mensaje"] = "Registro Creado de manera correcta";
                }

                //service.GuardarCambios();

                return RedirectToPage("./DetalleCliente", new { Id = Cliente.Id_Cliente });
            }

            return Page();
        }

    }
}