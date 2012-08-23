/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/26 9:33:02
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
    /// ҵ���߼��� C_SignedContract
    /// </summary>
    public class C_SignedContract : BLHelper
    {
        private readonly DAL.C_SignedContract dal = new DAL.C_SignedContract();

        public C_SignedContract()
            : base("C_SignedContract_")
        { }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(Model.C_SignedContract model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Model.C_SignedContract model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.SIGNDCONTRACTID);
            }
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? SIGNDCONTRACTID)
        {
            int count = dal.Delete(SIGNDCONTRACTID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(SIGNDCONTRACTID.ToString());
            }
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? SIGNDCONTRACTID)
        {
            return dal.Exists(SIGNDCONTRACTID);
        }

        /// <summary>
        /// TODO [Custom][2011-09-08]
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_SignedContract GetModel(string tableColumnName, int? SIGNDCONTRACTID)
        {
            Model.C_SignedContract model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(tableColumnName, SIGNDCONTRACTID);
            }            
            return model;
        }

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<Model.C_SignedContract> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_SignedContract> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
