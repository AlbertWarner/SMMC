using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMMC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMMC.Controllers
{
    public class EnrolmentController : Controller
    {
        EnrolmentDataAccessLayer objectEnrolment = new EnrolmentDataAccessLayer();

        //----------------------- View Enrolment -----------------------
        public IActionResult EnrolmentView()
        {
            List<Enrolment> listEnrolment = new List<Enrolment>();
            listEnrolment = objectEnrolment.GetAllEnrolment().ToList();

            return View(listEnrolment);
        }

        public IActionResult EnrolmentUpdateView()
        {
            List<Enrolment> listEnrolment = new List<Enrolment>();
            listEnrolment = objectEnrolment.GetAllEnrolment().ToList();

            return View(listEnrolment);
        }

        public IActionResult EnrolmentDeleteView()
        {
            List<Enrolment> listEnrolment = new List<Enrolment>();
            listEnrolment = objectEnrolment.GetAllEnrolment().ToList();

            return View(listEnrolment);
        }


        //----------------------- Add Enrolment  -----------------------
        [HttpGet]
        public IActionResult EnrolmentAdd()
        {
            ViewBag.studentCost = Drp_student();
            ViewBag.openCost = Drp_lesson();
            ViewBag.ensembles = Drp_ensembles();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnrolmentAdd([Bind] Enrolment enrolment)
        {
            objectEnrolment.AddEnrolment(enrolment);

            return RedirectToAction("EnrolmentView");

        }

        //Drop down list for Student
        public List<SelectListItem> Drp_student()
        {
            List<Enrolment> allstudents = new List<Enrolment>();
            allstudents = objectEnrolment.GetStudents().ToList();

            var drpBranch = (from b in allstudents
                             select new SelectListItem
                             {
                                 Text = b.Firstname.ToString()+" "+ b.Surname.ToString() + " -- Skill : " + b.Skill,
                                 Value = b.PersonID.ToString(),
                             }).ToList();
            return drpBranch;
        }
        //Drop down list for lesson
        public List<SelectListItem> Drp_lesson()
        {
            List<Enrolment> alllesson = new List<Enrolment>();
            alllesson = objectEnrolment.GetLesson().ToList();

            var drpBranch = (from b in alllesson
                             select new SelectListItem
                             {
                                 Text = b.LessonName.ToString() + ",  -- Instrument: "+b.Instrument.ToString() +"  -- Start Time:  " +b.Start.ToString(),
                                 Value = b.LessonID.ToString(),
                             }).ToList();
            return drpBranch;
        }

        //Drop down list for Ensembles
        public List<SelectListItem> Drp_ensembles()
        {
            List<Enrolment> allensembles = new List<Enrolment>();
            allensembles = objectEnrolment.GetEnsembles().ToList();

            var drpBranch = (from b in allensembles
                             select new SelectListItem
                             {
                                 Text = b.EnsembleName.ToString() ,
                                 Value = b.EnsemblesID.ToString(),
                             }).ToList();
            return drpBranch;
        }


        //----------------------- Details of Enrolment -----------------------
        [HttpGet]
        public IActionResult EnrolmentDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Enrolment enrolment = objectEnrolment.GetEnrolmentData(id);

            if (enrolment == null)
            {
                return NotFound();
            }
            return View(enrolment);
        }


        //----------------------- Update Enrolment -----------------------
        [HttpGet]
        public IActionResult EnrolmentUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Enrolment enrolment = objectEnrolment.GetEnrolmentData(id);

            if (enrolment == null)
            {
                return NotFound();
            }
            ViewBag.studentCost = Drp_student();
            ViewBag.openCost = Drp_lesson();
            ViewBag.ensembles = Drp_ensembles();
            return View(enrolment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnrolmentUpdate(int id, [Bind] Models.Enrolment enrolment)
        {
            if (id != enrolment.EnrolmentID)
            {
                return NotFound();
            }
            objectEnrolment.UpdateEnrolment(enrolment);
            return RedirectToAction("EnrolmentUpdateView");
        }


        //----------------------- Delete Enrolment -----------------------
        [HttpGet]
        public IActionResult EnrolmentDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Enrolment enrolment = objectEnrolment.GetEnrolmentData(id);

            if (enrolment == null)
            {
                return NotFound();
            }

            return View(enrolment);
        }

        [HttpPost, ActionName("EnrolmentDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult EnrolmentDeleteConfirmed(int? id)
        {
            objectEnrolment.DeleteEnrolment(id);
            return RedirectToAction("EnrolmentDeleteView");
        }
    }
}

