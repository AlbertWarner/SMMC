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
    public class EnsemblesController : Controller
    {
        EnsemblesDataAccessLayer objensembles = new EnsemblesDataAccessLayer();

        //----------------------- View Student -----------------------
        public IActionResult EnsemblesView()
        {
            List<Ensembles> listEnsemble = new List<Ensembles>();
            listEnsemble = objensembles.GetAllEnsembles().ToList();

            return View(listEnsemble);
        }

        public IActionResult EnsemblesDeleteView()
        {
            List<Ensembles> listEnsemble = new List<Ensembles>();
            listEnsemble = objensembles.GetAllEnsembles().ToList();

            return View(listEnsemble);
        }

        public IActionResult EnsemblesUpdateView()
        {
            List<Ensembles> listEnsemble = new List<Ensembles>();
            listEnsemble = objensembles.GetAllEnsembles().ToList();

            return View(listEnsemble);
        }



        //----------------------- Add Ensembles -----------------------
        [HttpGet]
        public IActionResult EnsemblesAdd()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnsemblesAdd([Bind] Models.Ensembles ensembles)
        {
            objensembles.AddEnsembles(ensembles);
            return RedirectToAction("EnsemblesView");
        }


        //----------------------- Update Ensembles -----------------------
        [HttpGet]
        public IActionResult EnsemblesUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Ensembles ensembles = objensembles.GetEnsemblesData(id);

            if (ensembles == null)
            {
                return NotFound();
            }
            return View(ensembles);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnsemblesUpdate(int id, [Bind] Models.Ensembles ensembles)
        {
            if (id != ensembles.EnsembleID)
            {
                return NotFound();
            }

            objensembles.UpdateEnsembles(ensembles);
            return RedirectToAction("EnsemblesUpdateView");
        }


        //----------------------- Details of Ensembles -----------------------
        [HttpGet]
        public IActionResult EnsemblesDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Ensembles ensembles = objensembles.GetEnsemblesData(id);

            if (ensembles == null)
            {
                return NotFound();
            }
            return View(ensembles);
        }


        //----------------------- Delete Ensembles -----------------------
        [HttpGet]
        public IActionResult EnsemblesDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Models.Ensembles ensembles = objensembles.GetEnsemblesData(id);

            if (ensembles == null)
            {
                return NotFound();
            }
            return View(ensembles);
        }

        [HttpPost, ActionName("EnsemblesDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult EnsemblesDeleteConfirmed(int? id)
        {
            objensembles.DeleteEnsembles(id);
            return RedirectToAction("EnsemblesDeleteView");
        }
    }
}
