using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace BLSystem.Pages.FagPage
{
    public class GetFagModel : PageModel
    {
        public IEnumerable<Fag> fag { get; set; }

        IFagService service;
        public GetFagModel (IFagService service)
        {
            this.service = service;
        }
        public void OnGet()
        {
            fag = service.GetFags();
        }
    }
}
