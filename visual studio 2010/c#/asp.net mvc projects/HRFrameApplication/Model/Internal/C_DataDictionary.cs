/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/30 15:07:38
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
    /// ʵ���� C_DataDictionary���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_DataDictionary : ICloneable
    {
        public C_DataDictionary()
        { }
        
        /// <summary>
        /// ���캯�� C_DataDictionary
        /// </summary>
        /// <param name="dATADICTIONARY_ID">DATADICTIONARY_ID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="���˵����">���˵����</param>
        /// <param name="�Ӳ˵����">�Ӳ˵����</param>
        /// <param name="�ֵ�����">�ֵ�����</param>
        /// <param name="�ֵ�����">�ֵ�����</param>
        public C_DataDictionary(int? dATADICTIONARY_ID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, string ���˵����, string �Ӳ˵����, string �ֵ�����, byte[] �ֵ�����)
        {
            this.DATADICTIONARY_ID = dATADICTIONARY_ID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.���˵���� = ���˵����;
            this.�Ӳ˵���� = �Ӳ˵����;
            this.�ֵ����� = �ֵ�����;
            this.�ֵ����� = �ֵ�����;
        }
        
        #region ʵ������
        /// <summary>
        /// DATADICTIONARY_ID
        /// </summary>
        public int? DATADICTIONARY_ID { get; set; }
        
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
        /// ���˵����
        /// </summary>
        public string ���˵���� { get; set; }
        
        /// <summary>
        /// �Ӳ˵����
        /// </summary>
        public string �Ӳ˵���� { get; set; }
        
        /// <summary>
        /// �ֵ�����
        /// </summary>
        public string �ֵ����� { get; set; }
        
        /// <summary>
        /// �ֵ�����
        /// </summary>
        public byte[] �ֵ����� { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_DataDictionary model = obj as Model.C_DataDictionary;
            if (model != null && model.DATADICTIONARY_ID == this.DATADICTIONARY_ID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return DATADICTIONARY_ID.GetHashCode();
        }
    }
}
    