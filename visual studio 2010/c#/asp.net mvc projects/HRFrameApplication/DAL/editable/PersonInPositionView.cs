/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.5.0.0 自动创建于 2012/7/2 11:20:22
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
    /// 数据访问类 PersonInPositionView
    /// </summary>
    public partial class PersonInPositionView : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.PersonInPositionView model)
        {
            StringBuilder sbSql4PersonInPositionView;
            DbParameter[] parms4PersonInPositionView;
            PrepareAddCommand(model, out sbSql4PersonInPositionView, out parms4PersonInPositionView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInPositionView.ToString(), parms4PersonInPositionView);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.PersonInPositionView model)
        {
            StringBuilder sbSql4PersonInPositionView;
            DbParameter[] parms4PersonInPositionView;
            PrepareUpdateCommand(model, out sbSql4PersonInPositionView, out parms4PersonInPositionView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInPositionView.ToString(), parms4PersonInPositionView);
        }
        
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? PERSONID)
        {
            StringBuilder sbSql4PersonInPositionView;
            DbParameter[] parms4PersonInPositionView;
            PrepareDeleteCommand(PERSONID, out sbSql4PersonInPositionView, out parms4PersonInPositionView);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4PersonInPositionView.ToString(), parms4PersonInPositionView);
        }
        
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.PersonInPositionView GetModel(int? PERSONID)
        {
            StringBuilder sbSql4PersonInPositionView;
            DbParameter[] parms4PersonInPositionView;
            PrepareGetModelCommand(PERSONID, out sbSql4PersonInPositionView, out parms4PersonInPositionView);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, sbSql4PersonInPositionView.ToString(), parms4PersonInPositionView))
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
            StringBuilder sbSql4PersonInPositionView;
            DbParameter[] parms4PersonInPositionView;
            PrepareExistCommand(PERSONID, out sbSql4PersonInPositionView, out parms4PersonInPositionView);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, sbSql4PersonInPositionView.ToString(), parms4PersonInPositionView);
            return int.Parse(obj.ToString()) > 0;
        }
        
        /// <summary>
        /// 获取数量
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM PersonInPositionView", null);
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表
        /// </summary>
        /// <param name="wheresql"> </param>
        public List<Model.PersonInPositionView> GetList(string wheresql)
        {
            StringBuilder sbSql4PersonInPositionView = new StringBuilder(string.Format("SELECT * FROM PersonInPositionView where {0}",wheresql));
            sbSql4PersonInPositionView.Append(string.Format("  and {0}={1}","是否主职","1"));
            sbSql4PersonInPositionView.Append(string.Format("  and {0}={1}","在职状态","'在职'"));
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, sbSql4PersonInPositionView.ToString(), null))
            {
                List<Model.PersonInPositionView> lst = GetList(dr);
                return lst;
            }
        }
        
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.PersonInPositionView> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();
            
            PageList<Model.PersonInPositionView> pl = new PageList<Model.PersonInPositionView>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM PersonInPositionView", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }
        
        #region -------- 私有方法 --------
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Model.PersonInPositionView GetModel(DbDataReader dr)
        {
            Model.PersonInPositionView model = new Model.PersonInPositionView();
            PrepareModel(model, dr);
            return model;
        }
        
        /// <summary>
        /// 由DbDataReader得到泛型数据列表
        /// </summary>
        private List<Model.PersonInPositionView> GetList(DbDataReader dr)
        {
            List<Model.PersonInPositionView> lst = new List<Model.PersonInPositionView>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }
      
        /// <summary>
        /// 由DbDataReader得到分页泛型数据列表
        /// </summary>
        private List<Model.PersonInPositionView> GetPageList(DbDataReader dr, int first, int count)
        {
            List<Model.PersonInPositionView> lst = new List<Model.PersonInPositionView>();
            
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