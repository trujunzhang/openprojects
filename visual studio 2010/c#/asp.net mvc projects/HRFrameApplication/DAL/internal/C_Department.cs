/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/19 14:22:22
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
    /// ���ݷ����� C_Department ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_Department : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Department model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Department(");
            strSql.Append("C_D_DEPARTMENTID, MECHANISMID, ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, ���ż��, ��������, �绰, ��������, ��ַ, ����, ��ַ)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_C_D_DEPARTMENTID, @in_MECHANISMID, @in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_���ż��, @in_��������, @in_�绰, @in_��������, @in_��ַ, @in_����, @in_��ַ)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_C_D_DEPARTMENTID", DbType.Int32, model.C_D_DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_���ż��", DbType.String, model.���ż��),
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
        internal static void PrepareUpdateCommand(Model.C_Department model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Department SET ");
            strSql.Append("C_D_DEPARTMENTID=@in_C_D_DEPARTMENTID,");
            strSql.Append("MECHANISMID=@in_MECHANISMID,");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("���ż��=@in_���ż��,");
            strSql.Append("��������=@in_��������,");
            strSql.Append("�绰=@in_�绰,");
            strSql.Append("��������=@in_��������,");
            strSql.Append("��ַ=@in_��ַ,");
            strSql.Append("����=@in_����,");
            strSql.Append("��ַ=@in_��ַ");
            strSql.Append(" WHERE DEPARTMENTID=@in_DEPARTMENTID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_C_D_DEPARTMENTID", DbType.Int32, model.C_D_DEPARTMENTID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_���ż��", DbType.String, model.���ż��),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_�绰", DbType.String, model.�绰),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_��ַ", DbType.String, model.��ַ),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_��ַ", DbType.String, model.��ַ),
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, model.DEPARTMENTID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? DEPARTMENTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Department");
            strSql.Append(" WHERE DEPARTMENTID=@in_DEPARTMENTID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, DEPARTMENTID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? DEPARTMENTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Department");
            strSql.Append(" WHERE DEPARTMENTID=@in_DEPARTMENTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, DEPARTMENTID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? DEPARTMENTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Department");
            strSql.Append(" WHERE DEPARTMENTID=@in_DEPARTMENTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DEPARTMENTID", DbType.Int32, DEPARTMENTID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_Department model, DbDataReader dr)
        {
            model.DEPARTMENTID = GetInt(dr["DEPARTMENTID"]);
            model.C_D_DEPARTMENTID = GetInt(dr["C_D_DEPARTMENTID"]);
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.���ż�� = GetString(dr["���ż��"]);
            model.�������� = GetString(dr["��������"]);
            model.�绰 = GetString(dr["�绰"]);
            model.�������� = GetString(dr["��������"]);
            model.��ַ = GetString(dr["��ַ"]);
            model.���� = GetString(dr["����"]);
            model.��ַ = GetString(dr["��ַ"]);
        }
    }
}