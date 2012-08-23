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
    /// ���ݷ����� C_PersonnelDocumentsClass ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_PersonnelDocumentsClass : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_PersonnelDocumentsClass model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_PersonnelDocumentsClass(");
            strSql.Append("ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, �������, �������, Ȩ������)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_�������, @in_�������, @in_Ȩ������)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_�������", DbType.String, model.�������),
                dbHelper.CreateInDbParameter("@in_�������", DbType.String, model.�������),
                dbHelper.CreateInDbParameter("@in_Ȩ������", DbType.String, model.Ȩ������)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_PersonnelDocumentsClass model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_PersonnelDocumentsClass SET ");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("�������=@in_�������,");
            strSql.Append("�������=@in_�������,");
            strSql.Append("Ȩ������=@in_Ȩ������");
            strSql.Append(" WHERE PERSONNELDOCUMENTSCLASSID=@in_PERSONNELDOCUMENTSCLASSID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_�������", DbType.String, model.�������),
                dbHelper.CreateInDbParameter("@in_�������", DbType.String, model.�������),
                dbHelper.CreateInDbParameter("@in_Ȩ������", DbType.String, model.Ȩ������),
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSCLASSID", DbType.Int32, model.PERSONNELDOCUMENTSCLASSID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONNELDOCUMENTSCLASSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_PersonnelDocumentsClass");
            strSql.Append(" WHERE PERSONNELDOCUMENTSCLASSID=@in_PERSONNELDOCUMENTSCLASSID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSCLASSID", DbType.Int32, PERSONNELDOCUMENTSCLASSID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONNELDOCUMENTSCLASSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_PersonnelDocumentsClass");
            strSql.Append(" WHERE PERSONNELDOCUMENTSCLASSID=@in_PERSONNELDOCUMENTSCLASSID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSCLASSID", DbType.Int32, PERSONNELDOCUMENTSCLASSID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? PERSONNELDOCUMENTSCLASSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_PersonnelDocumentsClass");
            strSql.Append(" WHERE PERSONNELDOCUMENTSCLASSID=@in_PERSONNELDOCUMENTSCLASSID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSCLASSID", DbType.Int32, PERSONNELDOCUMENTSCLASSID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_PersonnelDocumentsClass model, DbDataReader dr)
        {
            model.PERSONNELDOCUMENTSCLASSID = GetInt(dr["PERSONNELDOCUMENTSCLASSID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.������� = GetString(dr["�������"]);
            model.������� = GetString(dr["�������"]);
            model.Ȩ������ = GetString(dr["Ȩ������"]);
        }
    }
}