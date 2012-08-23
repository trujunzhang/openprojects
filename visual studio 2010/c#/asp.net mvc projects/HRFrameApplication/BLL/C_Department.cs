/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/2 10:11:38
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// ҵ���߼��� C_Department
    /// </summary>
    public class C_Department : BLHelper
    {
        private readonly DAL.C_Department dal = new DAL.C_Department();

        public C_Department()
            : base("C_Department_")
        { }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_Department model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_Department model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.DEPARTMENTID);
            }
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? DEPARTMENTID)
        {
            int count = dal.Delete(DEPARTMENTID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(DEPARTMENTID.ToString());
            }
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? DEPARTMENTID)
        {
            return dal.Exists(DEPARTMENTID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Department GetModel(int? DEPARTMENTID)
        {
            Model.C_Department model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(DEPARTMENTID);
            }
            else
            {
                string key = DEPARTMENTID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Department)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(DEPARTMENTID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_Department> GetList(string wheresql)
        {
            return dal.GetList(wheresql);
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Department> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }


    }
}
