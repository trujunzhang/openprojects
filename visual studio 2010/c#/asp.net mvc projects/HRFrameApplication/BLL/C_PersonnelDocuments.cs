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
    /// ҵ���߼��� C_PersonnelDocuments
    /// </summary>
    public class C_PersonnelDocuments : BLHelper
    {
        private readonly DAL.C_PersonnelDocuments dal = new DAL.C_PersonnelDocuments();
      
        public C_PersonnelDocuments()
            : base("C_PersonnelDocuments_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_PersonnelDocuments model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_PersonnelDocuments model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.PERSONNELDOCUMENTSID);
            }
        }
      
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? PERSONNELDOCUMENTSID)
        {
            int count = dal.Delete(PERSONNELDOCUMENTSID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(PERSONNELDOCUMENTSID.ToString());
            }
        }      
      
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? PERSONNELDOCUMENTSID)
        {
            return dal.Exists(PERSONNELDOCUMENTSID);
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_PersonnelDocuments GetModel(int? PERSONNELDOCUMENTSID)
        {
            Model.C_PersonnelDocuments model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONNELDOCUMENTSID);
            }
            else
            {
                string key = PERSONNELDOCUMENTSID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_PersonnelDocuments)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(PERSONNELDOCUMENTSID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_PersonnelDocuments> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_PersonnelDocuments> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    