using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace BLSystem.Pages.BogPage
{
    public class DeleteBogModel : PageModel
    {
        
       private IBogService bogService;
        [BindProperty]
        public Bog bog { get; set; }
        public DeleteBogModel(IBogService service) {
            bogService = service;
        }
       public IActionResult OnGet(int id) {
            bog = bogService.GetBogById(id);
            return Page();
        }
        
        public IActionResult OnPost(int id) 
        {
            bogService.DeleteBog(id);
            return RedirectToPage("GetBøger");
                
                
                
        }
    }
}
