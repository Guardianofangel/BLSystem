using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace BLSystem.Pages.UnderviserPage
{
    public class GetUnderviserModel : PageModel
    {
        public IEnumerable<Underviser> undervisers { get; set; }

        IUnderviseService service;
        public GetUnderviserModel( IUnderviseService service) {
            
            this.service = service;
        }
        [BindProperty(SupportsGet =true)]
        public string Navn { get; set; }
        public void OnGet() {

            undervisers= service.GetUndervisers(Navn);
        }
    }
}
