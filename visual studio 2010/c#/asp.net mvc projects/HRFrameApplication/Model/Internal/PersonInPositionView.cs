/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.5.0.0 自动创建于 2012/7/2 11:20:22
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
    /// 实体类 PersonInPositionView，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class PersonInPositionView : ICloneable
    {
        public PersonInPositionView()
        { }
        
        /// <summary>
        /// 构造函数 PersonInPositionView
        /// </summary>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="pOSITIONID">POSITIONID</param>
        /// <param name="oFFICEID">OFFICEID</param>
        /// <param name="mECHANISMID">MECHANISMID</param>
        /// <param name="dEPARTMENTID">DEPARTMENTID</param>
        /// <param name="姓名">姓名</param>
        /// <param name="员工编号">员工编号</param>
        /// <param name="在职状态">在职状态</param>
        /// <param name="是否主职">是否主职</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="任职标识">任职标识</param>
        public PersonInPositionView(int? pERSONID, int? pOSITIONID, int? oFFICEID, int? mECHANISMID, int? dEPARTMENTID, string 姓名, string 员工编号, string 在职状态, bool? 是否主职, bool? 删除标识, DateTime? 任职标识)
        {
            this.PERSONID = pERSONID;
            this.POSITIONID = pOSITIONID;
            this.OFFICEID = oFFICEID;
            this.MECHANISMID = mECHANISMID;
            this.DEPARTMENTID = dEPARTMENTID;
            this.姓名 = 姓名;
            this.员工编号 = 员工编号;
            this.在职状态 = 在职状态;
            this.是否主职 = 是否主职;
            this.删除标识 = 删除标识;
            this.任职标识 = 任职标识;
        }
        
        #region 实体属性
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
        /// <summary>
        /// POSITIONID
        /// </summary>
        public int? POSITIONID { get; set; }
        
        /// <summary>
        /// OFFICEID
        /// </summary>
        public int? OFFICEID { get; set; }
        
        /// <summary>
        /// MECHANISMID
        /// </summary>
        public int? MECHANISMID { get; set; }
        
        /// <summary>
        /// DEPARTMENTID
        /// </summary>
        public int? DEPARTMENTID { get; set; }
        
        /// <summary>
        /// 姓名
        /// </summary>
        public string 姓名 { get; set; }
        
        /// <summary>
        /// 员工编号
        /// </summary>
        public string 员工编号 { get; set; }
        
        /// <summary>
        /// 在职状态
        /// </summary>
        public string 在职状态 { get; set; }
        
        /// <summary>
        /// 是否主职
        /// </summary>
        public bool? 是否主职 { get; set; }
        
        /// <summary>
        /// 删除标识
        /// </summary>
        public bool? 删除标识 { get; set; }
        
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
            Model.PersonInPositionView model = obj as Model.PersonInPositionView;
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
    