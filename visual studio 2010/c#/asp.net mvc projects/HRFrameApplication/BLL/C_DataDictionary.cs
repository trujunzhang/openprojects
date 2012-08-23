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
    /// ҵ���߼��� C_DataDictionary
    /// </summary>
    public class C_DataDictionary : BLHelper
    {
        private readonly DAL.C_DataDictionary dal = new DAL.C_DataDictionary();

        public C_DataDictionary()
            : base("C_DataDictionary_")
        { }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_DataDictionary model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_DataDictionary model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.DATADICTIONARY_ID);
            }
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? DATADICTIONARY_ID)
        {
            int count = dal.Delete(DATADICTIONARY_ID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(DATADICTIONARY_ID.ToString());
            }
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? DATADICTIONARY_ID)
        {
            return dal.Exists(DATADICTIONARY_ID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_DataDictionary GetModel(int? DATADICTIONARY_ID)
        {
            Model.C_DataDictionary model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(DATADICTIONARY_ID);
            }
            else
            {
                string key = DATADICTIONARY_ID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_DataDictionary)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(DATADICTIONARY_ID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        /// <summary>
        /// TODO [CUSTOM]{2011-09-30}
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_DataDictionary GetModel(String weresql)
        {
            Model.C_DataDictionary model = null;

            model = dal.GetModel(weresql);

            return model;
        }
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_DataDictionary> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_DataDictionary> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
