/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/19 14:22:22
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
    /// 数据访问类 C_Department ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_Department : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Department model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Department(");
            strSql.Append("C_D_DEPARTMENTID, MECHANISMID, 删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 部门简称, 部门名称, 电话, 邮政编码, 网址, 传真, 地址)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_C_D_DEPARTMENTID, @in_MECHANISMID, @in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_部门简称, @in_部门名称, @in_电话, @in_邮政编码, @in_网址, @in_传真, @in_地址)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_C_D_DEPARTMENTID", DbType.Int32, model.C_D_DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_部门简称", DbType.String, model.部门简称),
                dbHelper.CreateInDbParameter("@in_部门名称", DbType.String, model.部门名称),
                dbHelper.CreateInDbParameter("@in_电话", DbType.String, model.电话),
                dbHelper.CreateInDbParameter("@in_邮政编码", DbType.String, model.邮政编码),
                dbHelper.CreateInDbParameter("@in_网址", DbType.String, model.网址),
                dbHelper.CreateInDbParameter("@in_传真", DbType.String, model.传真),
                dbHelper.CreateInDbParameter("@in_地址", DbType.String, model.地址)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Department model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Department SET ");
            strSql.Append("C_D_DEPARTMENTID=@in_C_D_DEPARTMENTID,");
            strSql.Append("MECHANISMID=@in_MECHANISMID,");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("部门简称=@in_部门简称,");
            strSql.Append("部门名称=@in_部门名称,");
            strSql.Append("电话=@in_电话,");
            strSql.Append("邮政编码=@in_邮政编码,");
            strSql.Append("网址=@in_网址,");
            strSql.Append("传真=@in_传真,");
            strSql.Append("地址=@in_地址");
            strSql.Append(" WHERE DEPARTMENTID=@in_DEPARTMENTID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_C_D_DEPARTMENTID", DbType.Int32, model.C_D_DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_部门简称", DbType.String, model.部门简称),
                dbHelper.CreateInDbParameter("@in_部门名称", DbType.String, model.部门名称),
                dbHelper.CreateInDbParameter("@in_电话", DbType.String, model.电话),
                dbHelper.CreateInDbParameter("@in_邮政编码", DbType.String, model.邮政编码),
                dbHelper.CreateInDbParameter("@in_网址", DbType.String, model.网址),
                dbHelper.CreateInDbParameter("@in_传真", DbType.String, model.传真),
                dbHelper.CreateInDbParameter("@in_地址", DbType.String, model.地址),
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? DEPARTMENTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Department");
            strSql.Append(" WHERE DEPARTMENTID=@in_DEPARTMENTID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, DEPARTMENTID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? DEPARTMENTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Department");
            strSql.Append(" WHERE DEPARTMENTID=@in_DEPARTMENTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, DEPARTMENTID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? DEPARTMENTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Department");
            strSql.Append(" WHERE DEPARTMENTID=@in_DEPARTMENTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, DEPARTMENTID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_Department model, DbDataReader dr)
        {
            model.DEPARTMENTID = GetInt(dr["DEPARTMENTID"]);
            model.C_D_DEPARTMENTID = GetInt(dr["C_D_DEPARTMENTID"]);
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.部门简称 = GetString(dr["部门简称"]);
            model.部门名称 = GetString(dr["部门名称"]);
            model.电话 = GetString(dr["电话"]);
            model.邮政编码 = GetString(dr["邮政编码"]);
            model.网址 = GetString(dr["网址"]);
            model.传真 = GetString(dr["传真"]);
            model.地址 = GetString(dr["地址"]);
        }
    }
}