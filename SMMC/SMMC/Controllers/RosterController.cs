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
    public class RosterController : Controller
    {
        //Created Data Access Layer Object
        RosterDataAccessLayer objroster = new RosterDataAccessLayer();

        // GET: /<controller>/
        //----------------------- View Roster -----------------------
        public IActionResult RosterView()
        {
            List<Models.Roster> lstRoster = new List<Models.Roster>();
            lstRoster = objroster.GetRoster().ToList();

            return View(lstRoster);
        }

        public IActionResult RosterDeleteView()
        {
            List<Models.Roster> lstRoster = new List<Models.Roster>();
            lstRoster = objroster.GetRoster().ToList();

            return View(lstRoster);
        }

        public IActionResult RosterUpdateView()
        {
            List<Models.Roster> lstRoster = new List<Models.Roster>();
            lstRoster = objroster.GetRoster().ToList();

            return View(lstRoster);
        }

        public List<SelectListItem> Drp_ensembles()
        {
            List<Models.Roster> ensembles = new List<Models.Roster>();
            ensembles = objroster.GetEnsembles().ToList();

            var drpEnsembles = (from b in ensembles
                                select new SelectListItem
                                {
                                    Text = b.EnsemblesName.ToString(),
                                    Value = b.EnsemblesID.ToString(),
                                }).ToList();
            return drpEnsembles;
        }

        public List<SelectListItem> Drp_tutors()
        {
            List<Models.Roster> tutors = new List<Models.Roster>();
            tutors = objroster.GetTutors().ToList();

            var drpTutors = (from b in tutors
                                select new SelectListItem
                                {
                                    Text = b.Firstname.ToString()+" "+b.Surname.ToString()+" - "+b.Skill.ToString()+" - "+b.Role.ToString(),
                                    Value = b.PersonID.ToString(),
                                }).ToList();
            return drpTutors;
        }


        public List<SelectListItem> Drp_lessons()
        {
            List<Models.Roster> lessons = new List<Models.Roster>();
            lessons = objroster.GetLesson().ToList();

            var drpLesson = (from b in lessons
                             select new SelectListItem
                             {
                                 Text = b.LessonName.ToString() + " __ " + b.LessonDate.ToShortDateString() +" __ " + b.StartTime.ToString()+" AM",
                                 Value = b.LessonID.ToString(),
                             }).ToList();
            return drpLesson;
        }

        //----------------------- Add Roster -----------------------
        [HttpGet]
        public IActionResult RosterAdd()
        {
            ViewBag.ensemblesDrp = Drp_ensembles();
            ViewBag.tutorsDrp = Drp_tutors();
            ViewBag.lessonsDrp = Drp_lessons();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RosterAdd([Bind] Models.Roster roster)
        {
            //if (ModelState.IsValid)
            //{
            objroster.AddRoster(roster);
            return RedirectToAction("RosterView");
            //}
            //return View(roster);
        }




        //----------------------- Update Roster -----------------------
        [HttpGet]
        public IActionResult RosterUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Roster roster = objroster.GetRosterData(id);

            if (roster == null)
            {
                return NotFound();
            }
            ViewBag.ensemblesDrp = Drp_ensembles();
            ViewBag.tutorsDrp = Drp_tutors();
            ViewBag.lessonsDrp = Drp_lessons();
            return View(roster);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RosterUpdate(int id, [Bind] Models.Roster roster)
        {
            if (id != roster.RosterID)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objroster.UpdateRoster(roster);
            return RedirectToAction("RosterUpdateView");
            //}
            //return View(roster);
        }




        //----------------------- Delete Roster -----------------------
        [HttpGet]
        public IActionResult RosterDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Roster roster = objroster.GetRosterData(id);

            if (roster == null)
            {
                return NotFound();
            }

            return View(roster);
        }

        [HttpPost, ActionName("RosterDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult RosterDeleteConfirmed(int? id)
        {
            objroster.DeleteRoster(id);
            return RedirectToAction("RosterDeleteView");
        }

    }
}
