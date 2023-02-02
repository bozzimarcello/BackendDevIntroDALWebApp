using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendDevIntroDALWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackendDevIntroDALWebApp.Pages
{
    public class SearchModel : PageModel
    {
        public string Q { get; set; }
        public List<Risultato> Results { get; set; }
        public void OnGet(string q)
        {
            Q = q;
            Results = RisultatiDAL.GetAllRisultati(q);
        }
    }
}
