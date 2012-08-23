/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/23 8:38:39
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
    /// 数据访问类 C_Transfer ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_Transfer : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Transfer model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Transfer(");
            strSql.Append("删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 员工ID, 原职位, 现职位, 调动原因)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_员工ID, @in_原职位, @in_现职位, @in_调动原因)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Int32, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_员工ID", DbType.Int32, model.员工ID),
                dbHelper.CreateInDbParameter("@in_原职位", DbType.Int32, model.原职位),
                dbHelper.CreateInDbParameter("@in_现职位", DbType.Int32, model.现职位),
                dbHelper.CreateInDbParameter("@in_调动原因", DbType.String, model.调动原因)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Transfer model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Transfer SET ");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("员工ID=@in_员工ID,");
            strSql.Append("原职位=@in_原职位,");
            strSql.Append("现职位=@in_现职位,");
            strSql.Append("调动原因=@in_调动原因");
            strSql.Append(" WHERE TRANSFERID=@in_TRANSFERID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Int32, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_员工ID", DbType.Int32, model.员工ID),
                dbHelper.CreateInDbParameter("@in_原职位", DbType.Int32, model.原职位),
                dbHelper.CreateInDbParameter("@in_现职位", DbType.Int32, model.现职位),
                dbHelper.CreateInDbParameter("@in_调动原因", DbType.String, model.调动原因),
                dbHelper.CreateInDbParameter("@in_TRANSFERID", DbType.Int32, model.TRANSFERID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? TRANSFERID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Transfer");
            strSql.Append(" WHERE TRANSFERID=@in_TRANSFERID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_TRANSFERID", DbType.Int32, TRANSFERID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? TRANSFERID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Transfer");
            strSql.Append(" WHERE TRANSFERID=@in_TRANSFERID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_TRANSFERID", DbType.Int32, TRANSFERID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? TRANSFERID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Transfer");
            strSql.Append(" WHERE TRANSFERID=@in_TRANSFERID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_TRANSFERID", DbType.Int32, TRANSFERID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_Transfer model, DbDataReader dr)
        {
            model.TRANSFERID = GetInt(dr["TRANSFERID"]);
            model.删除标识 = GetInt(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.员工ID = GetInt(dr["员工ID"]);
            model.原职位 = GetInt(dr["原职位"]);
            model.现职位 = GetInt(dr["现职位"]);
            model.调动原因 = GetString(dr["调动原因"]);
        }
    }
}