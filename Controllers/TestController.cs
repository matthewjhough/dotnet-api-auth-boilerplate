using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using mgm_app.Models;

namespace mgm_app.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IEnumerable<Book> Get() {
            var currentUser = HttpContext.User;
            var resultBookList = new Book[] {
                new Book { 
                    Author = "Ray Bradbury", 
                    Title = "Fahrenheit 451", 
                    AgeRestriction = false 
                },
                new Book { 
                    Author = "Philip K Dick", 
                    Title = "Do androids dream of electric sheep?", 
                    AgeRestriction = false 
                },
                new Book { 
                    Author = "George Orwell", 
                    Title = "1984", 
                    AgeRestriction = false 
                },
                new Book { 
                    Author = "Anais Nin", 
                    Title = "Delta of Venus",
                    AgeRestriction = true 
                }
            };

            return resultBookList;
        }

    }
}