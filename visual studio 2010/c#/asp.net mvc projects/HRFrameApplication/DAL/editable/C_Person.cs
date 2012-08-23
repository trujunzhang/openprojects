/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/6 9:56:57
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DAL
{
    /// <summary>
    /// 数据访问类 C_Person
    /// </summary>
    public partial class C_Person : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.C_Person model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareAddCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.C_Person model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareUpdateCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? PERSONID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareDeleteCommand(PERSONID, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Person GetModel(string tableColumnName, int? PERSONID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareGetModelCommand(tableColumnName, PERSONID, out strSql, out cmdParms);
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
        /// TODO [Custom]{2011-09-16}
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Person GetModel(string tableColumnName, string PERSONID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareGetModelCommand(tableColumnName, PERSONID, out strSql, out cmdParms);
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? PERSONID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareExistCommand(PERSONID, out strSql, out cmdParms);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
            return int.Parse(obj.ToString()) > 0;
        }
        
        /// <summary>
        /// 获取数量
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM C_Person", null);
            return int.Parse(obj.ToString());
        }
        
        /// <summary>
        /// 获取泛型数据列表
        /// </summary>
        public List<Model.C_Person> GetList()
        {
            StringBuilder strSql = new StringBuilder("SELECT * FROM C_Person");
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<Model.C_Person> lst = GetList(dr);
                return lst;
            }
        }
        
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_Person> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();
            
            PageList<Model.C_Person> pl = new PageList<Model.C_Person>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM C_Person", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }

        #region -------- 私有方法 --------
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Model.C_Person GetModel(DbDataReader dr)
        {
            Model.C_Person model = new Model.C_Person();
            PrepareModel(model, dr);
            return model;
        }
        
        /// <summary>
        /// 由DbDataReader得到泛型数据列表
        /// </summary>
        private List<Model.C_Person> GetList(DbDataReader dr)
        {
            List<Model.C_Person> lst = new List<Model.C_Person>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }
      
        /// <summary>
        /// 由DbDataReader得到分页泛型数据列表
        /// </summary>
        private List<Model.C_Person> GetPageList(DbDataReader dr, int first, int count)
        {
            List<Model.C_Person> lst = new List<Model.C_Person>();
            
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