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
    /// ҵ���߼��� C_PersonnelDocumentsClass
    /// </summary>
    public class C_PersonnelDocumentsClass : BLHelper
    {
        private readonly DAL.C_PersonnelDocumentsClass dal = new DAL.C_PersonnelDocumentsClass();
      
        public C_PersonnelDocumentsClass()
            : base("C_PersonnelDocumentsClass_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_PersonnelDocumentsClass model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_PersonnelDocumentsClass model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.PERSONNELDOCUMENTSCLASSID);
            }
        }
      
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? PERSONNELDOCUMENTSCLASSID)
        {
            int count = dal.Delete(PERSONNELDOCUMENTSCLASSID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(PERSONNELDOCUMENTSCLASSID.ToString());
            }
        }      
      
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? PERSONNELDOCUMENTSCLASSID)
        {
            return dal.Exists(PERSONNELDOCUMENTSCLASSID);
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_PersonnelDocumentsClass GetModel(int? PERSONNELDOCUMENTSCLASSID)
        {
            Model.C_PersonnelDocumentsClass model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONNELDOCUMENTSCLASSID);
            }
            else
            {
                string key = PERSONNELDOCUMENTSCLASSID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_PersonnelDocumentsClass)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(PERSONNELDOCUMENTSCLASSID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_PersonnelDocumentsClass> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_PersonnelDocumentsClass> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    