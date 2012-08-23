/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/19 14:22:21
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
    /// 实体类 C_Department，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_Department : ICloneable
    {
        public C_Department()
        { }
        
        /// <summary>
        /// 构造函数 C_Department
        /// </summary>
        /// <param name="dEPARTMENTID">DEPARTMENTID</param>
        /// <param name="c_D_DEPARTMENTID">C_D_DEPARTMENTID</param>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="部门简称">部门简称</param>
        /// <param name="部门名称">部门名称</param>
        /// <param name="电话">电话</param>
        /// <param name="邮政编码">邮政编码</param>
        /// <param name="网址">网址</param>
        /// <param name="传真">传真</param>
        /// <param name="地址">地址</param>
        public C_Department(int? dEPARTMENTID, int? c_D_DEPARTMENTID, int? mECHANISMID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, string 部门简称, string 部门名称, string 电话, string 邮政编码, string 网址, string 传真, string 地址)
        {
            this.DEPARTMENTID = dEPARTMENTID;
            this.C_D_DEPARTMENTID = c_D_DEPARTMENTID;
            this.MECHANISMID = mECHANISMID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.部门简称 = 部门简称;
            this.部门名称 = 部门名称;
            this.电话 = 电话;
            this.邮政编码 = 邮政编码;
            this.网址 = 网址;
            this.传真 = 传真;
            this.地址 = 地址;
        }
        
        #region 实体属性
        /// <summary>
        /// DEPARTMENTID
        /// </summary>
        public int? DEPARTMENTID { get; set; }
        
        /// <summary>
        /// C_D_DEPARTMENTID
        /// </summary>
        public int? C_D_DEPARTMENTID { get; set; }
        
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
        /// 部门简称
        /// </summary>
        public string 部门简称 { get; set; }
        
        /// <summary>
        /// 部门名称
        /// </summary>
        public string 部门名称 { get; set; }
        
        /// <summary>
        /// 电话
        /// </summary>
        public string 电话 { get; set; }
        
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string 邮政编码 { get; set; }
        
        /// <summary>
        /// 网址
        /// </summary>
        public string 网址 { get; set; }
        
        /// <summary>
        /// 传真
        /// </summary>
        public string 传真 { get; set; }
        
        /// <summary>
        /// 地址
        /// </summary>
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
            Model.C_Department model = obj as Model.C_Department;
            if (model != null && model.DEPARTMENTID == this.DEPARTMENTID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return DEPARTMENTID.GetHashCode();
        }
    }
}
    