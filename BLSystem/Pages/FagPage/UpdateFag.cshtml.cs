using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace BLSystem.Pages.FagPage
{
    public class UpdateFagModel : PageModel
    {
        public IEnumerable<Fag> fags { get; set; }
        IFagService fagService { get; set; }
        [BindProperty]

        public Fag fag { get; set; }

        public UpdateFagModel(IFagService service)
        {
            this.fagService = service;
        }
        public IActionResult OnGet(int id)
        {
            fag = fagService.GetFagById(id);
            return Page();
        }
        public IActionResult OnPost(Fag fag)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            this.fagService.UpdateFag(fag);
            return RedirectToPage("GetFag");
        }

        
    }
}
