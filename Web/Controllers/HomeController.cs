using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _portfolioItem;

        public HomeController(IUnitOfWork<Owner> owner,
                              IUnitOfWork<PortfolioItem> portfolioItem)
        {
            _owner = owner;
            _portfolioItem = portfolioItem;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _portfolioItem.Entity.GetAll().ToList()
                
            };
           // _owner.SaveChanges();
            //_portfolioItem.SaveChanges();
            return View(homeViewModel);
        }
    }
}