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
using System.Data;
using System.Data.Common;
using System.Text;

namespace DAL
{
    /// <summary>
    /// ���ݷ����� C_Transfer
    /// </summary>
    public partial class C_Transfer : DALHelper
    {
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Model.C_Transfer model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareAddCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Update(Model.C_Transfer model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareUpdateCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public int Delete(int? TRANSFERID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareDeleteCommand(TRANSFERID, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Transfer GetModel(int? TRANSFERID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareGetModelCommand(TRANSFERID, out strSql, out cmdParms);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
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
        public bool Exists(int? TRANSFERID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareExistCommand(TRANSFERID, out strSql, out cmdParms);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
            return int.Parse(obj.ToString()) > 0;
        }
        
        /// <summary>
        /// ��ȡ����
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM C_Transfer", null);
            return int.Parse(obj.ToString());
        }
        
        /// <summary>
        /// ��ȡ���������б�
        /// </summary>
        public List<Model.C_Transfer> GetList()
        {
            StringBuilder strSql = new StringBuilder("SELECT * FROM C_Transfer");
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<Model.C_Transfer> lst = GetList(dr);
                return lst;
            }
        }
        
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Transfer> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();
            
            PageList<Model.C_Transfer> pl = new PageList<Model.C_Transfer>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM C_Transfer", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }
        
        #region -------- ˽�з��� --------
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        private Model.C_Transfer GetModel(DbDataReader dr)
        {
            Model.C_Transfer model = new Model.C_Transfer();
            PrepareModel(model, dr);
            return model;
        }
        
        /// <summary>
        /// ��DbDataReader�õ����������б�
        /// </summary>
        private List<Model.C_Transfer> GetList(DbDataReader dr)
        {
            List<Model.C_Transfer> lst = new List<Model.C_Transfer>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }
      
        /// <summary>
        /// ��DbDataReader�õ���ҳ���������б�
        /// </summary>
        private List<Model.C_Transfer> GetPageList(DbDataReader dr, int first, int count)
        {
            List<Model.C_Transfer> lst = new List<Model.C_Transfer>();
            
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