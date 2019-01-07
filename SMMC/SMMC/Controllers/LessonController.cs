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
    public class LessonController : Controller
    {
        LessonDataAccessLayer objectLesson = new LessonDataAccessLayer();

        //----------------------- View Lesson -----------------------
        public IActionResult LessonView()
        {
            List<Lesson> listLesson = new List<Lesson>();
            listLesson = objectLesson.GetAllLessons().ToList();

            return View(listLesson);
        }

        public IActionResult LessonUpdateView()
        {
            List<Lesson> listLesson = new List<Lesson>();
            listLesson = objectLesson.GetAllLessons().ToList();

            return View(listLesson);
        }

        public IActionResult LessonDeleteView()
        {
            List<Lesson> listLesson = new List<Lesson>();
            listLesson = objectLesson.GetAllLessons().ToList();

            return View(listLesson);
        }

        //----------------------- View Student Lesson -----------------------
        public IActionResult LessonStudent()
        {
            List<Lesson> listLesson = new List<Lesson>();
            listLesson = objectLesson.GetStudentLessons().ToList();

            return View(listLesson);
        }


        //----------------------- Add Student -----------------------
        [HttpGet]
        public IActionResult LessonAdd()
        {
            ViewBag.studentCost = Drp_instrument();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LessonAdd([Bind] Lesson lesson)
        {


            objectLesson.LessonAdd(lesson);

            return RedirectToAction("LessonView");

        }

        //Drop down list for cost for Student
        public List<SelectListItem> Drp_instrument()
        {
            List<Lesson> allinstruments = new List<Lesson>();
            allinstruments = objectLesson.GetAllInstruments().ToList();

            var drpBranch = (from b in allinstruments
                             select new SelectListItem
                             {
                                 Text = b.Instrument.ToString(),
                                 Value = b.InstrumentID.ToString(),
                             }).ToList();
            return drpBranch;
        }


        //----------------------- Details of Lesson -----------------------
        [HttpGet]
        public IActionResult LessonDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Lesson lesson = objectLesson.GetLessonData(id);

            if (lesson == null)
            {
                return NotFound();
            }
            return View(lesson);
        }


        //----------------------- Delete Lesson -----------------------
        [HttpGet]
        public IActionResult LessonDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Lesson lesson = objectLesson.GetLessonData(id);

            if (lesson == null)
            {
                return NotFound();
            }
            return View(lesson);
        }

        [HttpPost, ActionName("LessonDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult LessonDeleteConfirmed(int? id)
        {
            objectLesson.DeleteLesson(id);
            return RedirectToAction("LessonDeleteView");
        }


        //----------------------- Update Lesson -----------------------
        [HttpGet]
        public IActionResult LessonUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Lesson lesson = objectLesson.GetLessonData(id);

            if (lesson == null)
            {
                return NotFound();
            }
            ViewBag.studentCost = Drp_instrument();
            return View(lesson);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LessonUpdate(int id, [Bind] Models.Lesson lesson)
        {
            if (id != lesson.LessonID)
            {
                return NotFound();
            }

            objectLesson.UpdateLesson(lesson);
            return RedirectToAction("LessonUpdateView");
        }
    }
}
