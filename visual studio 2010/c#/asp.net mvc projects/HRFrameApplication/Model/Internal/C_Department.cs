/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/19 14:22:21
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
    /// ʵ���� C_Department���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_Department : ICloneable
    {
        public C_Department()
        { }
        
        /// <summary>
        /// ���캯�� C_Department
        /// </summary>
        /// <param name="dEPARTMENTID">DEPARTMENTID</param>
        /// <param name="c_D_DEPARTMENTID">C_D_DEPARTMENTID</param>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="���ż��">���ż��</param>
        /// <param name="��������">��������</param>
        /// <param name="�绰">�绰</param>
        /// <param name="��������">��������</param>
        /// <param name="��ַ">��ַ</param>
        /// <param name="����">����</param>
        /// <param name="��ַ">��ַ</param>
        public C_Department(int? dEPARTMENTID, int? c_D_DEPARTMENTID, int? mECHANISMID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, string ���ż��, string ��������, string �绰, string ��������, string ��ַ, string ����, string ��ַ)
        {
            this.DEPARTMENTID = dEPARTMENTID;
            this.C_D_DEPARTMENTID = c_D_DEPARTMENTID;
            this.MECHANISMID = mECHANISMID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.���ż�� = ���ż��;
            this.�������� = ��������;
            this.�绰 = �绰;
            this.�������� = ��������;
            this.��ַ = ��ַ;
            this.���� = ����;
            this.��ַ = ��ַ;
        }
        
        #region ʵ������
        /// <summary>
        /// DEPARTMENTID
        /// </summary>
        public int? DEPARTMENTID { get; set; }
        
        /// <summary>
        /// C_D_DEPARTMENTID
        /// </summary>
        public int? C_D_DEPARTMENTID { get; set; }
        
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
        /// ���ż��
        /// </summary>
        public string ���ż�� { get; set; }
        
        /// <summary>
        /// ��������
        /// </summary>
        public string �������� { get; set; }
        
        /// <summary>
        /// �绰
        /// </summary>
        public string �绰 { get; set; }
        
        /// <summary>
        /// ��������
        /// </summary>
        public string �������� { get; set; }
        
        /// <summary>
        /// ��ַ
        /// </summary>
        public string ��ַ { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// ��ַ
        /// </summary>
        public string ��ַ { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Department model = obj as Model.C_Department;
            if (model != null && model.DEPARTMENTID == this.DEPARTMENTID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return DEPARTMENTID.GetHashCode();
        }
    }
}
    