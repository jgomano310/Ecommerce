using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace Ecommerce.Pages.Devoluciones
{
    public class IndexModel : PageModel
    {
        private readonly DAL.Modelo.EcommerceContext _context;

        public IndexModel(DAL.Modelo.EcommerceContext context)
        {
            _context = context;
        }

        public IList<CatDevolucionesPedido> CatDevolucionesPedido { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CatDevolucionesPedidos != null)
            {
                CatDevolucionesPedido = await _context.CatDevolucionesPedidos.ToListAsync();
            }
        }
    }
}
