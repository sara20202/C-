using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleUsage.Models;

namespace SimpleUsage.Pages
{
    public class DataDemoModel : PageModel
    {
       public List<PersonModel> People { get; set; } = new List<PersonModel>();

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        [BindProperty]
        public PersonModel  NewPerson { get; set; }
        public async Task OnGetAsync()
        {


            List<PersonModel> output = new List<PersonModel>();
            output.Add(new PersonModel { FirstName = "tim", LastName = "corey" });
            output.Add(new PersonModel { FirstName = "poly", LastName = "storm" });
            output.Add(new PersonModel { FirstName = "john ", LastName = "smith" });
            output.Add(new PersonModel { FirstName = "jane", LastName = "jess" });

            if (string.IsNullOrWhiteSpace(SearchTerm) == false)
            {
                People = output.Where(x => x.LastName.StartsWith(SearchTerm)).ToList();
            }
            else
            {
                People = output;
            }
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            People.Add(NewPerson);
            return RedirectToPage();
        }
    }
}
