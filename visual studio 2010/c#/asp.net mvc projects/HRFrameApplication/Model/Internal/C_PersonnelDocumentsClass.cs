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
    /// ʵ���� C_PersonnelDocumentsClass���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_PersonnelDocumentsClass : ICloneable
    {
        public C_PersonnelDocumentsClass()
        { }
        
        /// <summary>
        /// ���캯�� C_PersonnelDocumentsClass
        /// </summary>
        /// <param name="pERSONNELDOCUMENTSCLASSID">PERSONNELDOCUMENTSCLASSID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="�������">�������</param>
        /// <param name="�������">�������</param>
        /// <param name="Ȩ������">Ȩ������</param>
        public C_PersonnelDocumentsClass(int? pERSONNELDOCUMENTSCLASSID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, string �������, string �������, string Ȩ������)
        {
            this.PERSONNELDOCUMENTSCLASSID = pERSONNELDOCUMENTSCLASSID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.������� = �������;
            this.������� = �������;
            this.Ȩ������ = Ȩ������;
        }
        
        #region ʵ������
        /// <summary>
        /// PERSONNELDOCUMENTSCLASSID
        /// </summary>
        public int? PERSONNELDOCUMENTSCLASSID { get; set; }
        
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
        /// �������
        /// </summary>
        public string ������� { get; set; }
        
        /// <summary>
        /// �������
        /// </summary>
        public string ������� { get; set; }
        
        /// <summary>
        /// Ȩ������
        /// </summary>
        public string Ȩ������ { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_PersonnelDocumentsClass model = obj as Model.C_PersonnelDocumentsClass;
            if (model != null && model.PERSONNELDOCUMENTSCLASSID == this.PERSONNELDOCUMENTSCLASSID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return PERSONNELDOCUMENTSCLASSID.GetHashCode();
        }
    }
}
    