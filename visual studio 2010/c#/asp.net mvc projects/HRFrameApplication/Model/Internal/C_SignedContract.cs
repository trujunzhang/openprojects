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

namespace Model
{
    /// <summary>
    /// ʵ���� C_SignedContract���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_SignedContract : ICloneable
    {
        public C_SignedContract()
        { }
        
        /// <summary>
        /// ���캯�� C_SignedContract
        /// </summary>
        /// <param name="sIGNDCONTRACTID">SIGNDCONTRACTID</param>
        /// <param name="oFFICEID">OFFICEID</param>
        /// <param name="cONTRACTID">CONTRACTID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        public C_SignedContract(int? sIGNDCONTRACTID, int? oFFICEID, int? cONTRACTID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��)
        {
            this.SIGNDCONTRACTID = sIGNDCONTRACTID;
            this.OFFICEID = oFFICEID;
            this.CONTRACTID = cONTRACTID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
        }
        
        #region ʵ������
        /// <summary>
        /// SIGNDCONTRACTID
        /// </summary>
        public int? SIGNDCONTRACTID { get; set; }
        
        /// <summary>
        /// OFFICEID
        /// </summary>
        public int? OFFICEID { get; set; }
        
        /// <summary>
        /// CONTRACTID
        /// </summary>
        public int? CONTRACTID { get; set; }
        
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
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_SignedContract model = obj as Model.C_SignedContract;
            if (model != null && model.SIGNDCONTRACTID == this.SIGNDCONTRACTID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return SIGNDCONTRACTID.GetHashCode();
        }
    }
}
    