/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.5.0.0 �Զ������� 2012/7/2 11:20:22
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DAL
{
    /// <summary>
    /// ���ݷ����� PersonInPositionView ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class PersonInPositionView : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.PersonInPositionView model, out StringBuilder sbSql4PersonInPositionView, out DbParameter[] parms4PersonInPositionView)
        {
            sbSql4PersonInPositionView = new StringBuilder();
            sbSql4PersonInPositionView.Append("INSERT INTO PersonInPositionView(");
            sbSql4PersonInPositionView.Append("PERSONID, POSITIONID, OFFICEID, MECHANISMID, DEPARTMENTID, ����, Ա�����, ��ְ״̬, �Ƿ���ְ, ɾ����ʶ, ��ְ��ʶ)");
            sbSql4PersonInPositionView.Append(" VALUES (");
            sbSql4PersonInPositionView.Append("@in_PERSONID, @in_POSITIONID, @in_OFFICEID, @in_MECHANISMID, @in_DEPARTMENTID, @in_����, @in_Ա�����, @in_��ְ״̬, @in_�Ƿ���ְ, @in_ɾ����ʶ, @in_��ְ��ʶ)");
    
            parms4PersonInPositionView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, model.POSITIONID),
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, model.OFFICEID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_Ա�����", DbType.String, model.Ա�����),
                dbHelper.CreateInDbParameter("@in_��ְ״̬", DbType.String, model.��ְ״̬),
                dbHelper.CreateInDbParameter("@in_�Ƿ���ְ", DbType.Boolean, model.�Ƿ���ְ),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_��ְ��ʶ", DbType.DateTime, model.��ְ��ʶ)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.PersonInPositionView model, out StringBuilder sbSql4PersonInPositionView, out DbParameter[] parms4PersonInPositionView)
        {
            sbSql4PersonInPositionView = new StringBuilder();
            sbSql4PersonInPositionView.Append("UPDATE PersonInPositionView SET ");
            sbSql4PersonInPositionView.Append("POSITIONID=@in_POSITIONID,");
            sbSql4PersonInPositionView.Append("OFFICEID=@in_OFFICEID,");
            sbSql4PersonInPositionView.Append("MECHANISMID=@in_MECHANISMID,");
            sbSql4PersonInPositionView.Append("DEPARTMENTID=@in_DEPARTMENTID,");
            sbSql4PersonInPositionView.Append("����=@in_����,");
            sbSql4PersonInPositionView.Append("Ա�����=@in_Ա�����,");
            sbSql4PersonInPositionView.Append("��ְ״̬=@in_��ְ״̬,");
            sbSql4PersonInPositionView.Append("�Ƿ���ְ=@in_�Ƿ���ְ,");
            sbSql4PersonInPositionView.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            sbSql4PersonInPositionView.Append("��ְ��ʶ=@in_��ְ��ʶ");
            sbSql4PersonInPositionView.Append(" WHERE PERSONID=@in_PERSONID");
    
            parms4PersonInPositionView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, model.POSITIONID),
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, model.OFFICEID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_Ա�����", DbType.String, model.Ա�����),
                dbHelper.CreateInDbParameter("@in_��ְ״̬", DbType.String, model.��ְ״̬),
                dbHelper.CreateInDbParameter("@in_�Ƿ���ְ", DbType.Boolean, model.�Ƿ���ְ),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_��ְ��ʶ", DbType.DateTime, model.��ְ��ʶ),
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
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
        /// Ϊ��ѯ�Ƿ����һ������׼������
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
        /// Ϊ��ȡһ������׼������
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
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.PersonInPositionView model, DbDataReader dr)
        {
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.POSITIONID = GetInt(dr["POSITIONID"]);
            model.OFFICEID = GetInt(dr["OFFICEID"]);
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.DEPARTMENTID = GetInt(dr["DEPARTMENTID"]);
            model.���� = GetString(dr["����"]);
            model.Ա����� = GetString(dr["Ա�����"]);
            model.��ְ״̬ = GetString(dr["��ְ״̬"]);
            model.�Ƿ���ְ = GetBool(dr["�Ƿ���ְ"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.��ְ��ʶ = GetDateTime(dr["��ְ��ʶ"]);
        }
    }
}