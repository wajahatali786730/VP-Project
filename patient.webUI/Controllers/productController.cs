using patient.webUI.Models;
using smartPatient.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace patient.webUI.Controllers
{
    public class productController : Controller
    {

       
        private readonly iproductrepository repository;
        public productController(iproductrepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.products);
        }
       

    }
}