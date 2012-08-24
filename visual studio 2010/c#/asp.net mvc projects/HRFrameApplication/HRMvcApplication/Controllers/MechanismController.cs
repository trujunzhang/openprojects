using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMvcApplication.Controllers
{
    public class MechanismController : Controller
    {
        //
        // GET: /Mechanism/

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

        }

    }
}
