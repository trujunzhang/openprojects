using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Model;

namespace HRMvcApplication.Models
{
    public class MechanismDetailModel
    {
        #region class fields 

        public C_Mechanism SelectedModel { get; set; }

        #endregion

        #region constructor

        public MechanismDetailModel(C_Mechanism cMechanism)
        {
            SelectedModel = cMechanism;
            SelectedMechanismid = (int) SelectedModel.MECHANISMID;
        }

        public MechanismDetailModel()
        {
        }

        #endregion

        #region listbox models

        public MultiSelectList AvailableSelectList; //未选负责人
        public MultiSelectList RequestedSelectList; //已选负责人
        private int _selectedMechanismid;

        public List<int> AvailableProducts { get; set; } //未选负责人
        public List<int> RequestedProducts { get; set; } //已选负责人

        public int SelectedMechanismid
        {
            get { return _selectedMechanismid; }
            set
            {
                _selectedMechanismid = value;
                RequestedSelectList = GetRequestedSelectList(null);
                AvailableSelectList = GetAvailableSelectList(null);
            }
        }

        private MultiSelectList GetRequestedSelectList(string[] selectedvalues)
        {
            string wheresql = string.Format("MECHANISMID={0}", SelectedMechanismid);
            List<PersonInChargeView> modelList = new BLL.PersonInChargeView().GetList(wheresql);
            PersonInChargeView first = modelList[0];
            first.姓名 = "wangho" + DateTime.Now.ToString();
            return new MultiSelectList(modelList, "PERSONINCHARGEID", "姓名", selectedvalues);
        }

        private MultiSelectList GetAvailableSelectList(string[] selectedvalues)
        {
            var modelList = new List<PersonInPositionView>();
            //if (MechDepPositionId != null && MechDepPositionId[0] != -1)
            //    modelList = GetPersonInPosition();

            return new MultiSelectList(modelList, "POSITIONID", "姓名", selectedvalues);
        }

        private List<PersonInPositionView> GetPersonInPosition()
        {
            //List<PersonInPositionView> modelList;
            var wheresql = new StringBuilder(string.Format("1=1"));
            // search by personname
            //if (!string.IsNullOrEmpty(PersonName))
            //{
            //    wheresql.Append(string.Format(" and {0} like '%{1}%'", "姓名", PersonName));
            //}
            // search by ids
            //for (int i = 0; i < MechDepPositionId.Length; i++)
            //{
            //    if (MechDepPositionId[i] >= 0)
            //        wheresql.Append(string.Format(" and {0}={1}", MechDepPositionNames[i], MechDepPositionId[i]));
            //}
            List<PersonInPositionView> modelList = new BLL.PersonInPositionView().GetList(wheresql.ToString());
            // filter by used person
            foreach (PersonInChargeView item in RequestedSelectList.Items)
            {
                PersonInPositionView search = modelList.Find(model => model.PERSONID == (int) item.PERSONID);
                if (search != null)
                    modelList.Remove(search);
            }
            return modelList;
        }

        #endregion
    }
}