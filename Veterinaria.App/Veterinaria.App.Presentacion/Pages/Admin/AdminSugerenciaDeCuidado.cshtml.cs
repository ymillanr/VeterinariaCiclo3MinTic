using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminSugerenciaDeCuidadoModel : PageModel
    {
        public void OnGet()
        {
            ViewData["tituloDeLaPagina"]= "Registro Sugerencia de Cuidado";
        }
    }
}
