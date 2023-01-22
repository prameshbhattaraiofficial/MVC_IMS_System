using IMS.Migrations;
using IMS.Models;
using Microsoft.AspNetCore.Mvc;
using IMS.Data;
using IMS.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace IMS.Controllers
{

   
    
    public class RegisterController : Controller
    {
        private readonly RegisterDbContext registerDbContext;

        public RegisterController(RegisterDbContext registerDbContext)
        {
            this.registerDbContext = registerDbContext;
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
          var register =  await registerDbContext.Register.ToListAsync();
            return View(register);
        }
     

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterDB registerDbRequest)
        {
            var register = new Models.Domain.Register()
            {
                name = registerDbRequest.name,
                address = registerDbRequest.address,
                gender = registerDbRequest.gender,
                Contact = registerDbRequest.Contact,
                Dob = registerDbRequest.Dob,
                email = registerDbRequest.email,
                password = registerDbRequest.password,


            };

            await registerDbContext.Register.AddAsync(register);
            await registerDbContext.SaveChangesAsync();
            return RedirectToAction("Register");
        }
    }
}
