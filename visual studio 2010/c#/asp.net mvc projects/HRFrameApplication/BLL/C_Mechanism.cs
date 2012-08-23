/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/2 10:11:37
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
    /// ҵ���߼��� C_Mechanism
    /// </summary>
    public class C_Mechanism : BLHelper
    {
        private readonly DAL.C_Mechanism dal = new DAL.C_Mechanism();

        public C_Mechanism()
            : base("C_Mechanism_")
        { }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_Mechanism model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_Mechanism model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.MECHANISMID);
            }
        }

        /// <summary>
        /// TODO [CHANGE]{2011-09-14}
        /// ɾ��һ������
        /// </summary>
        public int Delete(int? MECHANISMID)
        {
            int count = dal.Delete(MECHANISMID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(MECHANISMID.ToString());
            }
            return count;
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? MECHANISMID)
        {
            return dal.Exists(MECHANISMID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Mechanism GetModel(int? MECHANISMID)
        {
            Model.C_Mechanism model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(MECHANISMID);
            }
            else
            {
                string key = MECHANISMID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Mechanism)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(MECHANISMID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_Mechanism> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Mechanism> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }

        public System.Data.DataSet GetDataSet()
        {
            return dal.GetDataSet();
        }


    }
}
