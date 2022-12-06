using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace BLSystem.Pages.HoldPage
{
    public class CreateHoldModel : PageModel
    {
       
        IHoldService service;
        [BindProperty]
        public Hold hold { get; set; }
        public CreateHoldModel(IHoldService service) {
            this.service = service;
        }
        public IActionResult OnPost() 
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            this.service.AddHold(hold);
            return RedirectToPage("GetHold");
        }
        
        
    }
}
