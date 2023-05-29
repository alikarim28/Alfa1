using Alfa.Data;
using Alfa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace Alfa.Pages
{
    public class Index1Model : PageModel
    {
        private readonly Alfa.Data.ModelContext _context;
        public string? BillType;

        public Index1Model(Alfa.Data.ModelContext context)
        {
            _context = context;
        }

        public IList<PrepaidRecharge> prepaidRecharges { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public int? ItemId { get; set; }
        public PrepaidRecharge? PrepaidRecharge { get; set; }


        public class MyModel
        {
            public string Id { get; set; }

        }
        public async Task OnGetAsync()
        {

            if (!string.IsNullOrEmpty(SearchString))
            {
                if (SearchString.Contains("x")) {
                    prepaidRecharges = await _context.PrepaidRecharges.Where(c => c.Creditcard == SearchString).OrderByDescending(c => c.PrDate).Take(3).ToListAsync();
                }
                else if (Regex.IsMatch(SearchString, @"^\d{7,8}$")) {
                    prepaidRecharges = await _context.PrepaidRecharges.Where(c => c.PrMsisdn == SearchString).OrderByDescending(c => c.PrDate).ToListAsync();
                }
                else if (SearchString.Contains("-"))
                {
                    prepaidRecharges = await _context.PrepaidRecharges.Where(c => (c.PrTransaction) == SearchString).OrderByDescending(c => c.PrDate).ToListAsync();
                }
            }
        }

        public  IActionResult OnPostGetResult([FromBody] MyModel T)
        {
            string id = T.Id;
            PrepaidRecharge = _context.PrepaidRecharges.FirstOrDefault(e => e.PrTransaction == id);
           
            return new JsonResult(PrepaidRecharge);
        }
       
        public ModelContext Get_context()
        {
            return _context;
         
        }

        

    }
}
