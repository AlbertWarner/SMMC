using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMMC.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMMC.Controllers
{
    public class PerformanceController : Controller
    {
        //Created Data Access Layer Object
        PerformanceDataAccessLayer objperformance = new PerformanceDataAccessLayer();

        //----------------------- Add Performance -----------------------
        [HttpGet]
        public IActionResult PerformanceAdd()
        {
            ViewBag.ensemblesDrp = Drp_ensembles();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PerformanceAdd([Bind] Models.Performance performance)
        {
            //if (ModelState.IsValid)
            //{
            objperformance.AddPerformance(performance);
            return RedirectToAction("PerformanceView");
            //}
            //return View(performance);
        }

        public List<SelectListItem> Drp_ensembles()
        {
            List<Models.Performance> ensembles = new List<Models.Performance>();
            ensembles = objperformance.GetEnsembles().ToList();

            var drpEnsembles = (from b in ensembles
                                select new SelectListItem
                                {
                                    Text = b.EnsemblesName.ToString(),
                                    Value = b.EnsemblesID.ToString(),
                                }).ToList();
            return drpEnsembles;
        }

        public List<SelectListItem> Drp_enrolment()
        {
            List<Models.Performance> enrolment = new List<Models.Performance>();
            enrolment = objperformance.GetEnrolment().ToList();

            var drpEnrolment = (from b in enrolment
                                select new SelectListItem
                                {
                                    Text = b.Firstname.ToString() + " " + b.Surname.ToString(),
                                    //Text = b.CastName.ToString(),
                                    Value = b.EnrolmentID.ToString(),
                                }).ToList();
            return drpEnrolment;
        }

        //----------------------- View Performance -----------------------
        public IActionResult PerformanceView()
        {
            List<Models.Performance> lstPerformance = new List<Models.Performance>();
            lstPerformance = objperformance.GetAllPerformances().ToList();

            return View(lstPerformance);
        }

        public IActionResult PerformanceDeleteView()
        {
            List<Models.Performance> lstPerformance = new List<Models.Performance>();
            lstPerformance = objperformance.GetAllPerformances().ToList();

            return View(lstPerformance);
        }

        public IActionResult PerformanceUpdateView()
        {
            List<Models.Performance> lstPerformance = new List<Models.Performance>();
            lstPerformance = objperformance.GetAllPerformances().ToList();

            return View(lstPerformance);
        }



        //----------------------- Update Performance -----------------------
        [HttpGet]
        public IActionResult PerformanceUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Performance performance = objperformance.GetPerformanceData(id);

            if (performance == null)
            {
                return NotFound();
            }
            ViewBag.ensemblesDrp = Drp_ensembles();
            return View(performance);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PerformanceUpdate(int id, [Bind] Models.Performance performance)
        {
            if (id != performance.PerformanceID)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objperformance.UpdatePerformance(performance);
            return RedirectToAction("PerformanceUpdateView");
            //}
            //return View(performance);
        }


        //----------------------- Details of Performance -----------------------
        [HttpGet]
        public IActionResult PerformanceDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Performance performance = objperformance.GetPerformanceData(id);

            if (performance == null)
            {
                return NotFound();
            }
            return View(performance);
        }


        //----------------------- Details of Students' Performance -----------------------
        //[HttpGet]
        public IActionResult PerformanceSearch()
        {

            List<Models.Performance> lstPersonPerformance = new List<Models.Performance>();
            lstPersonPerformance = objperformance.GetPersonPerformance().ToList();

            return View(lstPersonPerformance);
        }


        //----------------------- Delete Performance -----------------------
        [HttpGet]
        public IActionResult PerformanceDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Performance performance = objperformance.GetPerformanceData(id);

            if (performance == null)
            {
                return NotFound();
            }

            return View(performance);
        }

        [HttpPost, ActionName("PerformanceDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult PerformanceDeleteConfirmed(int? id)
        {
            objperformance.DeletePerformance(id);
            return RedirectToAction("PerformanceDeleteView");
        }
    }
}
