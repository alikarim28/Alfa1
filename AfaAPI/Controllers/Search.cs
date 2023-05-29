using AlfaAPI.Data;
using AlfaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace AlfaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Search : ControllerBase
    {
        private readonly ModelContext _context;


        public Search(Data.ModelContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async IActionResult Get(string SearchString)
        {
            var prepaidRecharges = new PrepaidRecharge();

            if (!string.IsNullOrEmpty(SearchString))
            {
                if (SearchString.Contains("x"))
                {
                    prepaidRecharges = await _context.PrepaidRecharges.Where(c => c.Creditcard == SearchString)
                        .OrderByDescending(c => c.PrDate)
                        .Take(3)
                        .ToListAsync();
                }
                else if (Regex.IsMatch(SearchString, @"^\d{7,8}$"))
                {
                    prepaidRecharges = await _context.PrepaidRecharges.Where(c => c.PrMsisdn == SearchString).OrderByDescending(c => c.PrDate).ToListAsync();
                }
                else if (SearchString.Contains("-"))
                {
                    prepaidRecharges = await _context.PrepaidRecharges.Where(c => (c.PrTransaction) == SearchString).OrderByDescending(c => c.PrDate).ToListAsync();
                }
                else
                {
                    return NotFound();
                }
                
                return Ok(prepaidRecharges);
            }
            else
            {
                return BadRequest();
            }
        }
    }
    
}
