/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/7 9:53:22
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
    /// ���ݷ����� C_PersonInCharge
    /// </summary>
    public partial class C_PersonInCharge : DALHelper
    {
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Model.C_PersonInCharge model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareAddCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Update(Model.C_PersonInCharge model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareUpdateCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public int Delete(int? PERSONINCHARGEID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareDeleteCommand(PERSONINCHARGEID, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// TODO [Custom][2011-09-08]
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_PersonInCharge GetModel(string tableColumnName, int? PERSONINCHARGEID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareGetModelCommand(tableColumnName, PERSONINCHARGEID, out strSql, out cmdParms);
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
        /// TODO [Custom][2011-09-08]
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.C_PersonInCharge GetModel(int? PERSONINCHARGEID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareGetModelCommand(PERSONINCHARGEID, out strSql, out cmdParms);
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
        /// TODO [Custom]{change}[2011-09-08]
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(string tableColumnName, int? PERSONINCHARGEID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareExistCommand(tableColumnName, PERSONINCHARGEID, out strSql, out cmdParms);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
            return int.Parse(obj.ToString()) > 0;
        }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM C_PersonInCharge", null);
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// ��ȡ���������б�
        /// </summary>
        public List<Model.C_PersonInCharge> GetList()
        {
            StringBuilder strSql = new StringBuilder("SELECT * FROM C_PersonInCharge");
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<Model.C_PersonInCharge> lst = GetList(dr);
                return lst;
            }
        }

        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<Model.C_PersonInCharge> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();

            PageList<Model.C_PersonInCharge> pl = new PageList<Model.C_PersonInCharge>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM C_PersonInCharge", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }

        #region -------- ˽�з��� --------

        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        private Model.C_PersonInCharge GetModel(DbDataReader dr)
        {
            Model.C_PersonInCharge model = new Model.C_PersonInCharge();
            PrepareModel(model, dr);
            return model;
        }

        /// <summary>
        /// ��DbDataReader�õ����������б�
        /// </summary>
        private List<Model.C_PersonInCharge> GetList(DbDataReader dr)
        {
            List<Model.C_PersonInCharge> lst = new List<Model.C_PersonInCharge>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }

        /// <summary>
        /// ��DbDataReader�õ���ҳ���������б�
        /// </summary>
        private List<Model.C_PersonInCharge> GetPageList(DbDataReader dr, int first, int count)
        {
            List<Model.C_PersonInCharge> lst = new List<Model.C_PersonInCharge>();

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