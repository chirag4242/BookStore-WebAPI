using BookStore_WebAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using (var context = new BooksContext())
            {
                //Get all authors 

                //Author? UserAuthor = context.Authors.Where(auth => auth.FirstName == "Jhonny").FirstOrDefault();
                //UserAuthor.Phone = "777-777-7777";
                //context.SaveChanges();  

                Author? UserAuthor = context.Authors.Where(auth => auth.FirstName == "Jhonny").FirstOrDefault();
                context.Authors.Remove(UserAuthor);
                context.SaveChanges();
                
                return context.Authors.ToList();

            }
        }
    }
}