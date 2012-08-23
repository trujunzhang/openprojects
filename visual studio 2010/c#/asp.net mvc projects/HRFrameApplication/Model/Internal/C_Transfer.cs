/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/23 8:38:39
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
    /// ʵ���� C_Transfer���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_Transfer : ICloneable
    {
        public C_Transfer()
        { }
        
        /// <summary>
        /// ���캯�� C_Transfer
        /// </summary>
        /// <param name="tRANSFERID">TRANSFERID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="Ա��ID">Ա��ID</param>
        /// <param name="ԭְλ">ԭְλ</param>
        /// <param name="��ְλ">��ְλ</param>
        /// <param name="����ԭ��">����ԭ��</param>
        public C_Transfer(int? tRANSFERID, int? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, int? Ա��ID, int? ԭְλ, int? ��ְλ, string ����ԭ��)
        {
            this.TRANSFERID = tRANSFERID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.Ա��ID = Ա��ID;
            this.ԭְλ = ԭְλ;
            this.��ְλ = ��ְλ;
            this.����ԭ�� = ����ԭ��;
        }
        
        #region ʵ������
        /// <summary>
        /// TRANSFERID
        /// </summary>
        public int? TRANSFERID { get; set; }
        
        /// <summary>
        /// ɾ����ʶ
        /// </summary>
        public int? ɾ����ʶ { get; set; }
        
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
        /// Ա��ID
        /// </summary>
        public int? Ա��ID { get; set; }
        
        /// <summary>
        /// ԭְλ
        /// </summary>
        public int? ԭְλ { get; set; }
        
        /// <summary>
        /// ��ְλ
        /// </summary>
        public int? ��ְλ { get; set; }
        
        /// <summary>
        /// ����ԭ��
        /// </summary>
        public string ����ԭ�� { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Transfer model = obj as Model.C_Transfer;
            if (model != null && model.TRANSFERID == this.TRANSFERID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return TRANSFERID.GetHashCode();
        }
    }
}
    