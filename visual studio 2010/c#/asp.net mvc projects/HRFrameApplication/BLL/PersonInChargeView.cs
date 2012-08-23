/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.5.0.0 �Զ������� 2012/6/22 9:14:52
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// ҵ���߼��� PersonInChargeView
    /// </summary>
    public class PersonInChargeView : BLHelper
    {
        private readonly DAL.PersonInChargeView dal = new DAL.PersonInChargeView();
      
        public PersonInChargeView()
            : base("PersonInChargeView_")
        { }
      
      
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? PERSONID)
        {
            bool bln = dal.Exists(PERSONID);
            return bln;
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.PersonInChargeView GetModel(int? PERSONID)
        {
            Model.PersonInChargeView model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONID);
            }
            else
            {
                string key = PERSONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.PersonInChargeView)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(PERSONID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.PersonInChargeView> GetList(string wheresql)
        {
            List<Model.PersonInChargeView> lst = dal.GetList(wheresql);
            return lst;
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.PersonInChargeView> GetPageList(PageInfo pi)
        {
            PageList<Model.PersonInChargeView> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
    