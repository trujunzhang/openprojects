/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/26 9:27:33
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
    /// 数据访问类 C_Contract ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_Contract : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Contract model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Contract(");
            strSql.Append("删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 证件号码, 合同编号, 合同名称, 合同类型, 合同状态, 合同期限, 开始时间, 截至时间, 合同内容, 合同附件)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_证件号码, @in_合同编号, @in_合同名称, @in_合同类型, @in_合同状态, @in_合同期限, @in_开始时间, @in_截至时间, @in_合同内容, @in_合同附件)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_证件号码", DbType.String, model.证件号码),
                dbHelper.CreateInDbParameter("@in_合同编号", DbType.String, model.合同编号),
                dbHelper.CreateInDbParameter("@in_合同名称", DbType.String, model.合同名称),
                dbHelper.CreateInDbParameter("@in_合同类型", DbType.String, model.合同类型),
                dbHelper.CreateInDbParameter("@in_合同状态", DbType.String, model.合同状态),
                dbHelper.CreateInDbParameter("@in_合同期限", DbType.String, model.合同期限),
                dbHelper.CreateInDbParameter("@in_开始时间", DbType.DateTime, model.开始时间),
                dbHelper.CreateInDbParameter("@in_截至时间", DbType.DateTime, model.截至时间),
                dbHelper.CreateInDbParameter("@in_合同内容", DbType.String, model.合同内容),
                dbHelper.CreateInDbParameter("@in_合同附件", DbType.String, model.合同附件)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Contract model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Contract SET ");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("证件号码=@in_证件号码,");
            strSql.Append("合同编号=@in_合同编号,");
            strSql.Append("合同名称=@in_合同名称,");
            strSql.Append("合同类型=@in_合同类型,");
            strSql.Append("合同状态=@in_合同状态,");
            strSql.Append("合同期限=@in_合同期限,");
            strSql.Append("开始时间=@in_开始时间,");
            strSql.Append("截至时间=@in_截至时间,");
            strSql.Append("合同内容=@in_合同内容,");
            strSql.Append("合同附件=@in_合同附件");
            strSql.Append(" WHERE CONTRACTID=@in_CONTRACTID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_证件号码", DbType.String, model.证件号码),
                dbHelper.CreateInDbParameter("@in_合同编号", DbType.String, model.合同编号),
                dbHelper.CreateInDbParameter("@in_合同名称", DbType.String, model.合同名称),
                dbHelper.CreateInDbParameter("@in_合同类型", DbType.String, model.合同类型),
                dbHelper.CreateInDbParameter("@in_合同状态", DbType.String, model.合同状态),
                dbHelper.CreateInDbParameter("@in_合同期限", DbType.String, model.合同期限),
                dbHelper.CreateInDbParameter("@in_开始时间", DbType.DateTime, model.开始时间),
                dbHelper.CreateInDbParameter("@in_截至时间", DbType.DateTime, model.截至时间),
                dbHelper.CreateInDbParameter("@in_合同内容", DbType.String, model.合同内容),
                dbHelper.CreateInDbParameter("@in_合同附件", DbType.String, model.合同附件),
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, model.CONTRACTID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? CONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Contract");
            strSql.Append(" WHERE CONTRACTID=@in_CONTRACTID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, CONTRACTID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? CONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Contract");
            strSql.Append(" WHERE CONTRACTID=@in_CONTRACTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, CONTRACTID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? CONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Contract");
            strSql.Append(" WHERE CONTRACTID=@in_CONTRACTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, CONTRACTID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_Contract model, DbDataReader dr)
        {
            model.CONTRACTID = GetInt(dr["CONTRACTID"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.证件号码 = GetString(dr["证件号码"]);
            model.合同编号 = GetString(dr["合同编号"]);
            model.合同名称 = GetString(dr["合同名称"]);
            model.合同类型 = GetString(dr["合同类型"]);
            model.合同状态 = GetString(dr["合同状态"]);
            model.合同期限 = GetString(dr["合同期限"]);
            model.开始时间 = GetDateTime(dr["开始时间"]);
            model.截至时间 = GetDateTime(dr["截至时间"]);
            model.合同内容 = GetString(dr["合同内容"]);
            model.合同附件 = GetString(dr["合同附件"]);
        }
    }
}