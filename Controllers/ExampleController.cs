using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgm_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mgm_app.Controllers {
    [Route ("api/[controller]")]
    public class ExampleController : Controller {
        private readonly ExampleContext _context;

        public ExampleController (ExampleContext context) {
            _context = context;
        }

        // get : examples
        [HttpGet]
        public async Task<IActionResult> Index () {
            return Json (await _context.Examples.ToListAsync ());
        }
    }
}