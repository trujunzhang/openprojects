using System.Web.Mvc;
using HRMvcApplication.Models;

namespace HRMvcApplication.Controllers
{
    public class SharedController : Controller
    {
        public ActionResult MechanismByDepartment()
        {
            var mechanismByDepartModel = new MechanismByDepartModel();
            Session["MechanismByDepartment"] = mechanismByDepartModel;
            return View(mechanismByDepartModel);
        }

        [HttpPost]
        public ActionResult MechanismByDepartment(MechanismByDepartModel post, string mechanismid, string departmentid,
                                                  string positionid)
        {
            var last = Session["MechanismByDepartment"] as MechanismByDepartModel;
            string _mechanismid = last.MechanismId + "";
            string _departmentid = last.DepartmentId + "";
            string _positionid = last.PositionId + "";
            if (_mechanismid != mechanismid)
            {
                post.DepartmentId = -1;
                post.PositionId = -1;
            }
            Session["MechanismByDepartment"] = post;
            return View(post);
        }
    }
}