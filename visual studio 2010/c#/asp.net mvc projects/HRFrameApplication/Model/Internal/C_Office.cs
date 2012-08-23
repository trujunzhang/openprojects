/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/23 15:19:45
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
    /// 实体类 C_Office，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_Office : ICloneable
    {
        public C_Office()
        { }
        
        /// <summary>
        /// 构造函数 C_Office
        /// </summary>
        /// <param name="oFFICEID">OFFICEID</param>
        /// <param name="pOSITIONID">POSITIONID</param>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="是否主职">是否主职</param>
        /// <param name="任职标识">任职标识</param>
        public C_Office(int? oFFICEID, int? pOSITIONID, int? pERSONID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, bool? 是否主职, DateTime? 任职标识)
        {
            this.OFFICEID = oFFICEID;
            this.POSITIONID = pOSITIONID;
            this.PERSONID = pERSONID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.是否主职 = 是否主职;
            this.任职标识 = 任职标识;
        }
        
        #region 实体属性
        /// <summary>
        /// OFFICEID
        /// </summary>
        public int? OFFICEID { get; set; }
        
        /// <summary>
        /// POSITIONID
        /// </summary>
        public int? POSITIONID { get; set; }
        
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
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
        /// 是否主职
        /// </summary>
        public bool? 是否主职 { get; set; }
        
        /// <summary>
        /// 任职标识
        /// </summary>
        public DateTime? 任职标识 { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Office model = obj as Model.C_Office;
            if (model != null && model.OFFICEID == this.OFFICEID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return OFFICEID.GetHashCode();
        }
    }
}
    