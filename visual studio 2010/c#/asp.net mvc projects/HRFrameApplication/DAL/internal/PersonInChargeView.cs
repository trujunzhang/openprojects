/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.5.0.0 �Զ������� 2012/6/22 9:14:52
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
    /// ���ݷ����� PersonInChargeView ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class PersonInChargeView : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(Model.PersonInChargeView model, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("INSERT INTO PersonInChargeView(");
            sbSql4PersonInChargeView.Append("PERSONID, MECHANISMID, PERSONINCHARGEID, ��������, �������, ����, Ա�����, ɾ����ʶ, ����λ��)");
            sbSql4PersonInChargeView.Append(" VALUES (");
            sbSql4PersonInChargeView.Append("@in_PERSONID, @in_MECHANISMID, @in_PERSONINCHARGEID, @in_��������, @in_�������, @in_����, @in_Ա�����, @in_ɾ����ʶ, @in_����λ��)");
    
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID),
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, model.PERSONINCHARGEID),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_�������", DbType.String, model.�������),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_Ա�����", DbType.String, model.Ա�����),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_����λ��", DbType.Int32, model.����λ��)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(Model.PersonInChargeView model, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("UPDATE PersonInChargeView SET ");
            sbSql4PersonInChargeView.Append("MECHANISMID=@in_MECHANISMID,");
            sbSql4PersonInChargeView.Append("PERSONINCHARGEID=@in_PERSONINCHARGEID,");
            sbSql4PersonInChargeView.Append("��������=@in_��������,");
            sbSql4PersonInChargeView.Append("�������=@in_�������,");
            sbSql4PersonInChargeView.Append("����=@in_����,");
            sbSql4PersonInChargeView.Append("Ա�����=@in_Ա�����,");
            sbSql4PersonInChargeView.Append("ɾ����ʶ=@in_ɾ����ʶ,");
            sbSql4PersonInChargeView.Append("����λ��=@in_����λ��");
            sbSql4PersonInChargeView.Append(" WHERE PERSONID=@in_PERSONID");
    
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_MECHANISMID", DbType.Int32, model.MECHANISMID),
                dbHelper.CreateInDbParameter("@in_PERSONINCHARGEID", DbType.Int32, model.PERSONINCHARGEID),
                dbHelper.CreateInDbParameter("@in_��������", DbType.String, model.��������),
                dbHelper.CreateInDbParameter("@in_�������", DbType.String, model.�������),
                dbHelper.CreateInDbParameter("@in_����", DbType.String, model.����),
                dbHelper.CreateInDbParameter("@in_Ա�����", DbType.String, model.Ա�����),
                dbHelper.CreateInDbParameter("@in_ɾ����ʶ", DbType.Boolean, model.ɾ����ʶ),
                dbHelper.CreateInDbParameter("@in_����λ��", DbType.Int32, model.����λ��),
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONID, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("DELETE FROM PersonInChargeView");
            sbSql4PersonInChargeView.Append(" WHERE PERSONID=@in_PERSONID");
      
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONID, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("SELECT COUNT(1) FROM PersonInChargeView");
            sbSql4PersonInChargeView.Append(" WHERE PERSONID=@in_PERSONID");
          
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? PERSONID, out StringBuilder sbSql4PersonInChargeView, out DbParameter[] parms4PersonInChargeView)
        {
            sbSql4PersonInChargeView = new StringBuilder();
            sbSql4PersonInChargeView.Append("SELECT * FROM PersonInChargeView");
            sbSql4PersonInChargeView.Append(" WHERE PERSONID=@in_PERSONID");
          
            parms4PersonInChargeView = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(Model.PersonInChargeView model, DbDataReader dr)
        {
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.MECHANISMID = GetInt(dr["MECHANISMID"]);
            model.PERSONINCHARGEID = GetInt(dr["PERSONINCHARGEID"]);
            model.�������� = GetString(dr["��������"]);
            model.������� = GetString(dr["�������"]);
            model.���� = GetString(dr["����"]);
            model.Ա����� = GetString(dr["Ա�����"]);
            model.ɾ����ʶ = GetBool(dr["ɾ����ʶ"]);
            model.����λ�� = GetInt(dr["����λ��"]);
        }
    }
}