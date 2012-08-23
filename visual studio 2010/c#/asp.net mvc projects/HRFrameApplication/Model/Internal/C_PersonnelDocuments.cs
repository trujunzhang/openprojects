/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/2 10:11:36
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
    /// ʵ���� C_PersonnelDocuments���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_PersonnelDocuments : ICloneable
    {
        public C_PersonnelDocuments()
        { }
        
        /// <summary>
        /// ���캯�� C_PersonnelDocuments
        /// </summary>
        /// <param name="pERSONNELDOCUMENTSID">PERSONNELDOCUMENTSID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="���">���</param>
        /// <param name="������">������</param>
        /// <param name="������">������</param>
        /// <param name="�ؼ���">�ؼ���</param>
        /// <param name="���ϼ��">���ϼ��</param>
        /// <param name="����">����</param>
        public C_PersonnelDocuments(int? pERSONNELDOCUMENTSID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, string ���, string ������, string ������, string �ؼ���, string ���ϼ��, string ����)
        {
            this.PERSONNELDOCUMENTSID = pERSONNELDOCUMENTSID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.��� = ���;
            this.������ = ������;
            this.������ = ������;
            this.�ؼ��� = �ؼ���;
            this.���ϼ�� = ���ϼ��;
            this.���� = ����;
        }
        
        #region ʵ������
        /// <summary>
        /// PERSONNELDOCUMENTSID
        /// </summary>
        public int? PERSONNELDOCUMENTSID { get; set; }
        
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
        /// ���
        /// </summary>
        public string ��� { get; set; }
        
        /// <summary>
        /// ������
        /// </summary>
        public string ������ { get; set; }
        
        /// <summary>
        /// ������
        /// </summary>
        public string ������ { get; set; }
        
        /// <summary>
        /// �ؼ���
        /// </summary>
        public string �ؼ��� { get; set; }
        
        /// <summary>
        /// ���ϼ��
        /// </summary>
        public string ���ϼ�� { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_PersonnelDocuments model = obj as Model.C_PersonnelDocuments;
            if (model != null && model.PERSONNELDOCUMENTSID == this.PERSONNELDOCUMENTSID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return PERSONNELDOCUMENTSID.GetHashCode();
        }
    }
}
    