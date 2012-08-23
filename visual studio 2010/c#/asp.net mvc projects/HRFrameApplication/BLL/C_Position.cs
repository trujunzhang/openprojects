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
    /// ҵ���߼��� C_Position
    /// </summary>
    public class C_Position : BLHelper
    {
        private readonly DAL.C_Position dal = new DAL.C_Position();

        public C_Position()
            : base("C_Position_")
        { }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_Position model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_Position model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.POSITIONID);
            }
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? POSITIONID)
        {
            int count = dal.Delete(POSITIONID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(POSITIONID.ToString());
            }
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? POSITIONID)
        {
            return dal.Exists(POSITIONID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Position GetModel(int? POSITIONID)
        {
            Model.C_Position model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(POSITIONID);
            }
            else
            {
                string key = POSITIONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Position)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(POSITIONID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        /// <param name="wheresql"> </param>
        public List<Model.C_Position> GetList(string wheresql)
        {
            return dal.GetList(wheresql);
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Position> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
