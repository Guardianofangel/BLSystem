using BLSystem.Interfaces;
using BLSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;

namespace BLSystem.Pages.HoldPage
{
    public class GetHoldModel : PageModel
    {
        public IEnumerable <Hold> Holds { get; set; }

        IHoldService service;

        public GetHoldModel(IHoldService service) {
            this.service = service;
        }

        public void OnGet()
        {
            Holds= service.GetHolds();
        }
    }
}
