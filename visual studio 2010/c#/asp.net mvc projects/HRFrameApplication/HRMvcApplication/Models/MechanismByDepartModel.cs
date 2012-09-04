using System.Collections.Generic;
using System.Web.Mvc;
using Model;

namespace HRMvcApplication.Models
{
    public class MechanismByDepartModel
    {
        public string DepartmentName = "departmentid";
        public string MechanismName = "mechanismid";
        public string PositionName = "positionid";

        public MechanismByDepartModel(int mechanismid, int departmentid, int positionid)
        {
            MechanismId = mechanismid;
            DepartmentId = departmentid;
            PositionId = positionid;
        }

        public MechanismByDepartModel()
        {
            MechanismId = -1;
            DepartmentId = -1;
            PositionId = -1;
        }

        public IEnumerable<SelectListItem> DepartmentList
        {
            get { return GetDepartmentList(); }
        }

        public List<SelectListItem> MechanismList
        {
            get { return GetMechanismList(); }
        }

        public IEnumerable<SelectListItem> PositionList
        {
            get { return GetPositionList(); }
        }

        //private int mechanismId;
        //private int departmentId;
        //private int positionId;

        public int MechanismId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }

        public List<SelectListItem> GetMechanismList()
        {
            List<C_Mechanism> list = new BLL.C_Mechanism().GetList();
            var selectList = new List<SelectListItem>();
            foreach (C_Mechanism item in list)
            {
                selectList.Add(new SelectListItem
                                   {
                                       Text = item.机构名称,
                                       Value = (item.MECHANISMID + ""),
                                       Selected = (MechanismId == item.MECHANISMID)
                                   });
            }
            return selectList;
        }

        public IEnumerable<SelectListItem> GetDepartmentList()
        {
            string wheresql = string.Format("{0}={1}", "MECHANISMID", MechanismId);
            List<C_Department> list = new BLL.C_Department().GetList(wheresql);
            var selectList = new List<SelectListItem>();
            foreach (C_Department item in list)
            {
                selectList.Add(new SelectListItem
                                   {
                                       Text = item.部门名称,
                                       Value = (item.DEPARTMENTID + ""),
                                       Selected = (DepartmentId == item.DEPARTMENTID)
                                   });
            }
            return selectList;
        }

        public IEnumerable<SelectListItem> GetPositionList()
        {
            string wheresql = string.Format("{0}={1}", "DEPARTMENTID", DepartmentId);
            List<C_Position> list = new BLL.C_Position().GetList(wheresql);
            var selectList = new List<SelectListItem>();
            foreach (C_Position item in list)
            {
                selectList.Add(new SelectListItem
                                   {
                                       Text = item.职位名称,
                                       Value = (item.POSITIONID + ""),
                                       Selected = (PositionId == item.POSITIONID)
                                   });
            }
            return selectList;
        }
    }
}