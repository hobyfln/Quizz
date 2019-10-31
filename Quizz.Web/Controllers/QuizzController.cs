using Quizz.Domain.ViewModels;
using Quizz.Entities;
using Quizz.Services.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Quizz.Web.Controllers
{
    public class QuizzController : Controller
    {
        // GET: Quizz
        public ActionResult Index()
        {
            return View();
        }

        // GET: Quizz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quizz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quizz/Create
        [HttpPost]
        public ActionResult Create(QuizzAddViewModel model)
        {

            StringBuilder errorMessages = new StringBuilder();
            //MOVE TO REPO
            try
            {
                var quizzManager = new QuizzServices();
                quizzManager.GenerateQuizz(model);

                return RedirectToAction("Index");
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());

                return View("Add");
            }
        }

        // GET: Quizz/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quizz/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quizz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quizz/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
