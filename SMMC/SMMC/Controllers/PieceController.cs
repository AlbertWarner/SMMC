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
    public class PieceController : Controller
    {
        //Created Data Access Layer Object
        PieceDataAccessLayer objpiece = new PieceDataAccessLayer();

        //----------------------- Add Piece -----------------------
        [HttpGet]
        public IActionResult PieceAdd()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PieceAdd([Bind] Models.Piece piece)
        {
            //if (ModelState.IsValid)
            //{
            //piece.Type = "Orchestral Test " + piece.Type;
            objpiece.AddPiece(piece);
            return RedirectToAction("PieceView");
            //}
            //return View(piece);
        }


        //----------------------- Add Piece Hire -----------------------
        [HttpGet]
        public IActionResult EnrolmentPieceHireAdd()
        {
            ViewBag.pieceDrp = Drp_piece();
            ViewBag.enrolmentDrp = Drp_enrolment();
            //ViewBag.performanceDrp = Drp_performance();
            return View();
        }

        [HttpGet]
        public IActionResult PerformancePieceHireAdd()
        {
            ViewBag.pieceDrp = Drp_piece();
            //ViewBag.enrolmentDrp = Drp_enrolment();
            ViewBag.performanceDrp = Drp_performance();
            return View();
        }

        public List<SelectListItem> Drp_piece()
        {
            List<Models.Piece> piece = new List<Models.Piece>();
            piece = objpiece.GetAllPiece().ToList();

            var drpPiece = (from b in piece
                            select new SelectListItem
                            {
                                Text = b.Type.ToString(),
                                Value = b.PieceID.ToString(),
                            }).ToList();
            return drpPiece;
        }

        public List<SelectListItem> Drp_enrolment()
        {
            List<Models.Piece> enrolment = new List<Models.Piece>();
            enrolment = objpiece.GetEnrolment().ToList();

            var drpEnrolment = (from b in enrolment
                                select new SelectListItem
                                {
                                    Text = b.Firstname.ToString() + " " + b.Surname.ToString(),
                                    Value = b.EnrolmentID.ToString(),
                                }).ToList();
            return drpEnrolment;
        }

        public List<SelectListItem> Drp_performance()
        {
            List<Models.Piece> performance = new List<Models.Piece>();
            performance = objpiece.GetPerformance().ToList();

            var drpPerformance = (from b in performance
                                select new SelectListItem
                                {
                                    Text = b.Venue.ToString() + " - " + b.PerformanceDate.ToShortDateString(),
                                    Value = b.PerformanceID.ToString(),
                                }).ToList();
            return drpPerformance;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnrolmentPieceHireAdd([Bind] Models.Piece piece)
        {
            //if (ModelState.IsValid)
            //{
            objpiece.AddEnrolmentPieceHire(piece);
            return RedirectToAction("EnrolmentPieceHire");
            //}
            //return View(piece);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PerformancePieceHireAdd([Bind] Models.Piece piece)
        {
            //if (ModelState.IsValid)
            //{
            //if(piece.Type == "Orchestral Test") { TempData["msg"] = "<script>alert('Change succesfully');</script>"; }
            objpiece.AddPerformancePieceHire(piece);
            return RedirectToAction("PerformancePieceHire");
            //}
            //return View(piece);
        }


        //----------------------- View Piece -----------------------
        public IActionResult PieceView()
        {
            List<Models.Piece> lstPiece = new List<Models.Piece>();
            lstPiece = objpiece.GetAllPiece().ToList();

            return View(lstPiece);
        }

        public IActionResult PieceUpdateView()
        {
            List<Models.Piece> lstPiece = new List<Models.Piece>();
            lstPiece = objpiece.GetAllPiece().ToList();

            return View(lstPiece);
        }

        public IActionResult PieceDeleteView()
        {
            List<Models.Piece> lstPiece = new List<Models.Piece>();
            lstPiece = objpiece.GetAllPiece().ToList();

            return View(lstPiece);
        }



        //----------------------- View Piece Hire -----------------------
        public IActionResult PerformancePieceHire()
        {
            List<Models.Piece> lstPerfPieceHire = new List<Models.Piece>();
            lstPerfPieceHire = objpiece.GetPerformancePieceHire().ToList();

            return View(lstPerfPieceHire);
        }

        public IActionResult EnrolmentPieceHire()
        {
            List<Models.Piece> lstEnrolPieceHire = new List<Models.Piece>();
            lstEnrolPieceHire = objpiece.GetEnrolmentPieceHire().ToList();

            return View(lstEnrolPieceHire);
        }




        //----------------------- Update Piece -----------------------
        [HttpGet]
        public IActionResult PieceUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Piece piece = objpiece.GetPieceData(id);

            if (piece == null)
            {
                return NotFound();
            }
            return View(piece);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PieceUpdate(int id, [Bind] Models.Piece piece)
        {
            if (id != piece.PieceID)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objpiece.UpdatePiece(piece);
            return RedirectToAction("PieceUpdateView");
            //}
            //return View(piece);
        }


        //----------------------- Update Enrolment Piece Hire Record -----------------------
        [HttpGet]
        public IActionResult EnrolmentPieceHireUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Piece pieceHire = objpiece.GetPieceHireData(id);

            if (pieceHire == null)
            {
                return NotFound();
            }
            return View(pieceHire);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnrolmentPieceHireUpdate(int id, [Bind] Models.Piece piece)
        {
            if (id != piece.PieceHireID)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objpiece.UpdateEnrolmentPieceHire(piece);
            return RedirectToAction("EnrolmentPieceHire");
            //}
            //return View(piece);
        }


        //----------------------- Update Performance Piece Hire Record -----------------------
        [HttpGet]
        public IActionResult PerformancePieceHireUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Piece pieceHire = objpiece.GetPieceHireData(id);

            if (pieceHire == null)
            {
                return NotFound();
            }
            return View(pieceHire);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PerformancePieceHireUpdate(int id, [Bind] Models.Piece piece)
        {
            if (id != piece.PieceHireID)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objpiece.UpdatePerformancePieceHire(piece);
            return RedirectToAction("PerformancePieceHire");
            //}
            //return View(piece);
        }


        //----------------------- Details of Piece -----------------------
        [HttpGet]
        public IActionResult PieceDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Piece piece = objpiece.GetPieceData(id);

            if (piece == null)
            {
                return NotFound();
            }
            return View(piece);
        }

        //----------------------- Delete Piece -----------------------
        [HttpGet]
        public IActionResult PieceDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Piece piece = objpiece.GetPieceData(id);

            if (piece == null)
            {
                return NotFound();
            }

            return View(piece);
        }

        [HttpPost, ActionName("PieceDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult PieceDeleteConfirmed(int? id)
        {
            objpiece.DeletePiece(id);
            return RedirectToAction("PieceDeleteView");
        }

    }
}
