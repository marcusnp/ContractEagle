using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Configuration;
using Domain.Entities;

namespace WebUI.Controllers
{
    public class DocumentController : Controller
    {
        ContractEagleContext _dbContext = new ContractEagleContext();

        public IActionResult Index()
        {
            List<Document> data = this._dbContext.Document.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Document model)
        {
            ModelState.Remove("DocumentId");
            if (ModelState.IsValid)
            {
                _dbContext.Document.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}