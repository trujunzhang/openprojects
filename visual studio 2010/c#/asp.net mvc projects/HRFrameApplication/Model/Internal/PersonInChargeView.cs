/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.5.0.0 自动创建于 2012/6/22 9:14:51
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
    /// 实体类 PersonInChargeView，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class PersonInChargeView : ICloneable
    {
        public PersonInChargeView()
        { }
        
        /// <summary>
        /// 构造函数 PersonInChargeView
        /// </summary>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="pERSONINCHARGEID">PERSONINCHARGEID</param>
        /// <param name="机构名称">机构名称</param>
        /// <param name="机构简称">机构简称</param>
        /// <param name="姓名">姓名</param>
        /// <param name="员工编号">员工编号</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="排序位置">排序位置</param>
        public PersonInChargeView(int? pERSONID, int? mECHANISMID, int? pERSONINCHARGEID, string 机构名称, string 机构简称, string 姓名, string 员工编号, bool? 删除标识, int? 排序位置)
        {
            this.PERSONID = pERSONID;
            this.MECHANISMID = mECHANISMID;
            this.PERSONINCHARGEID = pERSONINCHARGEID;
            this.机构名称 = 机构名称;
            this.机构简称 = 机构简称;
            this.姓名 = 姓名;
            this.员工编号 = 员工编号;
            this.删除标识 = 删除标识;
            this.排序位置 = 排序位置;
        }
        
        #region 实体属性
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
        /// <summary>
        /// MECHANISMID
        /// </summary>
        public int? MECHANISMID { get; set; }
        
        /// <summary>
        /// PERSONINCHARGEID
        /// </summary>
        public int? PERSONINCHARGEID { get; set; }
        
        /// <summary>
        /// 机构名称
        /// </summary>
        public string 机构名称 { get; set; }
        
        /// <summary>
        /// 机构简称
        /// </summary>
        public string 机构简称 { get; set; }
        
        /// <summary>
        /// 姓名
        /// </summary>
        public string 姓名 { get; set; }
        
        /// <summary>
        /// 员工编号
        /// </summary>
        public string 员工编号 { get; set; }
        
        /// <summary>
        /// 删除标识
        /// </summary>
        public bool? 删除标识 { get; set; }
        
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
            Model.PersonInChargeView model = obj as Model.PersonInChargeView;
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
    