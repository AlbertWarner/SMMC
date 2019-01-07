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
    public class StudentController : Controller
    {
        StudentDataAccessLayer objectStudent = new StudentDataAccessLayer();

        //----------------------- View Student -----------------------
        public IActionResult StudentView()
        {
            List<Student> listStudent = new List<Student>();
            listStudent = objectStudent.GetAllStudents().ToList();

            return View(listStudent);
        }

        //----------------------- View Student Delete-----------------------
        public IActionResult StudentDeleteView()
        {
            List<Student> listStudent = new List<Student>();
            listStudent = objectStudent.GetAllStudents().ToList();

            return View(listStudent);
        }

        //----------------------- View Student Update -----------------------
        public IActionResult StudentUpdateView()
        {
            List<Student> listStudent = new List<Student>();
            listStudent = objectStudent.GetAllStudents().ToList();

            return View(listStudent);
        }

        //----------------------- View Parent Update -----------------------
        public IActionResult ParentUpdateView()
        {
            List<Student> listStudent = new List<Student>();
            listStudent = objectStudent.GetParentStudents().ToList();

            return View(listStudent);
        }

        //----------------------- View Contact Update -----------------------
        public IActionResult ContactUpdateView()
        {
            List<Student> listStudent = new List<Student>();
            listStudent = objectStudent.GetContact().ToList();

            return View(listStudent);
        }

        //----------------------- View School Update -----------------------
        public IActionResult SchoolUpdateView()
        {
            List<Student> listStudent = new List<Student>();
            listStudent = objectStudent.GetAllStudents().ToList();

            return View(listStudent);
        }

        //----------------------- Details of Student -----------------------
        [HttpGet]
        public IActionResult StudentDetails(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Student student = objectStudent.GetStudentData(personID);

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }



        //----------------------- View Parent Information ---------------------
        public IActionResult StudentParentView()
        {
            List<Student> listStudent = new List<Student>();
            listStudent = objectStudent.GetParentStudents().ToList();

            return View(listStudent);
        }


        //----------------------- Add Student -----------------------
        [HttpGet]
        public IActionResult StudentAdd()
        {
            ViewBag.studentCost = drp_student();
            ViewBag.openCost = drp_open();
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StudentAdd([Bind] Student student)
        {
         
                
             int studentid = objectStudent.AddStudent(student);
             int parentid = objectStudent.AddParent(student);
             objectStudent.AddContact(student, studentid);
             objectStudent.AddSchoolEnrolment(student, studentid, parentid);

            return RedirectToAction("StudentView");
            
        }

        //Drop down list for cost for Student
        public List<SelectListItem> drp_student()
        {
            List<Student> allinstruments = new List<Student>();
            allinstruments = objectStudent.GetStudentCost().ToList();

            var drpBranch = (from b in allinstruments
                             select new SelectListItem
                             {
                                 Text = b.instrumentName.ToString()+ " -- Fee : "+ b.studentFee ,
                                 Value = b.costID.ToString(),
                             }).ToList();
            return drpBranch;
        }
        //Drop down list for cost for open 
        public List<SelectListItem> drp_open()
        {
            List<Student> allinstruments = new List<Student>();
            allinstruments = objectStudent.GetOpenCost().ToList();

            var drpBranch = (from b in allinstruments
                             select new SelectListItem
                             {
                                 Text = b.instrumentName.ToString() + " -- Fee : " + b.studentFee,
                                 Value = b.costOpenID.ToString(),
                             }).ToList();
            return drpBranch;
        }

        //----------------------- Details of Student to Delete -----------------------
        [HttpGet]
        public IActionResult StudentDelete(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Student student = objectStudent.GetStudentData(personID);

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        //----------------------- Delete Student -----------------------
        [HttpPost, ActionName("DeleteStudent")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStudent(int? personID)
        {
            objectStudent.DeleteStudent(personID);
            return RedirectToAction("StudentDeleteView");
        }

        //----------------------- Details of Student to Update -----------------------
        [HttpGet]
        public IActionResult StudentUpdate(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Student student = objectStudent.GetStudentData(personID);

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateStudent(int? personID, [Bind] Models.Student student)
        {
            if (personID == null)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objectStudent.UpdateStudent(student);
            return RedirectToAction("StudentUpdateView");
            //}
            //return View(performance);
        }

        //----------------------- Details of Parent to Update -----------------------
        [HttpGet]
        public IActionResult ParentUpdate(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Student student = objectStudent.GetStudentData(personID);

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateParent(int? personID, [Bind] Models.Student student)
        {
            if (personID == null)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objectStudent.UpdateParent(student);
            return RedirectToAction("ParentUpdateView");
            //}
            //return View(performance);
        }

        //----------------------- Details of Contact to Update -----------------------
        [HttpGet]
        public IActionResult ContactUpdate(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Student student = objectStudent.GetContactData(personID);

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateContact(int? personID, [Bind] Models.Student student)
        {
            if (personID == null)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objectStudent.UpdateContact(student);
            return RedirectToAction("ContactUpdateView");
            //}
            //return View(performance);
        }

        //----------------------- Details of School -----------------------
        [HttpGet]
        public IActionResult SchoolUpdate(int? personID)
        {
            if (personID == null)
            {
                return NotFound();
            }
            Student student = objectStudent.GetSchoolData(personID);

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateSchool(int? personID, [Bind] Models.Student student)
        {
            if (personID == null)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objectStudent.UpdateSchool(student);
            return RedirectToAction("SchoolUpdateView");
            //}
            //return View(performance);
        }

    }

    
}
