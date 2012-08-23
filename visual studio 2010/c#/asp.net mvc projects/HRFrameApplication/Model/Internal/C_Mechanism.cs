/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/2 10:11:35
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Model
{
    /// <summary>
    /// 实体类 C_Mechanism，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_Mechanism : ICloneable
    {
        public C_Mechanism()
        { }
        
        /// <summary>
        /// 构造函数 C_Mechanism
        /// </summary>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="机构简称">机构简称</param>
        /// <param name="机构名称">机构名称</param>
        /// <param name="电话">电话</param>
        /// <param name="邮政编码">邮政编码</param>
        /// <param name="网址">网址</param>
        /// <param name="传真">传真</param>
        /// <param name="地址">地址</param>
        public C_Mechanism(int? mECHANISMID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, string 机构简称, string 机构名称, string 电话, string 邮政编码, string 网址, string 传真, string 地址)
        {
            this.MECHANISMID = mECHANISMID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.机构简称 = 机构简称;
            this.机构名称 = 机构名称;
            this.电话 = 电话;
            this.邮政编码 = 邮政编码;
            this.网址 = 网址;
            this.传真 = 传真;
            this.地址 = 地址;
        }
        
        #region 实体属性
        /// <summary>
        /// MECHANISMID
        /// </summary>
        [ScaffoldColumn(false)]        
        public int? MECHANISMID { get; set; }
        
        /// <summary>
        /// 删除标识
        /// </summary>
        [ScaffoldColumn(false)]
        public bool? 删除标识 { get; set; }
        
        /// <summary>
        /// 创建者
        /// </summary>
        [ScaffoldColumn(false)]
        public string 创建者 { get; set; }
        
        /// <summary>
        /// 创建人时间
        /// </summary>
        [ScaffoldColumn(false)]
        public DateTime? 创建人时间 { get; set; }
        
        /// <summary>
        /// 修改者
        /// </summary>
        [ScaffoldColumn(false)]
        public string 修改者 { get; set; }
        
        /// <summary>
        /// 修改人时间
        /// </summary>
        [ScaffoldColumn(false)]
        public DateTime? 修改人时间 { get; set; }
        
        /// <summary>
        /// 机构简称
        /// </summary>
        [DisplayName("机构简称")]
        [Required(ErrorMessage = "必须")]
        [StringLength(12, ErrorMessage = "请勿超过12个字")]
        public string 机构简称 { get; set; }
        
        /// <summary>
        /// 机构名称
        /// </summary>
        [DisplayName("机构名称")]
        [Required(ErrorMessage = "必须")]
        //[Compare("机构简称", ErrorMessage = "The new password and confirmation password do not match.")]
        public string 机构名称 { get; set; }
        
        /// <summary>
        /// 电话
        /// </summary>
        [DisplayName("电话")]
        public string 电话 { get; set; }
        
        /// <summary>
        /// 邮政编码
        /// </summary>
        [DisplayName("邮政编码")]
        public string 邮政编码 { get; set; }
        
        /// <summary>
        /// 网址
        /// </summary>
        [DisplayName("网址")]
        public string 网址 { get; set; }
        
        /// <summary>
        /// 传真
        /// </summary>
        [DisplayName("传真")]
        public string 传真 { get; set; }
        
        /// <summary>
        /// 地址
        /// </summary>
        [DisplayName("地址")]
        public string 地址 { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Mechanism model = obj as Model.C_Mechanism;
            if (model != null && model.MECHANISMID == this.MECHANISMID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return MECHANISMID.GetHashCode();
        }
    }
}
    