/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/2 10:11:36
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
    /// ���ݷ����� C_Mechanism
    /// </summary>
    public partial class C_Mechanism : DALHelper
    {
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Model.C_Mechanism model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareAddCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Update(Model.C_Mechanism model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareUpdateCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public int Delete(int? MECHANISMID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareDeleteCommand(MECHANISMID, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_Mechanism GetModel(int? MECHANISMID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareGetModelCommand(MECHANISMID, out strSql, out cmdParms);
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
        public bool Exists(int? MECHANISMID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareExistCommand(MECHANISMID, out strSql, out cmdParms);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
            return int.Parse(obj.ToString()) > 0;
        }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM C_Mechanism", null);
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// ��ȡ���������б�
        /// </summary>
        public List<Model.C_Mechanism> GetList()
        {
            StringBuilder strSql = new StringBuilder("SELECT * FROM C_Mechanism");
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<Model.C_Mechanism> lst = GetList(dr);
                return lst;
            }
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_Mechanism> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();

            PageList<Model.C_Mechanism> pl = new PageList<Model.C_Mechanism>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM C_Mechanism", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }

        #region -------- ˽�з��� --------
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        private Model.C_Mechanism GetModel(DbDataReader dr)
        {
            Model.C_Mechanism model = new Model.C_Mechanism();
            PrepareModel(model, dr);
            return model;
        }

        /// <summary>
        /// ��DbDataReader�õ����������б�
        /// </summary>
        private List<Model.C_Mechanism> GetList(DbDataReader dr)
        {
            List<Model.C_Mechanism> lst = new List<Model.C_Mechanism>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }

        /// <summary>
        /// ��DbDataReader�õ���ҳ���������б�
        /// </summary>
        private List<Model.C_Mechanism> GetPageList(DbDataReader dr, int first, int count)
        {
            List<Model.C_Mechanism> lst = new List<Model.C_Mechanism>();

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

        public DataSet GetDataSet()
        {
            StringBuilder strSql = new StringBuilder("SELECT * FROM C_Mechanism");

            return dbHelper.ExecuteQuery(CommandType.Text, strSql.ToString(), null);
        }



    }
}