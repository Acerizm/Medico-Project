using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectTest.Controllers
{
    public class HomeController : Controller
    {
        //attributes
        private IRepository repository { get; set; }

        // constructor
        public HomeController(IRepository repo)
        {
            repository = repo;
        }

        // methods & operations
        public ViewResult Index() => View(repository.Reservations);
        //returns the view;
        //deafult view for the web api;
        // takes in an enumarable list of reservations that has been made;

        [HttpPost] //when the client posts to the server
        public IActionResult AddReservation(Reservation reservation)
        {
            // returns an "action type" which is the view method;
            repository.AddReservation(reservation);
            return RedirectToAction("Index");
        }

    }
}
