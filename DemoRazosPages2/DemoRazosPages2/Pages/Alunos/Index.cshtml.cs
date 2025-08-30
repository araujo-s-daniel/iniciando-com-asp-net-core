using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoRazosPages2.Data;
using DemoRazosPages2.Models;

namespace DemoRazosPages2.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly DemoRazosPages2.Data.ApplicationDbContext _context;

        public IndexModel(DemoRazosPages2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Aluno != null)
            {
                Aluno = await _context.Aluno.ToListAsync();
            }
        }
    }
}
