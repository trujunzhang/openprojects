/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/2 10:11:37
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
    /// ���ݷ����� C_Mechanism ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_Mechanism : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Mechanism model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Mechanism(");
            strSql.Append("ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, �������, ��������, �绰, ��������, ��ַ, ����, ��ַ)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_�������, @in_��������, @in_�绰, @in_��������, @in_��ַ, @in_����, @in_��ַ)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_�������", DbType.String, model.�������),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_�绰", DbType.String, model.�绰),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_��ַ", DbType.String, model.��ַ),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_��ַ", DbType.String, model.��ַ)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Mechanism model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Mechanism SET ");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("�������=@in_�������,");
            strSql.Append("��������=@in_��������,");
            strSql.Append("�绰=@in_�绰,");
            strSql.Append("��������=@in_��������,");
            strSql.Append("��ַ=@in_��ַ,");
            strSql.Append("����=@in_����,");
            strSql.Append("��ַ=@in_��ַ");
            strSql.Append(" WHERE MECHANISMID=@in_MECHANISMID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_�������", DbType.String, model.�������),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_�绰", DbType.String, model.�绰),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_��ַ", DbType.String, model.��ַ),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_��ַ", DbType.String, model.��ַ),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? MECHANISMID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Mechanism");
            strSql.Append(" WHERE MECHANISMID=@in_MECHANISMID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, MECHANISMID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? MECHANISMID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Mechanism");
            strSql.Append(" WHERE MECHANISMID=@in_MECHANISMID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, MECHANISMID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? MECHANISMID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Mechanism");
            strSql.Append(" WHERE MECHANISMID=@in_MECHANISMID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, MECHANISMID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_Mechanism model, DbDataReader dr)
        {
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.������� = GetString(dr["�������"]);
            model.�������� = GetString(dr["��������"]);
            model.�绰 = GetString(dr["�绰"]);
            model.�������� = GetString(dr["��������"]);
            model.��ַ = GetString(dr["��ַ"]);
            model.���� = GetString(dr["����"]);
            model.��ַ = GetString(dr["��ַ"]);
        }
    }
}