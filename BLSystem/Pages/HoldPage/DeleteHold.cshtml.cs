using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BLSystem.Pages.HoldPage
{
    public class DeleteHoldModel : PageModel
    {
        IHoldService service;
        [BindProperty]
        public Hold hold { get; set; }

        public DeleteHoldModel(IHoldService service) {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            hold = this.service.GetHoldById(id);
            return Page();
        }
        
        public IActionResult OnPost(int id) 
        {
            this.service.DeleteHold(id);
            return RedirectToPage("GetHold");
        }
    }
}
