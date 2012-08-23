/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/2 10:11:37
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
    /// 数据访问类 C_PersonnelDocumentsClass ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_PersonnelDocumentsClass : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_PersonnelDocumentsClass model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_PersonnelDocumentsClass(");
            strSql.Append("删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 所属类别, 类别名称, 权限设置)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_所属类别, @in_类别名称, @in_权限设置)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_所属类别", DbType.String, model.所属类别),
                dbHelper.CreateInDbParameter("@in_类别名称", DbType.String, model.类别名称),
                dbHelper.CreateInDbParameter("@in_权限设置", DbType.String, model.权限设置)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_PersonnelDocumentsClass model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_PersonnelDocumentsClass SET ");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("所属类别=@in_所属类别,");
            strSql.Append("类别名称=@in_类别名称,");
            strSql.Append("权限设置=@in_权限设置");
            strSql.Append(" WHERE PERSONNELDOCUMENTSCLASSID=@in_PERSONNELDOCUMENTSCLASSID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_所属类别", DbType.String, model.所属类别),
                dbHelper.CreateInDbParameter("@in_类别名称", DbType.String, model.类别名称),
                dbHelper.CreateInDbParameter("@in_权限设置", DbType.String, model.权限设置),
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSCLASSID", DbType.Int32, model.PERSONNELDOCUMENTSCLASSID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONNELDOCUMENTSCLASSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_PersonnelDocumentsClass");
            strSql.Append(" WHERE PERSONNELDOCUMENTSCLASSID=@in_PERSONNELDOCUMENTSCLASSID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSCLASSID", DbType.Int32, PERSONNELDOCUMENTSCLASSID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONNELDOCUMENTSCLASSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_PersonnelDocumentsClass");
            strSql.Append(" WHERE PERSONNELDOCUMENTSCLASSID=@in_PERSONNELDOCUMENTSCLASSID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSCLASSID", DbType.Int32, PERSONNELDOCUMENTSCLASSID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? PERSONNELDOCUMENTSCLASSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_PersonnelDocumentsClass");
            strSql.Append(" WHERE PERSONNELDOCUMENTSCLASSID=@in_PERSONNELDOCUMENTSCLASSID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSCLASSID", DbType.Int32, PERSONNELDOCUMENTSCLASSID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_PersonnelDocumentsClass model, DbDataReader dr)
        {
            model.PERSONNELDOCUMENTSCLASSID = GetInt(dr["PERSONNELDOCUMENTSCLASSID"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.所属类别 = GetString(dr["所属类别"]);
            model.类别名称 = GetString(dr["类别名称"]);
            model.权限设置 = GetString(dr["权限设置"]);
        }
    }
}