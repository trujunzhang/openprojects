/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/26 10:36:49
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
    /// 实体类 C_Position，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_Position : ICloneable
    {
        public C_Position()
        { }
        
        /// <summary>
        /// 构造函数 C_Position
        /// </summary>
        /// <param name="pOSITIONID">POSITIONID</param>
        /// <param name="dEPARTMENTID">DEPARTMENTID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="职位名称">职位名称</param>
        /// <param name="是否部门管理职位">是否部门管理职位</param>
        /// <param name="编制人数">编制人数</param>
        /// <param name="职位描述">职位描述</param>
        /// <param name="工作职责">工作职责</param>
        /// <param name="任职要求">任职要求</param>
        /// <param name="排序时间">排序时间</param>
        public C_Position(int? pOSITIONID, int? dEPARTMENTID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, string 职位名称, bool? 是否部门管理职位, int? 编制人数, string 职位描述, string 工作职责, string 任职要求, DateTime? 排序时间)
        {
            this.POSITIONID = pOSITIONID;
            this.DEPARTMENTID = dEPARTMENTID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.职位名称 = 职位名称;
            this.是否部门管理职位 = 是否部门管理职位;
            this.编制人数 = 编制人数;
            this.职位描述 = 职位描述;
            this.工作职责 = 工作职责;
            this.任职要求 = 任职要求;
            this.排序时间 = 排序时间;
        }
        
        #region 实体属性
        /// <summary>
        /// POSITIONID
        /// </summary>
        public int? POSITIONID { get; set; }
        
        /// <summary>
        /// DEPARTMENTID
        /// </summary>
        public int? DEPARTMENTID { get; set; }
        
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
        /// 职位名称
        /// </summary>
        public string 职位名称 { get; set; }
        
        /// <summary>
        /// 是否部门管理职位
        /// </summary>
        public bool? 是否部门管理职位 { get; set; }
        
        /// <summary>
        /// 编制人数
        /// </summary>
        public int? 编制人数 { get; set; }
        
        /// <summary>
        /// 职位描述
        /// </summary>
        public string 职位描述 { get; set; }
        
        /// <summary>
        /// 工作职责
        /// </summary>
        public string 工作职责 { get; set; }
        
        /// <summary>
        /// 任职要求
        /// </summary>
        public string 任职要求 { get; set; }
        
        /// <summary>
        /// 排序时间
        /// </summary>
        public DateTime? 排序时间 { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Position model = obj as Model.C_Position;
            if (model != null && model.POSITIONID == this.POSITIONID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return POSITIONID.GetHashCode();
        }
    }
}
    