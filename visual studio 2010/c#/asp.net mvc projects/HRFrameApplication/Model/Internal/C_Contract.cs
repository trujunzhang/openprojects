/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/26 9:27:32
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
    /// ʵ���� C_Contract���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_Contract : ICloneable
    {
        public C_Contract()
        { }
        
        /// <summary>
        /// ���캯�� C_Contract
        /// </summary>
        /// <param name="cONTRACTID">CONTRACTID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="֤������">֤������</param>
        /// <param name="��ͬ���">��ͬ���</param>
        /// <param name="��ͬ����">��ͬ����</param>
        /// <param name="��ͬ����">��ͬ����</param>
        /// <param name="��ͬ״̬">��ͬ״̬</param>
        /// <param name="��ͬ����">��ͬ����</param>
        /// <param name="��ʼʱ��">��ʼʱ��</param>
        /// <param name="����ʱ��">����ʱ��</param>
        /// <param name="��ͬ����">��ͬ����</param>
        /// <param name="��ͬ����">��ͬ����</param>
        public C_Contract(int? cONTRACTID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, string ֤������, string ��ͬ���, string ��ͬ����, string ��ͬ����, string ��ͬ״̬, string ��ͬ����, DateTime? ��ʼʱ��, DateTime? ����ʱ��, string ��ͬ����, string ��ͬ����)
        {
            this.CONTRACTID = cONTRACTID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.֤������ = ֤������;
            this.��ͬ��� = ��ͬ���;
            this.��ͬ���� = ��ͬ����;
            this.��ͬ���� = ��ͬ����;
            this.��ͬ״̬ = ��ͬ״̬;
            this.��ͬ���� = ��ͬ����;
            this.��ʼʱ�� = ��ʼʱ��;
            this.����ʱ�� = ����ʱ��;
            this.��ͬ���� = ��ͬ����;
            this.��ͬ���� = ��ͬ����;
        }
        
        #region ʵ������
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
        
        /// <summary>
        /// ֤������
        /// </summary>
        public string ֤������ { get; set; }
        
        /// <summary>
        /// ��ͬ���
        /// </summary>
        public string ��ͬ��� { get; set; }
        
        /// <summary>
        /// ��ͬ����
        /// </summary>
        public string ��ͬ���� { get; set; }
        
        /// <summary>
        /// ��ͬ����
        /// </summary>
        public string ��ͬ���� { get; set; }
        
        /// <summary>
        /// ��ͬ״̬
        /// </summary>
        public string ��ͬ״̬ { get; set; }
        
        /// <summary>
        /// ��ͬ����
        /// </summary>
        public string ��ͬ���� { get; set; }
        
        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public DateTime? ��ʼʱ�� { get; set; }
        
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? ����ʱ�� { get; set; }
        
        /// <summary>
        /// ��ͬ����
        /// </summary>
        public string ��ͬ���� { get; set; }
        
        /// <summary>
        /// ��ͬ����
        /// </summary>
        public string ��ͬ���� { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Contract model = obj as Model.C_Contract;
            if (model != null && model.CONTRACTID == this.CONTRACTID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return CONTRACTID.GetHashCode();
        }
    }
}
    