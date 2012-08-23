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
    /// 数据访问类 C_PersonnelDocuments ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_PersonnelDocuments : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_PersonnelDocuments model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_PersonnelDocuments(");
            strSql.Append("删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 类别, 主标题, 副标题, 关键字, 资料简介, 附件)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_类别, @in_主标题, @in_副标题, @in_关键字, @in_资料简介, @in_附件)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_类别", DbType.String, model.类别),
                dbHelper.CreateInDbParameter("@in_主标题", DbType.String, model.主标题),
                dbHelper.CreateInDbParameter("@in_副标题", DbType.String, model.副标题),
                dbHelper.CreateInDbParameter("@in_关键字", DbType.String, model.关键字),
                dbHelper.CreateInDbParameter("@in_资料简介", DbType.String, model.资料简介),
                dbHelper.CreateInDbParameter("@in_附件", DbType.String, model.附件)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_PersonnelDocuments model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_PersonnelDocuments SET ");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("类别=@in_类别,");
            strSql.Append("主标题=@in_主标题,");
            strSql.Append("副标题=@in_副标题,");
            strSql.Append("关键字=@in_关键字,");
            strSql.Append("资料简介=@in_资料简介,");
            strSql.Append("附件=@in_附件");
            strSql.Append(" WHERE PERSONNELDOCUMENTSID=@in_PERSONNELDOCUMENTSID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_类别", DbType.String, model.类别),
                dbHelper.CreateInDbParameter("@in_主标题", DbType.String, model.主标题),
                dbHelper.CreateInDbParameter("@in_副标题", DbType.String, model.副标题),
                dbHelper.CreateInDbParameter("@in_关键字", DbType.String, model.关键字),
                dbHelper.CreateInDbParameter("@in_资料简介", DbType.String, model.资料简介),
                dbHelper.CreateInDbParameter("@in_附件", DbType.String, model.附件),
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSID", DbType.Int32, model.PERSONNELDOCUMENTSID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONNELDOCUMENTSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_PersonnelDocuments");
            strSql.Append(" WHERE PERSONNELDOCUMENTSID=@in_PERSONNELDOCUMENTSID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSID", DbType.Int32, PERSONNELDOCUMENTSID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONNELDOCUMENTSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_PersonnelDocuments");
            strSql.Append(" WHERE PERSONNELDOCUMENTSID=@in_PERSONNELDOCUMENTSID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSID", DbType.Int32, PERSONNELDOCUMENTSID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? PERSONNELDOCUMENTSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_PersonnelDocuments");
            strSql.Append(" WHERE PERSONNELDOCUMENTSID=@in_PERSONNELDOCUMENTSID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSID", DbType.Int32, PERSONNELDOCUMENTSID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_PersonnelDocuments model, DbDataReader dr)
        {
            model.PERSONNELDOCUMENTSID = GetInt(dr["PERSONNELDOCUMENTSID"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.类别 = GetString(dr["类别"]);
            model.主标题 = GetString(dr["主标题"]);
            model.副标题 = GetString(dr["副标题"]);
            model.关键字 = GetString(dr["关键字"]);
            model.资料简介 = GetString(dr["资料简介"]);
            model.附件 = GetString(dr["附件"]);
        }
    }
}