using BLSystem.Interfaces;
using BLSystem.Models;
using BLSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Security.Permissions;

namespace BLSystem.Pages.BogPage
{
    public class UpdateBogModel : PageModel
    {
        public IEnumerable<Bog> Bøger { get; set; }
        IBogService service;
        [BindProperty]
        public Bog bog { get; set; }

        public UpdateBogModel(IBogService service) {
            this.service = service;
        }

        public IActionResult OnGet(int id) {
            bog = service.GetBogById(id);
            return Page();
        }

        public IActionResult OnPost(Bog bog ) {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            this.service.UpdateBog(bog);
            return RedirectToPage("GetBøger");
        }
    }
}
