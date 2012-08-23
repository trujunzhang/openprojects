/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/23 15:19:45
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
    /// ʵ���� C_Office���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_Office : ICloneable
    {
        public C_Office()
        { }
        
        /// <summary>
        /// ���캯�� C_Office
        /// </summary>
        /// <param name="oFFICEID">OFFICEID</param>
        /// <param name="pOSITIONID">POSITIONID</param>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="�Ƿ���ְ">�Ƿ���ְ</param>
        /// <param name="��ְ��ʶ">��ְ��ʶ</param>
        public C_Office(int? oFFICEID, int? pOSITIONID, int? pERSONID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, bool? �Ƿ���ְ, DateTime? ��ְ��ʶ)
        {
            this.OFFICEID = oFFICEID;
            this.POSITIONID = pOSITIONID;
            this.PERSONID = pERSONID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.�Ƿ���ְ = �Ƿ���ְ;
            this.��ְ��ʶ = ��ְ��ʶ;
        }
        
        #region ʵ������
        /// <summary>
        /// OFFICEID
        /// </summary>
        public int? OFFICEID { get; set; }
        
        /// <summary>
        /// POSITIONID
        /// </summary>
        public int? POSITIONID { get; set; }
        
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
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
        /// �Ƿ���ְ
        /// </summary>
        public bool? �Ƿ���ְ { get; set; }
        
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
            Model.C_Office model = obj as Model.C_Office;
            if (model != null && model.OFFICEID == this.OFFICEID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return OFFICEID.GetHashCode();
        }
    }
}
    