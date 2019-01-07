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
    public class LectureController : Controller
    {
        LectureDataAccessLayer objectLecture = new LectureDataAccessLayer();

        //----------------------- View Lecture -----------------------
        public IActionResult LectureView()
        {
            List<Lecture> listStudent = new List<Lecture>();
            listStudent = objectLecture.GetAllLectures().ToList();

            return View(listStudent);
        }

        //----------------------- View Lecture Qualifications -----------------------
        public IActionResult LectureQualificationView()
        {
            List<Lecture> listLecture = new List<Lecture>();
            listLecture = objectLecture.GetLectureQualifications().ToList();

            return View(listLecture);
        }

        //----------------------- View Update Lecture -----------------------
        public IActionResult LectureUpdateView()
        {
            List<Lecture> listStudent = new List<Lecture>();
            listStudent = objectLecture.GetAllLectures().ToList();

            return View(listStudent);
        }

        //----------------------- View Update Lecture Contact -----------------------
        public IActionResult UpdateContactView()
        {
            List<Lecture> listStudent = new List<Lecture>();
            listStudent = objectLecture.GetAllLectures().ToList();

            return View(listStudent);
        }

        //----------------------- View Update Qualifications -----------------------
        public IActionResult UpdateQualificationView()
        {
            List<Lecture> listLecture = new List<Lecture>();
            listLecture = objectLecture.GetLectureQualifications().ToList();

            return View(listLecture);
        }

        //----------------------- View Delete Lecture -----------------------
        public IActionResult LectureDeleteView()
        {
            List<Lecture> listStudent = new List<Lecture>();
            listStudent = objectLecture.GetAllLectures().ToList();

            return View(listStudent);
        }

        //----------------------- View Delete Qualification -----------------------
        public IActionResult LectureQualificationDeleteView()
        {
            List<Lecture> listStudent = new List<Lecture>();
            listStudent = objectLecture.GetLectureQualifications().ToList();

            return View(listStudent);
        }

        //----------------------- Details of Lecture -----------------------
        [HttpGet]
        public IActionResult LectureDetails(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Lecture Lecture = objectLecture.GetLectureData(personID);

            if (Lecture == null)
            {
                return NotFound();
            }
            return View(Lecture);
        }

        //----------------------- Add Lecture and contact -----------------------
        [HttpGet]
        public IActionResult LectureAdd()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LectureAdd([Bind] Lecture lecture)
        {

            int lectureid = objectLecture.AddLecture(lecture);
            objectLecture.AddContact(lecture, lectureid);

            return RedirectToAction("LectureView");

        }

        //----------------------- Add Lecture Qualifications -----------------------
        [HttpGet]
        public IActionResult LectureQualificationsAdd()
        {
            ViewBag.lectureDRP = drp_lecture();
            ViewBag.instrumentDRP = drp_instrument();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LectureQualificationsAdd([Bind] Lecture lecture)
        {


            int qualificationTypeID = objectLecture.AddQualificationType(lecture);
            objectLecture.AddQualifications(lecture, qualificationTypeID);

            return RedirectToAction("LectureQualificationView");

        }

        //Drop down list of names of Tutors to add new qualification
        public List<SelectListItem> drp_lecture()
        {
            List<Lecture> allinstruments = new List<Lecture>();
            allinstruments = objectLecture.GetLectureDRP().ToList();

            var drpBranch = (from b in allinstruments
                             select new SelectListItem
                             {
                                 Text = b.Firstname.ToString() + " " + b.Surname +" --Skill: "+b.skill,
                                 Value = b.personID.ToString(),
                             }).ToList();
            return drpBranch;
        }

        //Drop down list for Instruments to assign to tutors
        public List<SelectListItem> drp_instrument()
        {
            List<Lecture> allinstruments = new List<Lecture>();
            allinstruments = objectLecture.GetInstrumentDRP().ToList();

            var drpBranch = (from b in allinstruments
                             select new SelectListItem
                             {
                                 Text = b.instrument.ToString() ,
                                 Value = b.instrumentID.ToString(),
                             }).ToList();
            return drpBranch;
        }

        //----------------------- Details Update Lecture -----------------------
        [HttpGet]
        public IActionResult LectureUpdate(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Lecture Lecture = objectLecture.GetLectureData(personID);

            if (Lecture == null)
            {
                return NotFound();
            }
            return View(Lecture);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateLecture(int? personID, [Bind] Models.Lecture lecture)
        {
            if (personID == null)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objectLecture.UpdateLecture(lecture);
            return RedirectToAction("LectureUpdateView");
            //}
            //return View(performance);
        }

        //----------------------- Details Update Lecture -----------------------
        [HttpGet]
        public IActionResult UpdateContact(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Lecture Lecture = objectLecture.GetLectureContactData(personID);

            if (Lecture == null)
            {
                return NotFound();
            }
            return View(Lecture);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactUpdate(int? personID, [Bind] Models.Lecture lecture)
        {
            if (personID == null)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objectLecture.UpdateContact(lecture);
            return RedirectToAction("UpdateContactView");
            //}
            //return View(performance);
        }

        //----------------------- Details Update Qualifications -----------------------
        [HttpGet]
        public IActionResult UpdateQualification(int? qualificationTypeID)
        {
            if (qualificationTypeID == null)
            {
                return NotFound();
            }
            Lecture Lecture = objectLecture.GetQualification(qualificationTypeID);

            if (Lecture == null)
            {
                return NotFound();
            }
            return View(Lecture);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateQualification(int? qualificationTypeID, [Bind] Models.Lecture lecture)
        {
            if (qualificationTypeID == null)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objectLecture.UpdateQualifications(lecture);
            return RedirectToAction("UpdateQualificationView");
            //}
            //return View(performance);
        }

        //----------------------- Details of Lecture to Delete -----------------------
        [HttpGet]
        public IActionResult LectureDelete(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Lecture lecture = objectLecture.GetLectureData(personID);

            if (lecture == null)
            {
                return NotFound();
            }
            return View(lecture);
        }
        //----------------------- Delete Student -----------------------
        [HttpPost, ActionName("DeleteLecture")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLecture(int? personID)
        {
            objectLecture.DeleteLecture(personID);
            return RedirectToAction("LectureDeleteView");
        }

        //----------------------- Details of Lecture to Delete -----------------------
        [HttpGet]
        public IActionResult LectureQualificationDelete(int? qualificationTypeID)
        {
            if (qualificationTypeID == null)
            {
                return NotFound();
            }
            Lecture lecture = objectLecture.GetQualification(qualificationTypeID);

            if (lecture == null)
            {
                return NotFound();
            }
            return View(lecture);
        }
        //----------------------- Delete Qualification -----------------------
        [HttpPost, ActionName("DeleteQualification")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteQualification(int? qualificationTypeID)
        {
            objectLecture.DeleteQualification(qualificationTypeID);
            return RedirectToAction("LectureQualificationDeleteView");
        }


    }
}
