/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/23 8:38:39
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
    /// 实体类 C_Transfer，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_Transfer : ICloneable
    {
        public C_Transfer()
        { }
        
        /// <summary>
        /// 构造函数 C_Transfer
        /// </summary>
        /// <param name="tRANSFERID">TRANSFERID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="员工ID">员工ID</param>
        /// <param name="原职位">原职位</param>
        /// <param name="现职位">现职位</param>
        /// <param name="调动原因">调动原因</param>
        public C_Transfer(int? tRANSFERID, int? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, int? 员工ID, int? 原职位, int? 现职位, string 调动原因)
        {
            this.TRANSFERID = tRANSFERID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.员工ID = 员工ID;
            this.原职位 = 原职位;
            this.现职位 = 现职位;
            this.调动原因 = 调动原因;
        }
        
        #region 实体属性
        /// <summary>
        /// TRANSFERID
        /// </summary>
        public int? TRANSFERID { get; set; }
        
        /// <summary>
        /// 删除标识
        /// </summary>
        public int? 删除标识 { get; set; }
        
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
        /// 员工ID
        /// </summary>
        public int? 员工ID { get; set; }
        
        /// <summary>
        /// 原职位
        /// </summary>
        public int? 原职位 { get; set; }
        
        /// <summary>
        /// 现职位
        /// </summary>
        public int? 现职位 { get; set; }
        
        /// <summary>
        /// 调动原因
        /// </summary>
        public string 调动原因 { get; set; }
        #endregion
    
        #region ICloneable 成员
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
    