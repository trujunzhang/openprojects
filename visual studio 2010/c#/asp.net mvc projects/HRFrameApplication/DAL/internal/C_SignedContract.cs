/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/29 21:59:12
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
    /// ���ݷ����� C_SignedContract ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_SignedContract : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_SignedContract model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_SignedContract(");
            strSql.Append("OFFICEID, CONTRACTID, ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_OFFICEID, @in_CONTRACTID, @in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, model.OFFICEID),
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, model.CONTRACTID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_SignedContract model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_SignedContract SET ");
            strSql.Append("OFFICEID=@in_OFFICEID,");
            strSql.Append("CONTRACTID=@in_CONTRACTID,");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��");
            strSql.Append(" WHERE SIGNDCONTRACTID=@in_SIGNDCONTRACTID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_OFFICEID", DbType.Int32, model.OFFICEID),
                dbHelper.CreateInDbParameter("@in_CONTRACTID", DbType.Int32, model.CONTRACTID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_SIGNDCONTRACTID", DbType.Int32, model.SIGNDCONTRACTID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? SIGNDCONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_SignedContract");
            strSql.Append(" WHERE SIGNDCONTRACTID=@in_SIGNDCONTRACTID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_SIGNDCONTRACTID", DbType.Int32, SIGNDCONTRACTID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? SIGNDCONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_SignedContract");
            strSql.Append(" WHERE SIGNDCONTRACTID=@in_SIGNDCONTRACTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_SIGNDCONTRACTID", DbType.Int32, SIGNDCONTRACTID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? SIGNDCONTRACTID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_SignedContract");
            strSql.Append(" WHERE SIGNDCONTRACTID=@in_SIGNDCONTRACTID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_SIGNDCONTRACTID", DbType.Int32, SIGNDCONTRACTID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_SignedContract model, DbDataReader dr)
        {
            model.SIGNDCONTRACTID = GetInt(dr["SIGNDCONTRACTID"]);
            model.OFFICEID = GetInt(dr["OFFICEID"]);
            model.CONTRACTID = GetInt(dr["CONTRACTID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
        }
    }
}