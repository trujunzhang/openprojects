/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/6 9:56:56
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
    /// ʵ���� C_Person���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    [Serializable]
    public partial class C_Person : ICloneable
    {
        public C_Person()
        { }
        
        /// <summary>
        /// ���캯�� C_Person
        /// </summary>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="ɾ����ʶ">ɾ����ʶ</param>
        /// <param name="������">������</param>
        /// <param name="������ʱ��">������ʱ��</param>
        /// <param name="�޸���">�޸���</param>
        /// <param name="�޸���ʱ��">�޸���ʱ��</param>
        /// <param name="����">����</param>
        /// <param name="֤������">֤������</param>
        /// <param name="����">����</param>
        /// <param name="��¼�ʺ�">��¼�ʺ�</param>
        /// <param name="Ա�����">Ա�����</param>
        /// <param name="������">������</param>
        /// <param name="�Ա�">�Ա�</param>
        /// <param name="��������">��������</param>
        /// <param name="����">����</param>
        /// <param name="������">������</param>
        /// <param name="����">����</param>
        /// <param name="����">����</param>
        /// <param name="��������">��������</param>
        /// <param name="����״��">����״��</param>
        /// <param name="Ա�����">Ա�����</param>
        /// <param name="����">����</param>
        /// <param name="֤������">֤������</param>
        /// <param name="������ò">������ò</param>
        /// <param name="����״��">����״��</param>
        /// <param name="���">���</param>
        /// <param name="����">����</param>
        /// <param name="����">����</param>
        /// <param name="���ѧ��">���ѧ��</param>
        /// <param name="���ѧλ">���ѧλ</param>
        /// <param name="רҵ">רҵ</param>
        /// <param name="ְ��">ְ��</param>
        /// <param name="��ҵԺУ">��ҵԺУ</param>
        /// <param name="��ע">��ע</param>
        /// <param name="��ְ״̬">��ְ״̬</param>
        public C_Person(int? pERSONID, bool? ɾ����ʶ, string ������, DateTime? ������ʱ��, string �޸���, DateTime? �޸���ʱ��, string ����, string ֤������, string ����, string ��¼�ʺ�, string Ա�����, string ������, string �Ա�, DateTime? ��������, string ����, string ������, string ����, string ����, string ��������, bool? ����״��, string Ա�����, string ����, string ֤������, string ������ò, string ����״��, double? ���, double? ����, double? ����, string ���ѧ��, string ���ѧλ, string רҵ, string ְ��, string ��ҵԺУ, string ��ע, string ��ְ״̬)
        {
            this.PERSONID = pERSONID;
            this.ɾ����ʶ = ɾ����ʶ;
            this.������ = ������;
            this.������ʱ�� = ������ʱ��;
            this.�޸��� = �޸���;
            this.�޸���ʱ�� = �޸���ʱ��;
            this.���� = ����;
            this.֤������ = ֤������;
            this.���� = ����;
            this.��¼�ʺ� = ��¼�ʺ�;
            this.Ա����� = Ա�����;
            this.������ = ������;
            this.�Ա� = �Ա�;
            this.�������� = ��������;
            this.���� = ����;
            this.������ = ������;
            this.���� = ����;
            this.���� = ����;
            this.�������� = ��������;
            this.����״�� = ����״��;
            this.Ա����� = Ա�����;
            this.���� = ����;
            this.֤������ = ֤������;
            this.������ò = ������ò;
            this.����״�� = ����״��;
            this.��� = ���;
            this.���� = ����;
            this.���� = ����;
            this.���ѧ�� = ���ѧ��;
            this.���ѧλ = ���ѧλ;
            this.רҵ = רҵ;
            this.ְ�� = ְ��;
            this.��ҵԺУ = ��ҵԺУ;
            this.��ע = ��ע;
            this.��ְ״̬ = ��ְ״̬;
        }
        
        #region ʵ������
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
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// ֤������
        /// </summary>
        public string ֤������ { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// ��¼�ʺ�
        /// </summary>
        public string ��¼�ʺ� { get; set; }
        
        /// <summary>
        /// Ա�����
        /// </summary>
        public string Ա����� { get; set; }
        
        /// <summary>
        /// ������
        /// </summary>
        public string ������ { get; set; }
        
        /// <summary>
        /// �Ա�
        /// </summary>
        public string �Ա� { get; set; }
        
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? �������� { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// ������
        /// </summary>
        public string ������ { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// ��������
        /// </summary>
        public string �������� { get; set; }
        
        /// <summary>
        /// ����״��
        /// </summary>
        public bool? ����״�� { get; set; }
        
        /// <summary>
        /// Ա�����
        /// </summary>
        public string Ա����� { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public string ���� { get; set; }
        
        /// <summary>
        /// ֤������
        /// </summary>
        public string ֤������ { get; set; }
        
        /// <summary>
        /// ������ò
        /// </summary>
        public string ������ò { get; set; }
        
        /// <summary>
        /// ����״��
        /// </summary>
        public string ����״�� { get; set; }
        
        /// <summary>
        /// ���
        /// </summary>
        public double? ��� { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public double? ���� { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public double? ���� { get; set; }
        
        /// <summary>
        /// ���ѧ��
        /// </summary>
        public string ���ѧ�� { get; set; }
        
        /// <summary>
        /// ���ѧλ
        /// </summary>
        public string ���ѧλ { get; set; }
        
        /// <summary>
        /// רҵ
        /// </summary>
        public string רҵ { get; set; }
        
        /// <summary>
        /// ְ��
        /// </summary>
        public string ְ�� { get; set; }
        
        /// <summary>
        /// ��ҵԺУ
        /// </summary>
        public string ��ҵԺУ { get; set; }
        
        /// <summary>
        /// ��ע
        /// </summary>
        public string ��ע { get; set; }
        
        /// <summary>
        /// ��ְ״̬
        /// </summary>
        public string ��ְ״̬ { get; set; }
        #endregion
    
        #region ICloneable ��Ա
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Person model = obj as Model.C_Person;
            if (model != null && model.PERSONID == this.PERSONID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return PERSONID.GetHashCode();
        }
    }
}
    