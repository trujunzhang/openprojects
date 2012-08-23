/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.5.0.0 �Զ������� 2012/6/22 9:14:52
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DAL
{
    /// <summary>
    /// ���ݷ����� PersonInChargeView
    /// </summary>
    public partial class PersonInChargeView : DALHelper
    {
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Model.PersonInChargeView model)
        {
            StringBuilder sbSql4PersonInChargeView;
            DbParameter[] parms4PersonInChargeView;
            PrepareAddCommand(model, out sbSql4PersonInChargeView, out parms4PersonInChargeView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInChargeView.ToString(), parms4PersonInChargeView);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Update(Model.PersonInChargeView model)
        {
            StringBuilder sbSql4PersonInChargeView;
            DbParameter[] parms4PersonInChargeView;
            PrepareUpdateCommand(model, out sbSql4PersonInChargeView, out parms4PersonInChargeView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInChargeView.ToString(), parms4PersonInChargeView);
        }
        
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public int Delete(int? PERSONID)
        {
            StringBuilder sbSql4PersonInChargeView;
            DbParameter[] parms4PersonInChargeView;
            PrepareDeleteCommand(PERSONID, out sbSql4PersonInChargeView, out parms4PersonInChargeView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInChargeView.ToString(), parms4PersonInChargeView);
        }
        
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.PersonInChargeView GetModel(int? PERSONID)
        {
            StringBuilder sbSql4PersonInChargeView;
            DbParameter[] parms4PersonInChargeView;
            PrepareGetModelCommand(PERSONID, out sbSql4PersonInChargeView, out parms4PersonInChargeView);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, sbSql4PersonInChargeView.ToString(), parms4PersonInChargeView))
            {
                if (dr.Read())
                {
                    return GetModel(dr);
                }
                return null;
            }
        }
        
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? PERSONID)
        {
            StringBuilder sbSql4PersonInChargeView;
            DbParameter[] parms4PersonInChargeView;
            PrepareExistCommand(PERSONID, out sbSql4PersonInChargeView, out parms4PersonInChargeView);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, sbSql4PersonInChargeView.ToString(), parms4PersonInChargeView);
            return int.Parse(obj.ToString()) > 0;
        }
        
        /// <summary>
        /// ��ȡ����
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM PersonInChargeView", null);
            return int.Parse(obj.ToString());
        }
        
        /// <summary>
        /// ��ȡ���������б�
        /// </summary>
        public List<Model.PersonInChargeView> GetList(string wheresql)
        {
            wheresql = "1=1";
            StringBuilder sbSql4PersonInChargeView = new StringBuilder(string.Format("SELECT * FROM PersonInChargeView where {0}",wheresql));
            sbSql4PersonInChargeView.Append(string.Format(" and {0}={1}", " ɾ����ʶ", "0"));
            //sbSql4PersonInChargeView.Append(string.Format(" and {0}={1}", "PERSONID", "11"));

            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, sbSql4PersonInChargeView.ToString(), null))
            {
                List<Model.PersonInChargeView> lst = GetList(dr);
                return lst;
            }
        }
        
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.PersonInChargeView> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();
            
            PageList<Model.PersonInChargeView> pl = new PageList<Model.PersonInChargeView>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM PersonInChargeView", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }
        
        #region -------- ˽�з��� --------
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        private Model.PersonInChargeView GetModel(DbDataReader dr)
        {
            Model.PersonInChargeView model = new Model.PersonInChargeView();
            PrepareModel(model, dr);
            return model;
        }
        
        /// <summary>
        /// ��DbDataReader�õ����������б�
        /// </summary>
        private List<Model.PersonInChargeView> GetList(DbDataReader dr)
        {
            List<Model.PersonInChargeView> lst = new List<Model.PersonInChargeView>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }
      
        /// <summary>
        /// ��DbDataReader�õ���ҳ���������б�
        /// </summary>
        private List<Model.PersonInChargeView> GetPageList(DbDataReader dr, int first, int count)
        {
            List<Model.PersonInChargeView> lst = new List<Model.PersonInChargeView>();
            
            for (int i = 0; i < first; i++)
            {
                if (!dr.Read())
                {
                    return lst;
                }
            }
            
            int resultsFetched = 0;
            while (resultsFetched < count && dr.Read())
            {
                lst.Add(GetModel(dr));
                resultsFetched++;
            }
            
            return lst;
        }
        #endregion
    }
}