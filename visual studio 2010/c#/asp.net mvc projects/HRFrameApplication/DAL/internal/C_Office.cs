/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/23 15:19:45
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
    /// ���ݷ����� C_Office ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_Office : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Office model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Office(");
            strSql.Append("POSITIONID, PERSONID, ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, �Ƿ���ְ, ��ְ��ʶ)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_POSITIONID, @in_PERSONID, @in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_�Ƿ���ְ, @in_��ְ��ʶ)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, model.POSITIONID),
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_�Ƿ���ְ", DbType.Boolean, model.�Ƿ���ְ),
                dbHelper.CreateInDbParameter("@in_��ְ��ʶ", DbType.DateTime, model.��ְ��ʶ)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Office model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Office SET ");
            strSql.Append("POSITIONID=@in_POSITIONID,");
            strSql.Append("PERSONID=@in_PERSONID,");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("�Ƿ���ְ=@in_�Ƿ���ְ,");
            strSql.Append("��ְ��ʶ=@in_��ְ��ʶ");
            strSql.Append(" WHERE OFFICEID=@in_OFFICEID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, model.POSITIONID),
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_�Ƿ���ְ", DbType.Boolean, model.�Ƿ���ְ),
                dbHelper.CreateInDbParameter("@in_��ְ��ʶ", DbType.DateTime, model.��ְ��ʶ),
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, model.OFFICEID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? OFFICEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Office");
            strSql.Append(" WHERE OFFICEID=@in_OFFICEID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, OFFICEID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? OFFICEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Office");
            strSql.Append(" WHERE OFFICEID=@in_OFFICEID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, OFFICEID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? OFFICEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Office");
            strSql.Append(" WHERE OFFICEID=@in_OFFICEID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, OFFICEID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_Office model, DbDataReader dr)
        {
            model.OFFICEID = GetInt(dr["OFFICEID"]);
            model.POSITIONID = GetInt(dr["POSITIONID"]);
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.�Ƿ���ְ = GetBool(dr["�Ƿ���ְ"]);
            model.��ְ��ʶ = GetDateTime(dr["��ְ��ʶ"]);
        }
    }
}