/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/26 10:36:49
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
    /// ʵ���� C_Position���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_Position : ICloneable
    {
        public C_Position()
        { }
        
        /// <summary>
        /// ���캯�� C_Position
        /// </summary>
        /// <param name="pOSITIONID">POSITIONID</param>
        /// <param name="dEPARTMENTID">DEPARTMENTID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="ְλ����">ְλ����</param>
        /// <param name="�Ƿ��Ź���ְλ">�Ƿ��Ź���ְλ</param>
        /// <param name="��������">��������</param>
        /// <param name="ְλ����">ְλ����</param>
        /// <param name="����ְ��">����ְ��</param>
        /// <param name="��ְҪ��">��ְҪ��</param>
        /// <param name="����ʱ��">����ʱ��</param>
        public C_Position(int? pOSITIONID, int? dEPARTMENTID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, string ְλ����, bool? �Ƿ��Ź���ְλ, int? ��������, string ְλ����, string ����ְ��, string ��ְҪ��, DateTime? ����ʱ��)
        {
            this.POSITIONID = pOSITIONID;
            this.DEPARTMENTID = dEPARTMENTID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.ְλ���� = ְλ����;
            this.�Ƿ��Ź���ְλ = �Ƿ��Ź���ְλ;
            this.�������� = ��������;
            this.ְλ���� = ְλ����;
            this.����ְ�� = ����ְ��;
            this.��ְҪ�� = ��ְҪ��;
            this.����ʱ�� = ����ʱ��;
        }
        
        #region ʵ������
        /// <summary>
        /// POSITIONID
        /// </summary>
        public int? POSITIONID { get; set; }
        
        /// <summary>
        /// DEPARTMENTID
        /// </summary>
        public int? DEPARTMENTID { get; set; }
        
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
        /// ְλ����
        /// </summary>
        public string ְλ���� { get; set; }
        
        /// <summary>
        /// �Ƿ��Ź���ְλ
        /// </summary>
        public bool? �Ƿ��Ź���ְλ { get; set; }
        
        /// <summary>
        /// ��������
        /// </summary>
        public int? �������� { get; set; }
        
        /// <summary>
        /// ְλ����
        /// </summary>
        public string ְλ���� { get; set; }
        
        /// <summary>
        /// ����ְ��
        /// </summary>
        public string ����ְ�� { get; set; }
        
        /// <summary>
        /// ��ְҪ��
        /// </summary>
        public string ��ְҪ�� { get; set; }
        
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? ����ʱ�� { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Position model = obj as Model.C_Position;
            if (model != null && model.POSITIONID == this.POSITIONID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return POSITIONID.GetHashCode();
        }
    }
}
    