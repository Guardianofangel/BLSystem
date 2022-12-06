using BLSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using BLSystem.Models;


namespace BLSystem.Pages.FagPage
{
    public class DeleteFagModel : PageModel
    {
        private IFagService fagService;
        [BindProperty]

        public Fag fags { get; set; }

        public DeleteFagModel(IFagService service)
        {
            this.fagService = service;
        }
        public IActionResult OnGet(int id)
        {
            fags = fagService.GetFagById(id);
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            this.fagService.DeleteFag(id);
            return RedirectToPage("GetFag");
        }
  
        
    }
}
