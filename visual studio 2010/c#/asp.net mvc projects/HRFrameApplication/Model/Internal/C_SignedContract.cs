/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/29 21:59:12
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
    /// 实体类 C_SignedContract，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_SignedContract : ICloneable
    {
        public C_SignedContract()
        { }
        
        /// <summary>
        /// 构造函数 C_SignedContract
        /// </summary>
        /// <param name="sIGNDCONTRACTID">SIGNDCONTRACTID</param>
        /// <param name="oFFICEID">OFFICEID</param>
        /// <param name="cONTRACTID">CONTRACTID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        public C_SignedContract(int? sIGNDCONTRACTID, int? oFFICEID, int? cONTRACTID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间)
        {
            this.SIGNDCONTRACTID = sIGNDCONTRACTID;
            this.OFFICEID = oFFICEID;
            this.CONTRACTID = cONTRACTID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
        }
        
        #region 实体属性
        /// <summary>
        /// SIGNDCONTRACTID
        /// </summary>
        public int? SIGNDCONTRACTID { get; set; }
        
        /// <summary>
        /// OFFICEID
        /// </summary>
        public int? OFFICEID { get; set; }
        
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
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_SignedContract model = obj as Model.C_SignedContract;
            if (model != null && model.SIGNDCONTRACTID == this.SIGNDCONTRACTID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return SIGNDCONTRACTID.GetHashCode();
        }
    }
}
    