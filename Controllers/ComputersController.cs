using Labs.Models;
using Labs.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace Labs.Controllers
{
    public class ComputersController : Controller
    {

        UOW.UnitofWork _uow;

        public ComputersController()
        {
            _uow = new UOW.UnitofWork();
        }

       

        // GET: Computers
        public ActionResult Index()
        {
            return View(_uow.ComputerRepository.findAll());
        }


       
        // GET: Computer/Details/5
        public ActionResult Details(int id)
        {
            return View(_uow.ComputerRepository.findById(id));
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Computer/Create
        [HttpPost]
        public ActionResult Create(Computers computers)
        {
            try
            {
               
                _uow.ComputerRepository.Add(computers);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Computer/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_uow.ComputerRepository.findById(id));
        }

        // POST: Computer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Computers computers)
        {
            try
            {
                // TODO: Add update logic here
                _uow.ComputerRepository.Edit(computers);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        


        // GET: Computer/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_uow.ComputerRepository.findById(id));
        }

        // POST: Computer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Computers computers)
        {
            try
            {
                // TODO: Add delete logic here
                _uow.ComputerRepository.Remove(_uow.ComputerRepository.findById(id));
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Sobre()
        {
            return View();
        }


    }
}
