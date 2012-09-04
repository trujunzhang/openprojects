using System.Linq;
using System.Web.Mvc;
using HRMvcApplication.Models;
using Model;
using MvcContrib.UI.Grid;

namespace HRMvcApplication.Controllers
{
    public class MechanismController : Controller
    {
        #region List view

        public ActionResult List(string searchWord, int? genreId, int? artistId, GridSortOptions gridSortOptions,
                                 int? page)
        {
            PagedViewModel<C_Mechanism> pagedViewModel = new PagedViewModel<C_Mechanism>
                                                             {
                                                                 ViewData = ViewData,
                                                                 Query = new BLL.C_Mechanism().GetList().AsQueryable(),
                                                                 GridSortOptions = gridSortOptions,
                                                                 DefaultSortColumn = "MECHANISMID",
                                                                 Page = page,
                                                                 PageSize = 10,
                                                             }
                .AddFilter("searchWord", searchWord, a => a.机构名称.Contains(searchWord))
                .Setup();

            return View(pagedViewModel);
        }

        #endregion

        #region detail view

        public ActionResult Details(string id)
        {
            var viewModel = new MechanismDetailModel(-1);
            viewModel.ModelEventType = "保存";
            if (id != "new")
            {
                viewModel = new MechanismDetailModel(new BLL.C_Mechanism().GetModel(int.Parse(id)));
                viewModel.ModelEventType = "更新";
            }
            Session["mechanismid"] = id;
            Session["viewmodel"] = viewModel; // used by MechanismModel()
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Details(MechanismDetailModel model, string create, string add, string remove, string up,
                                    string down)
        {
            var viewModel = Session["viewmodel"] as MechanismDetailModel; // used by MechanismModel()
            if (!string.IsNullOrEmpty(create)) //model的form事件【保存或更新】
            {
                model.SelectedModel.删除标识 = false;
                new BLL.C_Mechanism().Update(model.SelectedModel);
            }
            else if (!string.IsNullOrEmpty(remove)) //联系人列表删除事件
            {
                //if (model.RequestedProducts != null)
                if (true)
                {
                    //foreach (int PERSONINCHARGEID in model.RequestedProducts)
                    if (true)
                    {
                        //C_PersonInCharge personInCharge = new BLL.C_PersonInCharge().GetModel(PERSONINCHARGEID);
                        //personInCharge.删除标识 = true;
                        //new BLL.C_PersonInCharge().Update(personInCharge);
                    }
                }
            }
            else // 弹出联系人对话框后，调用this.form.subform后，重新更新联系人列表的事件
            {
                //model.SelectedMechanismid = (int) model.SelectedModel.MECHANISMID;
            }

            viewModel = new MechanismDetailModel(28);
            return View(viewModel);
        }

        #endregion

        #region CreateContract

        public ActionResult CreateContract(string id)
        {

            return PartialView("CreateContract");
        }

        #endregion

        #region twolist

        public ActionResult TwoList()
        {
            string id = "28";
            var viewModel = new MechanismDetailModel(int.Parse(id));
            return PartialView("TwoList",viewModel);
        }
 
        #endregion

    }
}