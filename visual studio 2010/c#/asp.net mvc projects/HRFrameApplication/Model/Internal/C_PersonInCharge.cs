/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/20 15:42:06
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
    /// 实体类 C_PersonInCharge，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_PersonInCharge : ICloneable
    {
        public C_PersonInCharge()
        { }
        
        /// <summary>
        /// 构造函数 C_PersonInCharge
        /// </summary>
        /// <param name="pERSONINCHARGEID">PERSONINCHARGEID</param>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="排序位置">排序位置</param>
        public C_PersonInCharge(int? pERSONINCHARGEID, int? pERSONID, int? mECHANISMID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, int? 排序位置)
        {
            this.PERSONINCHARGEID = pERSONINCHARGEID;
            this.PERSONID = pERSONID;
            this.MECHANISMID = mECHANISMID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.排序位置 = 排序位置;
        }
        
        #region 实体属性
        /// <summary>
        /// PERSONINCHARGEID
        /// </summary>
        public int? PERSONINCHARGEID { get; set; }
        
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
        /// <summary>
        /// MECHANISMID
        /// </summary>
        public int? MECHANISMID { get; set; }
        
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
        /// 排序位置
        /// </summary>
        public int? 排序位置 { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_PersonInCharge model = obj as Model.C_PersonInCharge;
            if (model != null && model.PERSONINCHARGEID == this.PERSONINCHARGEID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return PERSONINCHARGEID.GetHashCode();
        }
    }
}
    