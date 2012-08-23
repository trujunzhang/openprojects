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
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// ҵ���߼��� C_Office
    /// </summary>
    public class C_Office : BLHelper
    {
        private readonly DAL.C_Office dal = new DAL.C_Office();

        public C_Office()
            : base("C_Office_")
        { }

        /// <summary>
        /// TODO [CUSTOM]{2011-09-16}
        /// ����һ������
        /// </summary>
        public int Add(Model.C_Office model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_Office model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.OFFICEID);
            }
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? OFFICEID)
        {
            int count = dal.Delete(OFFICEID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(OFFICEID.ToString());
            }
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? OFFICEID)
        {
            return dal.Exists(OFFICEID);
        }

        /// <summary>
        /// TODO [Custom]{2011-09-23}
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Office GetModel(string whereSql)
        {
            return dal.GetModel(whereSql);
        }

        /// <summary>        
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Office GetModel(int? OFFICEID)
        {
            Model.C_Office model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(OFFICEID);
            }
            else
            {
                string key = OFFICEID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Office)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(OFFICEID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_Office> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Office> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
