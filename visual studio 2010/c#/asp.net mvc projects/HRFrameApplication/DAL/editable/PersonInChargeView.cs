/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.5.0.0 自动创建于 2012/6/22 9:14:52
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
    /// 数据访问类 PersonInChargeView
    /// </summary>
    public partial class PersonInChargeView : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.PersonInChargeView model)
        {
            StringBuilder sbSql4PersonInChargeView;
            DbParameter[] parms4PersonInChargeView;
            PrepareAddCommand(model, out sbSql4PersonInChargeView, out parms4PersonInChargeView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInChargeView.ToString(), parms4PersonInChargeView);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.PersonInChargeView model)
        {
            StringBuilder sbSql4PersonInChargeView;
            DbParameter[] parms4PersonInChargeView;
            PrepareUpdateCommand(model, out sbSql4PersonInChargeView, out parms4PersonInChargeView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInChargeView.ToString(), parms4PersonInChargeView);
        }
        
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? PERSONID)
        {
            StringBuilder sbSql4PersonInChargeView;
            DbParameter[] parms4PersonInChargeView;
            PrepareDeleteCommand(PERSONID, out sbSql4PersonInChargeView, out parms4PersonInChargeView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInChargeView.ToString(), parms4PersonInChargeView);
        }
        
        /// <summary>
        /// 得到一个对象实体
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
        /// 是否存在该记录
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
        /// 获取数量
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM PersonInChargeView", null);
            return int.Parse(obj.ToString());
        }
        
        /// <summary>
        /// 获取泛型数据列表
        /// </summary>
        public List<Model.PersonInChargeView> GetList(string wheresql)
        {
            wheresql = "1=1";
            StringBuilder sbSql4PersonInChargeView = new StringBuilder(string.Format("SELECT * FROM PersonInChargeView where {0}",wheresql));
            sbSql4PersonInChargeView.Append(string.Format(" and {0}={1}", " 删除标识", "0"));
            //sbSql4PersonInChargeView.Append(string.Format(" and {0}={1}", "PERSONID", "11"));

            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, sbSql4PersonInChargeView.ToString(), null))
            {
                List<Model.PersonInChargeView> lst = GetList(dr);
                return lst;
            }
        }
        
        /// <summary>
        /// 分页获取泛型数据列表
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
        
        #region -------- 私有方法 --------
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Model.PersonInChargeView GetModel(DbDataReader dr)
        {
            Model.PersonInChargeView model = new Model.PersonInChargeView();
            PrepareModel(model, dr);
            return model;
        }
        
        /// <summary>
        /// 由DbDataReader得到泛型数据列表
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
        /// 由DbDataReader得到分页泛型数据列表
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