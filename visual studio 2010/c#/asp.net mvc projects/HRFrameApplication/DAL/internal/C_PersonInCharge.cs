/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/7 9:53:22
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
    /// ���ݷ����� C_PersonInCharge ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_PersonInCharge : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_PersonInCharge model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_PersonInCharge(");
            strSql.Append("PERSONID, MECHANISMID, ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, ����λ��)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_PERSONID, @in_MECHANISMID, @in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_����λ��)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_����λ��", DbType.Int32, model.����λ��)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_PersonInCharge model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_PersonInCharge SET ");
            strSql.Append("PERSONID=@in_PERSONID,");
            strSql.Append("MECHANISMID=@in_MECHANISMID,");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("����λ��=@in_����λ��");
            strSql.Append(" WHERE PERSONINCHARGEID=@in_PERSONINCHARGEID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_����λ��", DbType.Int32, model.����λ��),
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, model.PERSONINCHARGEID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONINCHARGEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_PersonInCharge");
            strSql.Append(" WHERE PERSONINCHARGEID=@in_PERSONINCHARGEID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, PERSONINCHARGEID)};
        }
        
        /// <summary>
        /// TODO [Custom]{change}[2011-09-08]
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(string tableColumnName, int? PERSONINCHARGEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_PersonInCharge");
            strSql.Append(string.Format(" WHERE {0}=@in_PERSONINCHARGEID", tableColumnName));
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, PERSONINCHARGEID)};
        }
        
        /// <summary>
        /// TODO [Custom][2011-09-08]
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(string tableColumnName, int? PERSONINCHARGEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_PersonInCharge");
            strSql.Append(string.Format(" WHERE {0}=@in_PERSONINCHARGEID", tableColumnName));
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, PERSONINCHARGEID)};
        }
                    /// <summary>
        /// TODO [Custom][2011-09-08]
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand( int? PERSONINCHARGEID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_PersonInCharge");
            strSql.Append(string.Format(" WHERE {0}=@in_PERSONINCHARGEID", "PERSONINCHARGEID"));

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, PERSONINCHARGEID)};
        }
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_PersonInCharge model, DbDataReader dr)
        {
            model.PERSONINCHARGEID = GetInt(dr["PERSONINCHARGEID"]);
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.����λ�� = GetInt(dr["����λ��"]);
        }
    }
}