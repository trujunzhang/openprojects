/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.5.0.0 自动创建于 2012/6/22 9:14:52
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
    /// 数据访问类 PersonInChargeView ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class PersonInChargeView : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.PersonInChargeView model, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("INSERT INTO PersonInChargeView(");
            sbSql4PersonInChargeView.Append("PERSONID, MECHANISMID, PERSONINCHARGEID, 机构名称, 机构简称, 姓名, 员工编号, 删除标识, 排序位置)");
            sbSql4PersonInChargeView.Append(" VALUES (");
            sbSql4PersonInChargeView.Append("@in_PERSONID, @in_MECHANISMID, @in_PERSONINCHARGEID, @in_机构名称, @in_机构简称, @in_姓名, @in_员工编号, @in_删除标识, @in_排序位置)");
    
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, model.PERSONINCHARGEID),
                dbHelper.CreateInDbParameter("@in_机构名称", DbType.String, model.机构名称),
                dbHelper.CreateInDbParameter("@in_机构简称", DbType.String, model.机构简称),
                dbHelper.CreateInDbParameter("@in_姓名", DbType.String, model.姓名),
                dbHelper.CreateInDbParameter("@in_员工编号", DbType.String, model.员工编号),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_排序位置", DbType.Int32, model.排序位置)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.PersonInChargeView model, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("UPDATE PersonInChargeView SET ");
            sbSql4PersonInChargeView.Append("MECHANISMID=@in_MECHANISMID,");
            sbSql4PersonInChargeView.Append("PERSONINCHARGEID=@in_PERSONINCHARGEID,");
            sbSql4PersonInChargeView.Append("机构名称=@in_机构名称,");
            sbSql4PersonInChargeView.Append("机构简称=@in_机构简称,");
            sbSql4PersonInChargeView.Append("姓名=@in_姓名,");
            sbSql4PersonInChargeView.Append("员工编号=@in_员工编号,");
            sbSql4PersonInChargeView.Append("删除标识=@in_删除标识,");
            sbSql4PersonInChargeView.Append("排序位置=@in_排序位置");
            sbSql4PersonInChargeView.Append(" WHERE PERSONID=@in_PERSONID");
    
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, model.PERSONINCHARGEID),
                dbHelper.CreateInDbParameter("@in_机构名称", DbType.String, model.机构名称),
                dbHelper.CreateInDbParameter("@in_机构简称", DbType.String, model.机构简称),
                dbHelper.CreateInDbParameter("@in_姓名", DbType.String, model.姓名),
                dbHelper.CreateInDbParameter("@in_员工编号", DbType.String, model.员工编号),
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_排序位置", DbType.Int32, model.排序位置),
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONID, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("DELETE FROM PersonInChargeView");
            sbSql4PersonInChargeView.Append(" WHERE PERSONID=@in_PERSONID");
      
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONID, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("SELECT COUNT(1) FROM PersonInChargeView");
            sbSql4PersonInChargeView.Append(" WHERE PERSONID=@in_PERSONID");
          
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? PERSONID, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("SELECT * FROM PersonInChargeView");
            sbSql4PersonInChargeView.Append(" WHERE PERSONID=@in_PERSONID");
          
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.PersonInChargeView model, DbDataReader dr)
        {
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.PERSONINCHARGEID = GetInt(dr["PERSONINCHARGEID"]);
            model.机构名称 = GetString(dr["机构名称"]);
            model.机构简称 = GetString(dr["机构简称"]);
            model.姓名 = GetString(dr["姓名"]);
            model.员工编号 = GetString(dr["员工编号"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.排序位置 = GetInt(dr["排序位置"]);
        }
    }
}