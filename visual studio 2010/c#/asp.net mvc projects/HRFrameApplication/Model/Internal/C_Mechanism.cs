/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/2 10:11:35
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Model
{
    /// <summary>
    /// ʵ���� C_Mechanism���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_Mechanism : ICloneable
    {
        public C_Mechanism()
        { }
        
        /// <summary>
        /// ���캯�� C_Mechanism
        /// </summary>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="�������">�������</param>
        /// <param name="��������">��������</param>
        /// <param name="�绰">�绰</param>
        /// <param name="��������">��������</param>
        /// <param name="��ַ">��ַ</param>
        /// <param name="����">����</param>
        /// <param name="��ַ">��ַ</param>
        public C_Mechanism(int? mECHANISMID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, string �������, string ��������, string �绰, string ��������, string ��ַ, string ����, string ��ַ)
        {
            this.MECHANISMID = mECHANISMID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.������� = �������;
            this.�������� = ��������;
            this.�绰 = �绰;
            this.�������� = ��������;
            this.��ַ = ��ַ;
            this.���� = ����;
            this.��ַ = ��ַ;
        }
        
        #region ʵ������
        /// <summary>
        /// MECHANISMID
        /// </summary>
        [ScaffoldColumn(false)]        
        public int? MECHANISMID { get; set; }
        
        /// <summary>
        /// ɾ����ʶ
        /// </summary>
        [ScaffoldColumn(false)]
        public bool? ɾ����ʶ { get; set; }
        
        /// <summary>
        /// ������
        /// </summary>
        [ScaffoldColumn(false)]
        public string ������ { get; set; }
        
        /// <summary>
        /// ������ʱ��
        /// </summary>
        [ScaffoldColumn(false)]
        public DateTime? ������ʱ�� { get; set; }
        
        /// <summary>
        /// �޸���
        /// </summary>
        [ScaffoldColumn(false)]
        public string �޸��� { get; set; }
        
        /// <summary>
        /// �޸���ʱ��
        /// </summary>
        [ScaffoldColumn(false)]
        public DateTime? �޸���ʱ�� { get; set; }
        
        /// <summary>
        /// �������
        /// </summary>
        [DisplayName("�������")]
        [Required(ErrorMessage = "����")]
        [StringLength(12, ErrorMessage = "���𳬹�12����")]
        public string ������� { get; set; }
        
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("��������")]
        [Required(ErrorMessage = "����")]
        //[Compare("�������", ErrorMessage = "The new password and confirmation password do not match.")]
        public string �������� { get; set; }
        
        /// <summary>
        /// �绰
        /// </summary>
        [DisplayName("�绰")]
        public string �绰 { get; set; }
        
        /// <summary>
        /// ��������
        /// </summary>
        [DisplayName("��������")]
        public string �������� { get; set; }
        
        /// <summary>
        /// ��ַ
        /// </summary>
        [DisplayName("��ַ")]
        public string ��ַ { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        [DisplayName("����")]
        public string ���� { get; set; }
        
        /// <summary>
        /// ��ַ
        /// </summary>
        [DisplayName("��ַ")]
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
            Model.C_Mechanism model = obj as Model.C_Mechanism;
            if (model != null && model.MECHANISMID == this.MECHANISMID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return MECHANISMID.GetHashCode();
        }
    }
}
    