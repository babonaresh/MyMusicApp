using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMusicApp.Models;
using MyMusicApp.ViewModels;

namespace MyMusicApp.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres= _context.Genre.ToList()
            };
            return View(viewModel);
        }
    }
}