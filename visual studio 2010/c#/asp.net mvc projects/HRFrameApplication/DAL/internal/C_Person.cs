/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/6 9:56:57
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
    /// ���ݷ����� C_Person ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class C_Person : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Person model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Person(");
            strSql.Append("ɾ����ʶ, ������, ������ʱ��, �޸���, �޸���ʱ��, ����, ֤������, ����, ��¼�ʺ�, Ա�����, ������, �Ա�, ��������, ����, ������, ����, ����, ��������, ����״��, Ա�����, ����, ֤������, ������ò, ����״��, ���, ����, ����, ���ѧ��, ���ѧλ, רҵ, ְ��, ��ҵԺУ, ��ע, ��ְ״̬)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_ɾ����ʶ, @in_������, @in_������ʱ��, @in_�޸���, @in_�޸���ʱ��, @in_����, @in_֤������, @in_����, @in_��¼�ʺ�, @in_Ա�����, @in_������, @in_�Ա�, @in_��������, @in_����, @in_������, @in_����, @in_����, @in_��������, @in_����״��, @in_Ա�����, @in_����, @in_֤������, @in_������ò, @in_����״��, @in_���, @in_����, @in_����, @in_���ѧ��, @in_���ѧλ, @in_רҵ, @in_ְ��, @in_��ҵԺУ, @in_��ע, @in_��ְ״̬)");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_֤������", DbType.String, model.֤������),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_��¼�ʺ�", DbType.String, model.��¼�ʺ�),
                dbHelper.CreateInDbParameter("@in_Ա�����", DbType.String, model.Ա�����),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_�Ա�", DbType.String, model.�Ա�),
                dbHelper.CreateInDbParameter("@in_��������", DbType.DateTime, model.��������),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_����״��", DbType.Boolean, model.����״��),
                dbHelper.CreateInDbParameter("@in_Ա�����", DbType.String, model.Ա�����),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_֤������", DbType.String, model.֤������),
                dbHelper.CreateInDbParameter("@in_������ò", DbType.String, model.������ò),
                dbHelper.CreateInDbParameter("@in_����״��", DbType.String, model.����״��),
                dbHelper.CreateInDbParameter("@in_���", DbType.Double, model.���),
                dbHelper.CreateInDbParameter("@in_����", DbType.Double, model.����),
                dbHelper.CreateInDbParameter("@in_����", DbType.Double, model.����),
                dbHelper.CreateInDbParameter("@in_���ѧ��", DbType.String, model.���ѧ��),
                dbHelper.CreateInDbParameter("@in_���ѧλ", DbType.String, model.���ѧλ),
                dbHelper.CreateInDbParameter("@in_רҵ", DbType.String, model.רҵ),
                dbHelper.CreateInDbParameter("@in_ְ��", DbType.String, model.ְ��),
                dbHelper.CreateInDbParameter("@in_��ҵԺУ", DbType.String, model.��ҵԺУ),
                dbHelper.CreateInDbParameter("@in_��ע", DbType.String, model.��ע),
                dbHelper.CreateInDbParameter("@in_��ְ״̬", DbType.String, model.��ְ״̬)};
        }

        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Person model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Person SET ");
            strSql.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            strSql.Append("������=@in_������,");
            strSql.Append("������ʱ��=@in_������ʱ��,");
            strSql.Append("�޸���=@in_�޸���,");
            strSql.Append("�޸���ʱ��=@in_�޸���ʱ��,");
            strSql.Append("����=@in_����,");
            strSql.Append("֤������=@in_֤������,");
            strSql.Append("����=@in_����,");
            strSql.Append("��¼�ʺ�=@in_��¼�ʺ�,");
            strSql.Append("Ա�����=@in_Ա�����,");
            strSql.Append("������=@in_������,");
            strSql.Append("�Ա�=@in_�Ա�,");
            strSql.Append("��������=@in_��������,");
            strSql.Append("����=@in_����,");
            strSql.Append("������=@in_������,");
            strSql.Append("����=@in_����,");
            strSql.Append("����=@in_����,");
            strSql.Append("��������=@in_��������,");
            strSql.Append("����״��=@in_����״��,");
            strSql.Append("Ա�����=@in_Ա�����,");
            strSql.Append("����=@in_����,");
            strSql.Append("֤������=@in_֤������,");
            strSql.Append("������ò=@in_������ò,");
            strSql.Append("����״��=@in_����״��,");
            strSql.Append("���=@in_���,");
            strSql.Append("����=@in_����,");
            strSql.Append("����=@in_����,");
            strSql.Append("���ѧ��=@in_���ѧ��,");
            strSql.Append("���ѧλ=@in_���ѧλ,");
            strSql.Append("רҵ=@in_רҵ,");
            strSql.Append("ְ��=@in_ְ��,");
            strSql.Append("��ҵԺУ=@in_��ҵԺУ,");
            strSql.Append("��ע=@in_��ע,");
            strSql.Append("��ְ״̬=@in_��ְ״̬");
            strSql.Append(" WHERE PERSONID=@in_PERSONID");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_������ʱ��", DbType.DateTime, model.������ʱ��),
                dbHelper.CreateInDbParameter("@in_�޸���", DbType.String, model.�޸���),
                dbHelper.CreateInDbParameter("@in_�޸���ʱ��", DbType.DateTime, model.�޸���ʱ��),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_֤������", DbType.String, model.֤������),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_��¼�ʺ�", DbType.String, model.��¼�ʺ�),
                dbHelper.CreateInDbParameter("@in_Ա�����", DbType.String, model.Ա�����),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_�Ա�", DbType.String, model.�Ա�),
                dbHelper.CreateInDbParameter("@in_��������", DbType.DateTime, model.��������),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_������", DbType.String, model.������),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_����״��", DbType.Boolean, model.����״��),
                dbHelper.CreateInDbParameter("@in_Ա�����", DbType.String, model.Ա�����),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_֤������", DbType.String, model.֤������),
                dbHelper.CreateInDbParameter("@in_������ò", DbType.String, model.������ò),
                dbHelper.CreateInDbParameter("@in_����״��", DbType.String, model.����״��),
                dbHelper.CreateInDbParameter("@in_���", DbType.Double, model.���),
                dbHelper.CreateInDbParameter("@in_����", DbType.Double, model.����),
                dbHelper.CreateInDbParameter("@in_����", DbType.Double, model.����),
                dbHelper.CreateInDbParameter("@in_���ѧ��", DbType.String, model.���ѧ��),
                dbHelper.CreateInDbParameter("@in_���ѧλ", DbType.String, model.���ѧλ),
                dbHelper.CreateInDbParameter("@in_רҵ", DbType.String, model.רҵ),
                dbHelper.CreateInDbParameter("@in_ְ��", DbType.String, model.ְ��),
                dbHelper.CreateInDbParameter("@in_��ҵԺУ", DbType.String, model.��ҵԺУ),
                dbHelper.CreateInDbParameter("@in_��ע", DbType.String, model.��ע),
                dbHelper.CreateInDbParameter("@in_��ְ״̬", DbType.String, model.��ְ״̬),
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID)};
        }

        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Person");
            strSql.Append(" WHERE PERSONID=@in_PERSONID");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }

        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Person");
            strSql.Append(" WHERE PERSONID=@in_PERSONID");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }

        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(string tableColumnName, int? PERSONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Person");
            strSql.Append(string.Format(" WHERE {0}=@in_PERSONID", tableColumnName));

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(string tableColumnName, string PERSONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Person");
            strSql.Append(string.Format(" WHERE {0}='{1}'", tableColumnName, PERSONID));

            cmdParms = new DbParameter[]{
                //dbHelper.CreateInDbParameter("@in_PERSONID", DbType.String, PERSONID)
            };
        }
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.C_Person model, DbDataReader dr)
        {
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.������ = GetString(dr["������"]);
            model.������ʱ�� = GetDateTime(dr["������ʱ��"]);
            model.�޸��� = GetString(dr["�޸���"]);
            model.�޸���ʱ�� = GetDateTime(dr["�޸���ʱ��"]);
            model.���� = GetString(dr["����"]);
            model.֤������ = GetString(dr["֤������"]);
            model.���� = GetString(dr["����"]);
            model.��¼�ʺ� = GetString(dr["��¼�ʺ�"]);
            model.Ա����� = GetString(dr["Ա�����"]);
            model.������ = GetString(dr["������"]);
            model.�Ա� = GetString(dr["�Ա�"]);
            model.�������� = GetDateTime(dr["��������"]);
            model.���� = GetString(dr["����"]);
            model.������ = GetString(dr["������"]);
            model.���� = GetString(dr["����"]);
            model.���� = GetString(dr["����"]);
            model.�������� = GetString(dr["��������"]);
            model.����״�� = GetBool(dr["����״��"]);
            model.Ա����� = GetString(dr["Ա�����"]);
            model.���� = GetString(dr["����"]);
            model.֤������ = GetString(dr["֤������"]);
            model.������ò = GetString(dr["������ò"]);
            model.����״�� = GetString(dr["����״��"]);
            model.��� = GetDouble(dr["���"]);
            model.���� = GetDouble(dr["����"]);
            model.���� = GetDouble(dr["����"]);
            model.���ѧ�� = GetString(dr["���ѧ��"]);
            model.���ѧλ = GetString(dr["���ѧλ"]);
            model.רҵ = GetString(dr["רҵ"]);
            model.ְ�� = GetString(dr["ְ��"]);
            model.��ҵԺУ = GetString(dr["��ҵԺУ"]);
            model.��ע = GetString(dr["��ע"]);
            model.��ְ״̬ = GetString(dr["��ְ״̬"]);
        }
    }
}