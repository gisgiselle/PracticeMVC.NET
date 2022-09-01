using PracticeMVC.Models;
using PracticeMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVC.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Spirited Away" },
                new Movie { Id = 2, Name = "My neighbour Totoro" }
            };
        }

        /*public ActionResult Random()
        { 
            var movie = new Movie() { Name = "Shrek", Id = 1 };
            var customers = new List<Customer> {
                new Customer {Name = "Cust 1"},
                new Customer {Name = "Cust 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
                   
            return View(viewModel);


           
        //redirect to action(action name, controller name, anonymous object )
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }


//new url movies/edit/{id}
//TIENE QUE LLAMARSE IGUAL QUE LA VARIABLE
//FOR CUSTOM ROUTES CHECK ROUTECONFIG
*/
        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }
        
        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            
                pageIndex = 1;
            
            if (String.IsNullOrWhiteSpace(sortBy))
            
                sortBy = "Name";

                return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            
        }

        //ATTRIBUTE ROUTING
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month) 
        {
            return Content(year + " " + month);
        }
    }
}