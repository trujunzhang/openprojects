/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/6 9:56:57
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
    /// ҵ���߼��� C_Person
    /// </summary>
    public class C_Person : BLHelper
    {
        private readonly DAL.C_Person dal = new DAL.C_Person();

        public C_Person()
            : base("C_Person_")
        { }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_Person model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_Person model)
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
            return dal.Exists(PERSONID);
        }

        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Person GetModel(string tableColumnName, int? PERSONID)
        {
            Model.C_Person model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(tableColumnName, PERSONID);
            }
            else
            {
                string key = PERSONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Person)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(tableColumnName, PERSONID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Person GetModel(string tableColumnName, string PERSONID)
        {
            Model.C_Person model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(tableColumnName, PERSONID);
            }
            else
            {
                string key = PERSONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Person)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(tableColumnName, PERSONID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_Person> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Person> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }

    }
}
