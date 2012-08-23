/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/26 10:36:50
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
    /// ���ݷ����� C_Position ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_Position : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Position model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Position(");
            strSql.Append("DEPARTMENTID, ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, ְλ����, �Ƿ��Ź���ְλ, ��������, ְλ����, ����ְ��, ��ְҪ��, ����ʱ��)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_DEPARTMENTID, @in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_ְλ����, @in_�Ƿ��Ź���ְλ, @in_��������, @in_ְλ����, @in_����ְ��, @in_��ְҪ��, @in_����ʱ��)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_ְλ����", DbType.String, model.ְλ����),
                dbHelper.CreateInDbParameter("@in_�Ƿ��Ź���ְλ", DbType.Boolean, model.�Ƿ��Ź���ְλ),
                dbHelper.CreateInDbParameter("@in_��������", DbType.Int32, model.��������),
                dbHelper.CreateInDbParameter("@in_ְλ����", DbType.String, model.ְλ����),
                dbHelper.CreateInDbParameter("@in_����ְ��", DbType.String, model.����ְ��),
                dbHelper.CreateInDbParameter("@in_��ְҪ��", DbType.String, model.��ְҪ��),
                dbHelper.CreateInDbParameter("@in_����ʱ��", DbType.DateTime, model.����ʱ��)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Position model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Position SET ");
            strSql.Append("DEPARTMENTID=@in_DEPARTMENTID,");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("ְλ����=@in_ְλ����,");
            strSql.Append("�Ƿ��Ź���ְλ=@in_�Ƿ��Ź���ְλ,");
            strSql.Append("��������=@in_��������,");
            strSql.Append("ְλ����=@in_ְλ����,");
            strSql.Append("����ְ��=@in_����ְ��,");
            strSql.Append("��ְҪ��=@in_��ְҪ��,");
            strSql.Append("����ʱ��=@in_����ʱ��");
            strSql.Append(" WHERE POSITIONID=@in_POSITIONID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_ְλ����", DbType.String, model.ְλ����),
                dbHelper.CreateInDbParameter("@in_�Ƿ��Ź���ְλ", DbType.Boolean, model.�Ƿ��Ź���ְλ),
                dbHelper.CreateInDbParameter("@in_��������", DbType.Int32, model.��������),
                dbHelper.CreateInDbParameter("@in_ְλ����", DbType.String, model.ְλ����),
                dbHelper.CreateInDbParameter("@in_����ְ��", DbType.String, model.����ְ��),
                dbHelper.CreateInDbParameter("@in_��ְҪ��", DbType.String, model.��ְҪ��),
                dbHelper.CreateInDbParameter("@in_����ʱ��", DbType.DateTime, model.����ʱ��),
                dbHelper.CreateInDbParameter("@in_POSITIONID", DbType.Int32, model.POSITIONID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
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
        /// Ϊ��ѯ�Ƿ����һ������׼������
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
        /// Ϊ��ȡһ������׼������
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
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_Position model, DbDataReader dr)
        {
            model.POSITIONID = GetInt(dr["POSITIONID"]);
            model.DEPARTMENTID = GetInt(dr["DEPARTMENTID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.ְλ���� = GetString(dr["ְλ����"]);
            model.�Ƿ��Ź���ְλ = GetBool(dr["�Ƿ��Ź���ְλ"]);
            model.�������� = GetInt(dr["��������"]);
            model.ְλ���� = GetString(dr["ְλ����"]);
            model.����ְ�� = GetString(dr["����ְ��"]);
            model.��ְҪ�� = GetString(dr["��ְҪ��"]);
            model.����ʱ�� = GetDateTime(dr["����ʱ��"]);
        }
    }
}