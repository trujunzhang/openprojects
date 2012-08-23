/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/26 9:27:33
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
    /// ���ݷ����� C_Contract ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_Contract : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Contract model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Contract(");
            strSql.Append("ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, ֤������, ��ͬ���, ��ͬ����, ��ͬ����, ��ͬ״̬, ��ͬ����, ��ʼʱ��, ����ʱ��, ��ͬ����, ��ͬ����)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_֤������, @in_��ͬ���, @in_��ͬ����, @in_��ͬ����, @in_��ͬ״̬, @in_��ͬ����, @in_��ʼʱ��, @in_����ʱ��, @in_��ͬ����, @in_��ͬ����)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_֤������", DbType.String, model.֤������),
                dbHelper.CreateInDbParameter("@in_��ͬ���", DbType.String, model.��ͬ���),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_��ͬ״̬", DbType.String, model.��ͬ״̬),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_��ʼʱ��", DbType.DateTime, model.��ʼʱ��),
                dbHelper.CreateInDbParameter("@in_����ʱ��", DbType.DateTime, model.����ʱ��),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Contract model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Contract SET ");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("֤������=@in_֤������,");
            strSql.Append("��ͬ���=@in_��ͬ���,");
            strSql.Append("��ͬ����=@in_��ͬ����,");
            strSql.Append("��ͬ����=@in_��ͬ����,");
            strSql.Append("��ͬ״̬=@in_��ͬ״̬,");
            strSql.Append("��ͬ����=@in_��ͬ����,");
            strSql.Append("��ʼʱ��=@in_��ʼʱ��,");
            strSql.Append("����ʱ��=@in_����ʱ��,");
            strSql.Append("��ͬ����=@in_��ͬ����,");
            strSql.Append("��ͬ����=@in_��ͬ����");
            strSql.Append(" WHERE CONTRACTID=@in_CONTRACTID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_֤������", DbType.String, model.֤������),
                dbHelper.CreateInDbParameter("@in_��ͬ���", DbType.String, model.��ͬ���),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_��ͬ״̬", DbType.String, model.��ͬ״̬),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_��ʼʱ��", DbType.DateTime, model.��ʼʱ��),
                dbHelper.CreateInDbParameter("@in_����ʱ��", DbType.DateTime, model.����ʱ��),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_��ͬ����", DbType.String, model.��ͬ����),
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, model.CONTRACTID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? CONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Contract");
            strSql.Append(" WHERE CONTRACTID=@in_CONTRACTID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, CONTRACTID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? CONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Contract");
            strSql.Append(" WHERE CONTRACTID=@in_CONTRACTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, CONTRACTID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? CONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Contract");
            strSql.Append(" WHERE CONTRACTID=@in_CONTRACTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, CONTRACTID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_Contract model, DbDataReader dr)
        {
            model.CONTRACTID = GetInt(dr["CONTRACTID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.֤������ = GetString(dr["֤������"]);
            model.��ͬ��� = GetString(dr["��ͬ���"]);
            model.��ͬ���� = GetString(dr["��ͬ����"]);
            model.��ͬ���� = GetString(dr["��ͬ����"]);
            model.��ͬ״̬ = GetString(dr["��ͬ״̬"]);
            model.��ͬ���� = GetString(dr["��ͬ����"]);
            model.��ʼʱ�� = GetDateTime(dr["��ʼʱ��"]);
            model.����ʱ�� = GetDateTime(dr["����ʱ��"]);
            model.��ͬ���� = GetString(dr["��ͬ����"]);
            model.��ͬ���� = GetString(dr["��ͬ����"]);
        }
    }
}