using gym.Models.config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gym.Controllers
{
    public class PlanController : Controller
    {
        private GymdbContext  gymdbContext = new GymdbContext();
        public async Task<IActionResult> Index()
        {
            var plans=await gymdbContext.plans.ToListAsync();
            return View(plans);
        }
        
    }
}
