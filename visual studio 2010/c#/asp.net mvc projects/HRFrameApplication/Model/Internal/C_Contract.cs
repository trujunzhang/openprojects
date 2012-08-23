/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/26 9:27:32
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;

namespace Model
{
    /// <summary>
    /// 实体类 C_Contract，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_Contract : ICloneable
    {
        public C_Contract()
        { }
        
        /// <summary>
        /// 构造函数 C_Contract
        /// </summary>
        /// <param name="cONTRACTID">CONTRACTID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="证件号码">证件号码</param>
        /// <param name="合同编号">合同编号</param>
        /// <param name="合同名称">合同名称</param>
        /// <param name="合同类型">合同类型</param>
        /// <param name="合同状态">合同状态</param>
        /// <param name="合同期限">合同期限</param>
        /// <param name="开始时间">开始时间</param>
        /// <param name="截至时间">截至时间</param>
        /// <param name="合同内容">合同内容</param>
        /// <param name="合同附件">合同附件</param>
        public C_Contract(int? cONTRACTID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, string 证件号码, string 合同编号, string 合同名称, string 合同类型, string 合同状态, string 合同期限, DateTime? 开始时间, DateTime? 截至时间, string 合同内容, string 合同附件)
        {
            this.CONTRACTID = cONTRACTID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.证件号码 = 证件号码;
            this.合同编号 = 合同编号;
            this.合同名称 = 合同名称;
            this.合同类型 = 合同类型;
            this.合同状态 = 合同状态;
            this.合同期限 = 合同期限;
            this.开始时间 = 开始时间;
            this.截至时间 = 截至时间;
            this.合同内容 = 合同内容;
            this.合同附件 = 合同附件;
        }
        
        #region 实体属性
        /// <summary>
        /// CONTRACTID
        /// </summary>
        public int? CONTRACTID { get; set; }
        
        /// <summary>
        /// 删除标识
        /// </summary>
        public bool? 删除标识 { get; set; }
        
        /// <summary>
        /// 创建者
        /// </summary>
        public string 创建者 { get; set; }
        
        /// <summary>
        /// 创建人时间
        /// </summary>
        public DateTime? 创建人时间 { get; set; }
        
        /// <summary>
        /// 修改者
        /// </summary>
        public string 修改者 { get; set; }
        
        /// <summary>
        /// 修改人时间
        /// </summary>
        public DateTime? 修改人时间 { get; set; }
        
        /// <summary>
        /// 证件号码
        /// </summary>
        public string 证件号码 { get; set; }
        
        /// <summary>
        /// 合同编号
        /// </summary>
        public string 合同编号 { get; set; }
        
        /// <summary>
        /// 合同名称
        /// </summary>
        public string 合同名称 { get; set; }
        
        /// <summary>
        /// 合同类型
        /// </summary>
        public string 合同类型 { get; set; }
        
        /// <summary>
        /// 合同状态
        /// </summary>
        public string 合同状态 { get; set; }
        
        /// <summary>
        /// 合同期限
        /// </summary>
        public string 合同期限 { get; set; }
        
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? 开始时间 { get; set; }
        
        /// <summary>
        /// 截至时间
        /// </summary>
        public DateTime? 截至时间 { get; set; }
        
        /// <summary>
        /// 合同内容
        /// </summary>
        public string 合同内容 { get; set; }
        
        /// <summary>
        /// 合同附件
        /// </summary>
        public string 合同附件 { get; set; }
        #endregion
    
        #region ICloneable 成员
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
    