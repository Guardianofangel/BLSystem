using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace BLSystem.Pages.BogPage
{
    public class GetBøgerModel : PageModel
    {
        public IEnumerable<Bog> Bøger { get; set; }
        IBogService bogservice;
        public GetBøgerModel(IBogService service) {
            bogservice = service;
        }
        [BindProperty(SupportsGet =true)]
        public string Title { get; set; }

        [BindProperty(SupportsGet =true)]
        public string Forfatter { get;set; }

        [BindProperty(SupportsGet = true)]
        public double ISBN { get; set; }

        public void OnGet()
        {
            Bøger=bogservice.GetBogs( Title,Forfatter,ISBN);
        }
    }
}
