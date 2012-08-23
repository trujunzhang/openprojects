/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/30 15:07:38
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
    /// ���ݷ����� C_DataDictionary ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_DataDictionary : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_DataDictionary model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_DataDictionary(");
            strSql.Append("ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, ���˵����, �Ӳ˵����, �ֵ�����, �ֵ�����)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_���˵����, @in_�Ӳ˵����, @in_�ֵ�����, @in_�ֵ�����)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_���˵����", DbType.String, model.���˵����),
                dbHelper.CreateInDbParameter("@in_�Ӳ˵����", DbType.String, model.�Ӳ˵����),
                dbHelper.CreateInDbParameter("@in_�ֵ�����", DbType.String, model.�ֵ�����),
                dbHelper.CreateInDbParameter("@in_�ֵ�����", DbType.Binary, model.�ֵ�����)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_DataDictionary model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_DataDictionary SET ");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("���˵����=@in_���˵����,");
            strSql.Append("�Ӳ˵����=@in_�Ӳ˵����,");
            strSql.Append("�ֵ�����=@in_�ֵ�����,");
            strSql.Append("�ֵ�����=@in_�ֵ�����");
            strSql.Append(" WHERE DATADICTIONARY_ID=@in_DATADICTIONARY_ID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_���˵����", DbType.String, model.���˵����),
                dbHelper.CreateInDbParameter("@in_�Ӳ˵����", DbType.String, model.�Ӳ˵����),
                dbHelper.CreateInDbParameter("@in_�ֵ�����", DbType.String, model.�ֵ�����),
                dbHelper.CreateInDbParameter("@in_�ֵ�����", DbType.Binary, model.�ֵ�����),
                dbHelper.CreateInDbParameter("@in_DATADICTIONARY_ID", DbType.Int32, model.DATADICTIONARY_ID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? DATADICTIONARY_ID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_DataDictionary");
            strSql.Append(" WHERE DATADICTIONARY_ID=@in_DATADICTIONARY_ID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DATADICTIONARY_ID", DbType.Int32, DATADICTIONARY_ID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? DATADICTIONARY_ID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_DataDictionary");
            strSql.Append(" WHERE DATADICTIONARY_ID=@in_DATADICTIONARY_ID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DATADICTIONARY_ID", DbType.Int32, DATADICTIONARY_ID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? DATADICTIONARY_ID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_DataDictionary");
            strSql.Append(" WHERE DATADICTIONARY_ID=@in_DATADICTIONARY_ID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_DATADICTIONARY_ID", DbType.Int32, DATADICTIONARY_ID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_DataDictionary model, DbDataReader dr)
        {
            model.DATADICTIONARY_ID = GetInt(dr["DATADICTIONARY_ID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.���˵���� = GetString(dr["���˵����"]);
            model.�Ӳ˵���� = GetString(dr["�Ӳ˵����"]);
            model.�ֵ����� = GetString(dr["�ֵ�����"]);
            model.�ֵ����� = GetBinary(dr["�ֵ�����"]);
        }
    }
}