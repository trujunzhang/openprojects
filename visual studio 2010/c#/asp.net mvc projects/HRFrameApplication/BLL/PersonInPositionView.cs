/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.5.0.0 �Զ������� 2012/7/2 11:20:23
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
    /// ҵ���߼��� PersonInPositionView
    /// </summary>
    public class PersonInPositionView : BLHelper
    {
        private readonly DAL.PersonInPositionView dal = new DAL.PersonInPositionView();
      
        public PersonInPositionView()
            : base("PersonInPositionView_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.PersonInPositionView model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.PersonInPositionView model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.PERSONID);
            }
        }
      
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? PERSONID)
        {
            int count = dal.Delete(PERSONID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(PERSONID.ToString());
            }
        }      
      
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
        public Model.PersonInPositionView GetModel(int? PERSONID)
        {
            Model.PersonInPositionView model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONID);
            }
            else
            {
                string key = PERSONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.PersonInPositionView)GetModelCache(key);
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
        public List<Model.PersonInPositionView> GetList(string wheresql)
        {
            List<Model.PersonInPositionView> lst = dal.GetList(wheresql);
            return lst;
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.PersonInPositionView> GetPageList(PageInfo pi)
        {
            PageList<Model.PersonInPositionView> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
    