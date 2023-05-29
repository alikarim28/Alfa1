using AlfaAPI.Data;
using AlfaAPI.Models;
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
        private readonly ModelContext _context;
        public string? BillType;

        public Index1Model(ModelContext context)
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
