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
    public class InstrumentController : Controller
    {
        //Created Data Access Layer Object
        InstrumentDataAccessLayer objinstrument = new InstrumentDataAccessLayer();

        //----------------------- Add Instrument -----------------------
        [HttpGet]
        public IActionResult InstrumentAdd()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InstrumentAdd([Bind] Models.Instrument instrument)
        {
            //if (ModelState.IsValid)
            //{
            objinstrument.AddInstrument(instrument);
            return RedirectToAction("InstrumentView");
            //}
            //return View(instrument);
        }


        //----------------------- Add Instrument Hire -----------------------
        [HttpGet]
        public IActionResult InstrumentHireAdd()
        {
            ViewBag.instrumentDrp = Drp_instrument();
            ViewBag.enrolmentDrp = Drp_enrolment();
            return View();
        }

        public List<SelectListItem> Drp_instrument()
        {
            List<Models.Instrument> instrument = new List<Models.Instrument>();
            instrument = objinstrument.GetAllInstruments().ToList();

            var drpInstrument = (from b in instrument
                                 select new SelectListItem
                                 {
                                     Text = b.Name.ToString(),
                                     Value = b.ID.ToString(),
                                 }).ToList();
            return drpInstrument;
        }

        public List<SelectListItem> Drp_enrolment()
        {
            List<Models.Instrument> enrolment = new List<Models.Instrument>();
            enrolment = objinstrument.GetEnrolment().ToList();

            var drpEnrolment = (from b in enrolment
                                select new SelectListItem
                                {
                                    Text = b.Firstname.ToString() + " " + b.Surname.ToString(),
                                    //Text = b.CastName.ToString(),
                                    Value = b.ID.ToString(),
                                }).ToList();
            return drpEnrolment;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InstrumentHireAdd([Bind] Models.Instrument instrument)
        {
            //if (ModelState.IsValid)
            //{
            objinstrument.AddInstrumentHire(instrument);
            return RedirectToAction("InstrumentHire");
            //}
            //return View(instrument);
        }


        //----------------------- View Instrument -----------------------
        public IActionResult InstrumentView()
        {
            List<Models.Instrument> lstInstrument = new List<Models.Instrument>();
            lstInstrument = objinstrument.GetAllInstruments().ToList();

            return View(lstInstrument);
        }

        public IActionResult InstrumentDeleteView()
        {
            List<Models.Instrument> lstInstrument = new List<Models.Instrument>();
            lstInstrument = objinstrument.GetAllInstruments().ToList();

            return View(lstInstrument);
        }

        public IActionResult InstrumentUpdateView()
        {
            List<Models.Instrument> lstInstrument = new List<Models.Instrument>();
            lstInstrument = objinstrument.GetAllInstruments().ToList();

            return View(lstInstrument);
        }

        public IActionResult InstrumentHire()
        {
            List<Models.Instrument> lstInstrument = new List<Models.Instrument>();
            lstInstrument = objinstrument.GetStudentInstrumentHire().ToList();

            return View(lstInstrument);
        }



        //----------------------- Update Instrument -----------------------
        [HttpGet]
        public IActionResult InstrumentUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Instrument instrument = objinstrument.GetInstrumentData(id);

            if (instrument == null)
            {
                return NotFound();
            }
            return View(instrument);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InstrumentUpdate(int id, [Bind] Models.Instrument instrument)
        {
            if (id != instrument.ID)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objinstrument.UpdateInstrument(instrument);
            return RedirectToAction("InstrumentUpdateView");
            //}
            //return View(instrument);
        }


        //----------------------- Update Instrument Hire Record -----------------------
        [HttpGet]
        public IActionResult InstrumentHireUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Instrument instrumentHire = objinstrument.GetInstrumentHireData(id);

            if (instrumentHire == null)
            {
                return NotFound();
            }
            return View(instrumentHire);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InstrumentHireUpdate(int id, [Bind] Models.Instrument instrument)
        {
            if (id != instrument.ID)
            {
                return NotFound();
            }
            //if (ModelState.IsValid)
            //{
            objinstrument.UpdateInstrumentHire(instrument);
            return RedirectToAction("InstrumentHire");
            //}
            //return View(instrument);
        }


        //----------------------- Details of Instrument -----------------------
        [HttpGet]
        public IActionResult InstrumentDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Instrument instrument = objinstrument.GetInstrumentData(id);

            if (instrument == null)
            {
                return NotFound();
            }
            return View(instrument);
        }


        //----------------------- Details of Instrument Hire -----------------------
        [HttpGet]
        public IActionResult InstrumentHireDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Instrument instrumentHire = objinstrument.GetInstrumentHireData(id);

            if (instrumentHire == null)
            {
                return NotFound();
            }
            return View(instrumentHire);
        }


        //----------------------- Delete Instrument -----------------------
        [HttpGet]
        public IActionResult InstrumentDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Instrument instrument = objinstrument.GetInstrumentData(id);

            if (instrument == null)
            {
                return NotFound();
            }
            return View(instrument);
        }

        [HttpPost, ActionName("InstrumentDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult InstrumentDeleteConfirmed(int? id)
        {
            objinstrument.DeleteInstrument(id);
            return RedirectToAction("InstrumentDeleteView");
        }
    }
}
