using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BLSystem.Pages.FagPage
{
    public class CreateFagModel : PageModel
    {
        public IEnumerable<Fag> Fage { get; set; }

        IFagService fagService;

        [BindProperty]

        public Fag fag { get; set; }

        public CreateFagModel (IFagService service)
        {
            fagService = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            this.fagService.CreateFag(fag);
            return RedirectToPage("GetFag");
        }


    }
}

