/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.5.0.0 �Զ������� 2012/6/22 9:14:51
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
    /// ʵ���� PersonInChargeView���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class PersonInChargeView : ICloneable
    {
        public PersonInChargeView()
        { }
        
        /// <summary>
        /// ���캯�� PersonInChargeView
        /// </summary>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="pERSONINCHARGEID">PERSONINCHARGEID</param>
        /// <param name="��������">��������</param>
        /// <param name="�������">�������</param>
        /// <param name="����">����</param>
        /// <param name="Ա�����">Ա�����</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="����λ��">����λ��</param>
        public PersonInChargeView(int? pERSONID, int? mECHANISMID, int? pERSONINCHARGEID, string ��������, string �������, string ����, string Ա�����, bool? ɾ����ʶ, int? ����λ��)
        {
            this.PERSONID = pERSONID;
            this.MECHANISMID = mECHANISMID;
            this.PERSONINCHARGEID = pERSONINCHARGEID;
            this.�������� = ��������;
            this.������� = �������;
            this.���� = ����;
            this.Ա����� = Ա�����;
            this.ɾ����ʶ = ɾ����ʶ;
            this.����λ�� = ����λ��;
        }
        
        #region ʵ������
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
        /// <summary>
        /// MECHANISMID
        /// </summary>
        public int? MECHANISMID { get; set; }
        
        /// <summary>
        /// PERSONINCHARGEID
        /// </summary>
        public int? PERSONINCHARGEID { get; set; }
        
        /// <summary>
        /// ��������
        /// </summary>
        public string �������� { get; set; }
        
        /// <summary>
        /// �������
        /// </summary>
        public string ������� { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// Ա�����
        /// </summary>
        public string Ա����� { get; set; }
        
        /// <summary>
        /// ɾ����ʶ
        /// </summary>
        public bool? ɾ����ʶ { get; set; }
        
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
            Model.PersonInChargeView model = obj as Model.PersonInChargeView;
            if (model != null && model.PERSONID == this.PERSONID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return PERSONID.GetHashCode();
        }
    }
}
    