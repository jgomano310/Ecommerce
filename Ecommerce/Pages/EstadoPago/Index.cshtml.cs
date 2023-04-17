using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace Ecommerce.Pages.EstadoPago
{
    public class IndexModel : PageModel
    {
        private readonly DAL.Modelo.EcommerceContext _context;

        public IndexModel(DAL.Modelo.EcommerceContext context)
        {
            _context = context;
        }

        public IList<CatEstadoPago> CatEstadoPago { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CatEstadoPagos != null)
            {
                CatEstadoPago = await _context.CatEstadoPagos.ToListAsync();
            }
        }
    }
}
