/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/23 8:38:39
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
    /// ���ݷ����� C_Transfer ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_Transfer : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Transfer model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Transfer(");
            strSql.Append("ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, Ա��ID, ԭְλ, ��ְλ, ����ԭ��)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_Ա��ID, @in_ԭְλ, @in_��ְλ, @in_����ԭ��)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Int32, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_Ա��ID", DbType.Int32, model.Ա��ID),
                dbHelper.CreateInDbParameter("@in_ԭְλ", DbType.Int32, model.ԭְλ),
                dbHelper.CreateInDbParameter("@in_��ְλ", DbType.Int32, model.��ְλ),
                dbHelper.CreateInDbParameter("@in_����ԭ��", DbType.String, model.����ԭ��)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Transfer model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Transfer SET ");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("Ա��ID=@in_Ա��ID,");
            strSql.Append("ԭְλ=@in_ԭְλ,");
            strSql.Append("��ְλ=@in_��ְλ,");
            strSql.Append("����ԭ��=@in_����ԭ��");
            strSql.Append(" WHERE TRANSFERID=@in_TRANSFERID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Int32, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_Ա��ID", DbType.Int32, model.Ա��ID),
                dbHelper.CreateInDbParameter("@in_ԭְλ", DbType.Int32, model.ԭְλ),
                dbHelper.CreateInDbParameter("@in_��ְλ", DbType.Int32, model.��ְλ),
                dbHelper.CreateInDbParameter("@in_����ԭ��", DbType.String, model.����ԭ��),
                dbHelper.CreateInDbParameter("@in_TRANSFERID", DbType.Int32, model.TRANSFERID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? TRANSFERID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Transfer");
            strSql.Append(" WHERE TRANSFERID=@in_TRANSFERID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_TRANSFERID", DbType.Int32, TRANSFERID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? TRANSFERID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Transfer");
            strSql.Append(" WHERE TRANSFERID=@in_TRANSFERID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_TRANSFERID", DbType.Int32, TRANSFERID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? TRANSFERID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Transfer");
            strSql.Append(" WHERE TRANSFERID=@in_TRANSFERID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_TRANSFERID", DbType.Int32, TRANSFERID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_Transfer model, DbDataReader dr)
        {
            model.TRANSFERID = GetInt(dr["TRANSFERID"]);
            model.ɾ����ʶ = GetInt(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.Ա��ID = GetInt(dr["Ա��ID"]);
            model.ԭְλ = GetInt(dr["ԭְλ"]);
            model.��ְλ = GetInt(dr["��ְλ"]);
            model.����ԭ�� = GetString(dr["����ԭ��"]);
        }
    }
}