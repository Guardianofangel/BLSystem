using BLSystem.Interfaces;
using BLSystem.Models;
using BLSystem.Pages.BogPage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace BLSystem.Pages.UnderviserPage
{
    public class CreateUnderviserModel : PageModel
    {
        //public IEnumerable<Underviser> undervises { get; set; }
        private IUnderviseService service;
        [BindProperty]
        public Underviser underviser { get; set; }

        public CreateUnderviserModel (IUnderviseService service) {
            this.service = service;
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {

                return Page();
            }
            this.service.AddUnderviser(underviser);
             return RedirectToPage("GetUnderviser");
        }
    }
}
