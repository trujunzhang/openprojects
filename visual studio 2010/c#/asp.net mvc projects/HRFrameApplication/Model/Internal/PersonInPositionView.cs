/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.5.0.0 �Զ������� 2012/7/2 11:20:22
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
    /// ʵ���� PersonInPositionView���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class PersonInPositionView : ICloneable
    {
        public PersonInPositionView()
        { }
        
        /// <summary>
        /// ���캯�� PersonInPositionView
        /// </summary>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="pOSITIONID">POSITIONID</param>
        /// <param name="oFFICEID">OFFICEID</param>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="dEPARTMENTID">DEPARTMENTID</param>
        /// <param name="����">����</param>
        /// <param name="Ա�����">Ա�����</param>
        /// <param name="��ְ״̬">��ְ״̬</param>
        /// <param name="�Ƿ���ְ">�Ƿ���ְ</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="��ְ��ʶ">��ְ��ʶ</param>
        public PersonInPositionView(int? pERSONID, int? pOSITIONID, int? oFFICEID, int? mECHANISMID, int? dEPARTMENTID, string ����, string Ա�����, string ��ְ״̬, bool? �Ƿ���ְ, bool? ɾ����ʶ, DateTime? ��ְ��ʶ)
        {
            this.PERSONID = pERSONID;
            this.POSITIONID = pOSITIONID;
            this.OFFICEID = oFFICEID;
            this.MECHANISMID = mECHANISMID;
            this.DEPARTMENTID = dEPARTMENTID;
            this.���� = ����;
            this.Ա����� = Ա�����;
            this.��ְ״̬ = ��ְ״̬;
            this.�Ƿ���ְ = �Ƿ���ְ;
            this.ɾ����ʶ = ɾ����ʶ;
            this.��ְ��ʶ = ��ְ��ʶ;
        }
        
        #region ʵ������
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
        /// <summary>
        /// POSITIONID
        /// </summary>
        public int? POSITIONID { get; set; }
        
        /// <summary>
        /// OFFICEID
        /// </summary>
        public int? OFFICEID { get; set; }
        
        /// <summary>
        /// MECHANISMID
        /// </summary>
        public int? MECHANISMID { get; set; }
        
        /// <summary>
        /// DEPARTMENTID
        /// </summary>
        public int? DEPARTMENTID { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// Ա�����
        /// </summary>
        public string Ա����� { get; set; }
        
        /// <summary>
        /// ��ְ״̬
        /// </summary>
        public string ��ְ״̬ { get; set; }
        
        /// <summary>
        /// �Ƿ���ְ
        /// </summary>
        public bool? �Ƿ���ְ { get; set; }
        
        /// <summary>
        /// ɾ����ʶ
        /// </summary>
        public bool? ɾ����ʶ { get; set; }
        
        /// <summary>
        /// ��ְ��ʶ
        /// </summary>
        public DateTime? ��ְ��ʶ { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.PersonInPositionView model = obj as Model.PersonInPositionView;
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
    