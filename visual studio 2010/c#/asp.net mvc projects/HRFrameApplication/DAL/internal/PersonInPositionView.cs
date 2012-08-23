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
    /// 数据访问类 PersonInPositionView ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class PersonInPositionView : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.PersonInPositionView model, out StringBuilder sbSql4PersonInPositionView, out DbParameter[] parms4PersonInPositionView)
        {
            sbSql4PersonInPositionView = new StringBuilder();
            sbSql4PersonInPositionView.Append("INSERT INTO PersonInPositionView(");
            sbSql4PersonInPositionView.Append("PERSONID, POSITIONID, OFFICEID, MECHANISMID, DEPARTMENTID, 姓名, 员工编号, 在职状态, 是否主职, 删除标识, 任职标识)");
            sbSql4PersonInPositionView.Append(" VALUES (");
            sbSql4PersonInPositionView.Append("@in_PERSONID, @in_POSITIONID, @in_OFFICEID, @in_MECHANISMID, @in_DEPARTMENTID, @in_姓名, @in_员工编号, @in_在职状态, @in_是否主职, @in_删除标识, @in_任职标识)");
    
            parms4PersonInPositionView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, model.POSITIONID),
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, model.OFFICEID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_姓名", DbType.String, model.姓名),
                dbHelper.CreateInDbParameter("@in_员工编号", DbType.String, model.员工编号),
                dbHelper.CreateInDbParameter("@in_在职状态", DbType.String, model.在职状态),
                dbHelper.CreateInDbParameter("@in_是否主职", DbType.Boolean, model.是否主职),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_任职标识", DbType.DateTime, model.任职标识)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.PersonInPositionView model, out StringBuilder sbSql4PersonInPositionView, out DbParameter[] parms4PersonInPositionView)
        {
            sbSql4PersonInPositionView = new StringBuilder();
            sbSql4PersonInPositionView.Append("UPDATE PersonInPositionView SET ");
            sbSql4PersonInPositionView.Append("POSITIONID=@in_POSITIONID,");
            sbSql4PersonInPositionView.Append("OFFICEID=@in_OFFICEID,");
            sbSql4PersonInPositionView.Append("MECHANISMID=@in_MECHANISMID,");
            sbSql4PersonInPositionView.Append("DEPARTMENTID=@in_DEPARTMENTID,");
            sbSql4PersonInPositionView.Append("姓名=@in_姓名,");
            sbSql4PersonInPositionView.Append("员工编号=@in_员工编号,");
            sbSql4PersonInPositionView.Append("在职状态=@in_在职状态,");
            sbSql4PersonInPositionView.Append("是否主职=@in_是否主职,");
            sbSql4PersonInPositionView.Append("删除标识=@in_删除标识,");
            sbSql4PersonInPositionView.Append("任职标识=@in_任职标识");
            sbSql4PersonInPositionView.Append(" WHERE PERSONID=@in_PERSONID");
    
            parms4PersonInPositionView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, model.POSITIONID),
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, model.OFFICEID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_姓名", DbType.String, model.姓名),
                dbHelper.CreateInDbParameter("@in_员工编号", DbType.String, model.员工编号),
                dbHelper.CreateInDbParameter("@in_在职状态", DbType.String, model.在职状态),
                dbHelper.CreateInDbParameter("@in_是否主职", DbType.Boolean, model.是否主职),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_任职标识", DbType.DateTime, model.任职标识),
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONID, out StringBuilder sbSql4PersonInPositionView, out DbParameter[] parms4PersonInPositionView)
        {
            sbSql4PersonInPositionView = new StringBuilder();
            sbSql4PersonInPositionView.Append("DELETE FROM PersonInPositionView");
            sbSql4PersonInPositionView.Append(" WHERE PERSONID=@in_PERSONID");
      
            parms4PersonInPositionView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONID, out StringBuilder sbSql4PersonInPositionView, out DbParameter[] parms4PersonInPositionView)
        {
            sbSql4PersonInPositionView = new StringBuilder();
            sbSql4PersonInPositionView.Append("SELECT COUNT(1) FROM PersonInPositionView");
            sbSql4PersonInPositionView.Append(" WHERE PERSONID=@in_PERSONID");
          
            parms4PersonInPositionView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? PERSONID, out StringBuilder sbSql4PersonInPositionView, out DbParameter[] parms4PersonInPositionView)
        {
            sbSql4PersonInPositionView = new StringBuilder();
            sbSql4PersonInPositionView.Append("SELECT * FROM PersonInPositionView");
            sbSql4PersonInPositionView.Append(" WHERE PERSONID=@in_PERSONID");
          
            parms4PersonInPositionView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.PersonInPositionView model, DbDataReader dr)
        {
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.POSITIONID = GetInt(dr["POSITIONID"]);
            model.OFFICEID = GetInt(dr["OFFICEID"]);
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.DEPARTMENTID = GetInt(dr["DEPARTMENTID"]);
            model.姓名 = GetString(dr["姓名"]);
            model.员工编号 = GetString(dr["员工编号"]);
            model.在职状态 = GetString(dr["在职状态"]);
            model.是否主职 = GetBool(dr["是否主职"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.任职标识 = GetDateTime(dr["任职标识"]);
        }
    }
}