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
    /// ���ݷ����� C_PersonnelDocuments ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_PersonnelDocuments : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_PersonnelDocuments model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_PersonnelDocuments(");
            strSql.Append("ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, ���, ������, ������, �ؼ���, ���ϼ��, ����)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_���, @in_������, @in_������, @in_�ؼ���, @in_���ϼ��, @in_����)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_���", DbType.String, model.���),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_�ؼ���", DbType.String, model.�ؼ���),
                dbHelper.CreateInDbParameter("@in_���ϼ��", DbType.String, model.���ϼ��),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_PersonnelDocuments model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_PersonnelDocuments SET ");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("���=@in_���,");
            strSql.Append("������=@in_������,");
            strSql.Append("������=@in_������,");
            strSql.Append("�ؼ���=@in_�ؼ���,");
            strSql.Append("���ϼ��=@in_���ϼ��,");
            strSql.Append("����=@in_����");
            strSql.Append(" WHERE PERSONNELDOCUMENTSID=@in_PERSONNELDOCUMENTSID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_���", DbType.String, model.���),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_�ؼ���", DbType.String, model.�ؼ���),
                dbHelper.CreateInDbParameter("@in_���ϼ��", DbType.String, model.���ϼ��),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSID", DbType.Int32, model.PERSONNELDOCUMENTSID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONNELDOCUMENTSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_PersonnelDocuments");
            strSql.Append(" WHERE PERSONNELDOCUMENTSID=@in_PERSONNELDOCUMENTSID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSID", DbType.Int32, PERSONNELDOCUMENTSID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONNELDOCUMENTSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_PersonnelDocuments");
            strSql.Append(" WHERE PERSONNELDOCUMENTSID=@in_PERSONNELDOCUMENTSID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSID", DbType.Int32, PERSONNELDOCUMENTSID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? PERSONNELDOCUMENTSID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_PersonnelDocuments");
            strSql.Append(" WHERE PERSONNELDOCUMENTSID=@in_PERSONNELDOCUMENTSID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONNELDOCUMENTSID", DbType.Int32, PERSONNELDOCUMENTSID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_PersonnelDocuments model, DbDataReader dr)
        {
            model.PERSONNELDOCUMENTSID = GetInt(dr["PERSONNELDOCUMENTSID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.��� = GetString(dr["���"]);
            model.������ = GetString(dr["������"]);
            model.������ = GetString(dr["������"]);
            model.�ؼ��� = GetString(dr["�ؼ���"]);
            model.���ϼ�� = GetString(dr["���ϼ��"]);
            model.���� = GetString(dr["����"]);
        }
    }
}