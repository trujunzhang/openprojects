/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/20 15:42:06
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;

namespace Model
{
    /// <summary>
    /// ʵ���� C_PersonInCharge���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_PersonInCharge : ICloneable
    {
        public C_PersonInCharge()
        { }
        
        /// <summary>
        /// ���캯�� C_PersonInCharge
        /// </summary>
        /// <param name="pERSONINCHARGEID">PERSONINCHARGEID</param>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="����λ��">����λ��</param>
        public C_PersonInCharge(int? pERSONINCHARGEID, int? pERSONID, int? mECHANISMID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, int? ����λ��)
        {
            this.PERSONINCHARGEID = pERSONINCHARGEID;
            this.PERSONID = pERSONID;
            this.MECHANISMID = mECHANISMID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.����λ�� = ����λ��;
        }
        
        #region ʵ������
        /// <summary>
        /// PERSONINCHARGEID
        /// </summary>
        public int? PERSONINCHARGEID { get; set; }
        
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
        /// <summary>
        /// MECHANISMID
        /// </summary>
        public int? MECHANISMID { get; set; }
        
        /// <summary>
        /// ɾ����ʶ
        /// </summary>
        public bool? ɾ����ʶ { get; set; }
        
        /// <summary>
        /// ������
        /// </summary>
        public string ������ { get; set; }
        
        /// <summary>
        /// ������ʱ��
        /// </summary>
        public DateTime? ������ʱ�� { get; set; }
        
        /// <summary>
        /// �޸���
        /// </summary>
        public string �޸��� { get; set; }
        
        /// <summary>
        /// �޸���ʱ��
        /// </summary>
        public DateTime? �޸���ʱ�� { get; set; }
        
        /// <summary>
        /// ����λ��
        /// </summary>
        public int? ����λ�� { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_PersonInCharge model = obj as Model.C_PersonInCharge;
            if (model != null && model.PERSONINCHARGEID == this.PERSONINCHARGEID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return PERSONINCHARGEID.GetHashCode();
        }
    }
}
    