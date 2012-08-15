using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListBoxDemo.Models;

namespace ListBoxDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewModel model = new ViewModel { AvailableProducts = Product.GetAllProducts(), RequestedProducts = new List<Product>() };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ViewModel model, string add, string remove, string send)
        {
            //Need to clear model state or it will interfere with the updated model
            ModelState.Clear();
            RestoreSavedState(model);
            if (!string.IsNullOrEmpty(add))
                AddProducts(model);
            else if (!string.IsNullOrEmpty(remove))
                RemoveProducts(model);
            else if (!string.IsNullOrEmpty(send))
            {
                Validate(model);
                if (ModelState.IsValid)
                    return RedirectToAction("Done");
                //todo: implement SendListToSanta method...
            }
            SaveState(model);
            return View(model);
        }

        public ViewResult Done()
        {
            return View();
        }

        #region SupportFuncs
        private void Validate(ViewModel model)
        {
            if (model.RequestedTotal > 400m)
                ModelState.AddModelError("", "Total must be 400 or less");
            if (model.RequestedProducts.Count > 3)
                ModelState.AddModelError("", "Maximum of 3 selections allowed");
            if (string.IsNullOrEmpty(model.SavedRequested))
                ModelState.AddModelError("", "You haven't selected any presents!");
        }

        void SaveState(ViewModel model)
        {
            //create comma delimited list of product ids
            model.SavedRequested = string.Join(",", model.RequestedProducts.Select(p => p.Id.ToString()).ToArray());

            //Available products = All - Requested
            model.AvailableProducts = Product.GetAllProducts().Except(model.RequestedProducts).ToList();
        }

        void RemoveProducts(ViewModel model)
        {
            if (model.RequestedSelected != null)
            {
                model.RequestedProducts.RemoveAll(p => model.RequestedSelected.Contains(p.Id));
                model.RequestedSelected = null;
            }
        }

        void AddProducts(ViewModel model)
        {
            if (model.AvailableSelected != null)
            {
                var prods = Product.GetAllProducts().Where(p => model.AvailableSelected.Contains(p.Id));
                model.RequestedProducts.AddRange(prods);
                model.AvailableSelected = null;
            }
        }

        void RestoreSavedState(ViewModel model)
        {
            model.RequestedProducts = new List<Product>();

            //get the previously stored items
            if (!string.IsNullOrEmpty(model.SavedRequested))
            {
                string[] prodids = model.SavedRequested.Split(',');
                var prods = Product.GetAllProducts().Where(p => prodids.Contains(p.Id.ToString()));
                model.RequestedProducts.AddRange(prods);
            }
        }
        #endregion
    }
}
