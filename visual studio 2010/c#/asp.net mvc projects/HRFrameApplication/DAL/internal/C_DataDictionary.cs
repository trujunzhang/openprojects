/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/30 15:07:38
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
    /// 数据访问类 C_DataDictionary ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_DataDictionary : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_DataDictionary model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_DataDictionary(");
            strSql.Append("删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 主菜单编号, 子菜单编号, 字典类型, 字典内容)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_主菜单编号, @in_子菜单编号, @in_字典类型, @in_字典内容)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_主菜单编号", DbType.String, model.主菜单编号),
                dbHelper.CreateInDbParameter("@in_子菜单编号", DbType.String, model.子菜单编号),
                dbHelper.CreateInDbParameter("@in_字典类型", DbType.String, model.字典类型),
                dbHelper.CreateInDbParameter("@in_字典内容", DbType.Binary, model.字典内容)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_DataDictionary model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_DataDictionary SET ");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("主菜单编号=@in_主菜单编号,");
            strSql.Append("子菜单编号=@in_子菜单编号,");
            strSql.Append("字典类型=@in_字典类型,");
            strSql.Append("字典内容=@in_字典内容");
            strSql.Append(" WHERE DATADICTIONARY_ID=@in_DATADICTIONARY_ID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_主菜单编号", DbType.String, model.主菜单编号),
                dbHelper.CreateInDbParameter("@in_子菜单编号", DbType.String, model.子菜单编号),
                dbHelper.CreateInDbParameter("@in_字典类型", DbType.String, model.字典类型),
                dbHelper.CreateInDbParameter("@in_字典内容", DbType.Binary, model.字典内容),
                dbHelper.CreateInDbParameter("@in_DATADICTIONARY_ID", DbType.Int32, model.DATADICTIONARY_ID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? DATADICTIONARY_ID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_DataDictionary");
            strSql.Append(" WHERE DATADICTIONARY_ID=@in_DATADICTIONARY_ID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DATADICTIONARY_ID", DbType.Int32, DATADICTIONARY_ID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? DATADICTIONARY_ID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_DataDictionary");
            strSql.Append(" WHERE DATADICTIONARY_ID=@in_DATADICTIONARY_ID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DATADICTIONARY_ID", DbType.Int32, DATADICTIONARY_ID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? DATADICTIONARY_ID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_DataDictionary");
            strSql.Append(" WHERE DATADICTIONARY_ID=@in_DATADICTIONARY_ID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DATADICTIONARY_ID", DbType.Int32, DATADICTIONARY_ID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_DataDictionary model, DbDataReader dr)
        {
            model.DATADICTIONARY_ID = GetInt(dr["DATADICTIONARY_ID"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.主菜单编号 = GetString(dr["主菜单编号"]);
            model.子菜单编号 = GetString(dr["子菜单编号"]);
            model.字典类型 = GetString(dr["字典类型"]);
            model.字典内容 = GetBinary(dr["字典内容"]);
        }
    }
}