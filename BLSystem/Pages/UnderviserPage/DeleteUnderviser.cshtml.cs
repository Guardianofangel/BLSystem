using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BLSystem.Pages.UnderviserPage
{
    public class DeleteUnderviserModel : PageModel
    {
        private IUnderviseService service;
        [BindProperty]
        public Underviser underviser { get; set; }
        public DeleteUnderviserModel(IUnderviseService service) {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            underviser = service.GetUnderviserId(id);
            return Page();
        }

        public IActionResult OnPost(int id) {

            this.service.DeleteUnderviser(id);
            return RedirectToPage("GetUnderviser");

        }
    }
}
