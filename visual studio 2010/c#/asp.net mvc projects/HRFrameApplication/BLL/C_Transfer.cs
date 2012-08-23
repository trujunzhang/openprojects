/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/23 8:38:39
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
    /// ҵ���߼��� C_Transfer
    /// </summary>
    public class C_Transfer : BLHelper
    {
        private readonly DAL.C_Transfer dal = new DAL.C_Transfer();
      
        public C_Transfer()
            : base("C_Transfer_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_Transfer model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_Transfer model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.TRANSFERID);
            }
        }
      
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? TRANSFERID)
        {
            int count = dal.Delete(TRANSFERID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(TRANSFERID.ToString());
            }
        }      
      
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? TRANSFERID)
        {
            return dal.Exists(TRANSFERID);
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Transfer GetModel(int? TRANSFERID)
        {
            Model.C_Transfer model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(TRANSFERID);
            }
            else
            {
                string key = TRANSFERID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Transfer)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(TRANSFERID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_Transfer> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Transfer> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    