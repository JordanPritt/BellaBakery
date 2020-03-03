using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BellaBakery.Models;
using BellaBakery.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BellaBakery.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepo _pieRepo;
        private readonly ICategoryRepo _categoryRepo;

        public PieController(IPieRepo pieRepo, ICategoryRepo categoryRepo)
        {
            _pieRepo = pieRepo;
            _categoryRepo = categoryRepo;
        }

        public ViewResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepo.AllPies;
            pieListViewModel.CurrentCategory = "Fruit Pies";
            return View(pieListViewModel);
        }
    }
}