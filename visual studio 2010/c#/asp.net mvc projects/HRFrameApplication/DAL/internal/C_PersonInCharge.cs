/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/7 9:53:22
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
    /// 数据访问类 C_PersonInCharge ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_PersonInCharge : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_PersonInCharge model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_PersonInCharge(");
            strSql.Append("PERSONID, MECHANISMID, 删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 排序位置)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_PERSONID, @in_MECHANISMID, @in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_排序位置)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_排序位置", DbType.Int32, model.排序位置)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_PersonInCharge model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_PersonInCharge SET ");
            strSql.Append("PERSONID=@in_PERSONID,");
            strSql.Append("MECHANISMID=@in_MECHANISMID,");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("排序位置=@in_排序位置");
            strSql.Append(" WHERE PERSONINCHARGEID=@in_PERSONINCHARGEID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_排序位置", DbType.Int32, model.排序位置),
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, model.PERSONINCHARGEID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONINCHARGEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_PersonInCharge");
            strSql.Append(" WHERE PERSONINCHARGEID=@in_PERSONINCHARGEID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, PERSONINCHARGEID)};
        }
        
        /// <summary>
        /// TODO [Custom]{change}[2011-09-08]
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(string tableColumnName, int? PERSONINCHARGEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_PersonInCharge");
            strSql.Append(string.Format(" WHERE {0}=@in_PERSONINCHARGEID", tableColumnName));
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, PERSONINCHARGEID)};
        }
        
        /// <summary>
        /// TODO [Custom][2011-09-08]
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(string tableColumnName, int? PERSONINCHARGEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_PersonInCharge");
            strSql.Append(string.Format(" WHERE {0}=@in_PERSONINCHARGEID", tableColumnName));
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, PERSONINCHARGEID)};
        }
                    /// <summary>
        /// TODO [Custom][2011-09-08]
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand( int? PERSONINCHARGEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_PersonInCharge");
            strSql.Append(string.Format(" WHERE {0}=@in_PERSONINCHARGEID", "PERSONINCHARGEID"));

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, PERSONINCHARGEID)};
        }
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_PersonInCharge model, DbDataReader dr)
        {
            model.PERSONINCHARGEID = GetInt(dr["PERSONINCHARGEID"]);
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.排序位置 = GetInt(dr["排序位置"]);
        }
    }
}