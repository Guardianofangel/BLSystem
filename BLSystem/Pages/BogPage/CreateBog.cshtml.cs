using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace BLSystem.Pages.BogPage
{
    public class CreateBogModel : PageModel
    {
        public IEnumerable<Bog> Bøger { get; set; }
        IBogService bogservice;
        [BindProperty]
        public Bog bog { get; set; }
        public CreateBogModel( IBogService service) {
            
            bogservice = service;
        }

        public IActionResult OnPost() {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            bogservice.AddBog(bog);
            return RedirectToPage("GetBøger");
        }


    }
}
