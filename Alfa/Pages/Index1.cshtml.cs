using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alfa.Pages
{
    public class Index1Model : PageModel
    {
        public string? BillType;
        public void OnGet()
        {   
            BillType = Convert.ToString(Request.Query["BillType"]);

        }
    }
}
