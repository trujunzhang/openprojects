/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/26 10:36:50
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
    /// 数据访问类 C_Position ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_Position : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Position model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Position(");
            strSql.Append("DEPARTMENTID, 删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 职位名称, 是否部门管理职位, 编制人数, 职位描述, 工作职责, 任职要求, 排序时间)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_DEPARTMENTID, @in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_职位名称, @in_是否部门管理职位, @in_编制人数, @in_职位描述, @in_工作职责, @in_任职要求, @in_排序时间)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_职位名称", DbType.String, model.职位名称),
                dbHelper.CreateInDbParameter("@in_是否部门管理职位", DbType.Boolean, model.是否部门管理职位),
                dbHelper.CreateInDbParameter("@in_编制人数", DbType.Int32, model.编制人数),
                dbHelper.CreateInDbParameter("@in_职位描述", DbType.String, model.职位描述),
                dbHelper.CreateInDbParameter("@in_工作职责", DbType.String, model.工作职责),
                dbHelper.CreateInDbParameter("@in_任职要求", DbType.String, model.任职要求),
                dbHelper.CreateInDbParameter("@in_排序时间", DbType.DateTime, model.排序时间)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Position model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Position SET ");
            strSql.Append("DEPARTMENTID=@in_DEPARTMENTID,");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("职位名称=@in_职位名称,");
            strSql.Append("是否部门管理职位=@in_是否部门管理职位,");
            strSql.Append("编制人数=@in_编制人数,");
            strSql.Append("职位描述=@in_职位描述,");
            strSql.Append("工作职责=@in_工作职责,");
            strSql.Append("任职要求=@in_任职要求,");
            strSql.Append("排序时间=@in_排序时间");
            strSql.Append(" WHERE POSITIONID=@in_POSITIONID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_职位名称", DbType.String, model.职位名称),
                dbHelper.CreateInDbParameter("@in_是否部门管理职位", DbType.Boolean, model.是否部门管理职位),
                dbHelper.CreateInDbParameter("@in_编制人数", DbType.Int32, model.编制人数),
                dbHelper.CreateInDbParameter("@in_职位描述", DbType.String, model.职位描述),
                dbHelper.CreateInDbParameter("@in_工作职责", DbType.String, model.工作职责),
                dbHelper.CreateInDbParameter("@in_任职要求", DbType.String, model.任职要求),
                dbHelper.CreateInDbParameter("@in_排序时间", DbType.DateTime, model.排序时间),
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, model.POSITIONID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? POSITIONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Position");
            strSql.Append(" WHERE POSITIONID=@in_POSITIONID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, POSITIONID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? POSITIONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Position");
            strSql.Append(" WHERE POSITIONID=@in_POSITIONID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, POSITIONID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? POSITIONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Position");
            strSql.Append(" WHERE POSITIONID=@in_POSITIONID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, POSITIONID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_Position model, DbDataReader dr)
        {
            model.POSITIONID = GetInt(dr["POSITIONID"]);
            model.DEPARTMENTID = GetInt(dr["DEPARTMENTID"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.职位名称 = GetString(dr["职位名称"]);
            model.是否部门管理职位 = GetBool(dr["是否部门管理职位"]);
            model.编制人数 = GetInt(dr["编制人数"]);
            model.职位描述 = GetString(dr["职位描述"]);
            model.工作职责 = GetString(dr["工作职责"]);
            model.任职要求 = GetString(dr["任职要求"]);
            model.排序时间 = GetDateTime(dr["排序时间"]);
        }
    }
}