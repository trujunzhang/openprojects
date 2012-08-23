/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/6 13:43:55
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
    /// ҵ���߼��� C_Contract
    /// </summary>
    public class C_Contract : BLHelper
    {
        private readonly DAL.C_Contract dal = new DAL.C_Contract();

        public C_Contract()
            : base("C_Contract_")
        { }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_Contract model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_Contract model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.CONTRACTID);
            }
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? CONTRACTID)
        {
            int count = dal.Delete(CONTRACTID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(CONTRACTID.ToString());
            }
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? CONTRACTID)
        {
            return dal.Exists(CONTRACTID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Contract GetModel(int? CONTRACTID)
        {
            Model.C_Contract model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(CONTRACTID);
            }
            else
            {
                string key = CONTRACTID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Contract)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(CONTRACTID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_Contract> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Contract> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
