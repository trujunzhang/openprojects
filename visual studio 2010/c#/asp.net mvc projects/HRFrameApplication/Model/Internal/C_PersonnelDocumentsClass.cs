/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/2 10:11:36
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
    /// 实体类 C_PersonnelDocumentsClass，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_PersonnelDocumentsClass : ICloneable
    {
        public C_PersonnelDocumentsClass()
        { }
        
        /// <summary>
        /// 构造函数 C_PersonnelDocumentsClass
        /// </summary>
        /// <param name="pERSONNELDOCUMENTSCLASSID">PERSONNELDOCUMENTSCLASSID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="所属类别">所属类别</param>
        /// <param name="类别名称">类别名称</param>
        /// <param name="权限设置">权限设置</param>
        public C_PersonnelDocumentsClass(int? pERSONNELDOCUMENTSCLASSID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, string 所属类别, string 类别名称, string 权限设置)
        {
            this.PERSONNELDOCUMENTSCLASSID = pERSONNELDOCUMENTSCLASSID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.所属类别 = 所属类别;
            this.类别名称 = 类别名称;
            this.权限设置 = 权限设置;
        }
        
        #region 实体属性
        /// <summary>
        /// PERSONNELDOCUMENTSCLASSID
        /// </summary>
        public int? PERSONNELDOCUMENTSCLASSID { get; set; }
        
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
        /// 所属类别
        /// </summary>
        public string 所属类别 { get; set; }
        
        /// <summary>
        /// 类别名称
        /// </summary>
        public string 类别名称 { get; set; }
        
        /// <summary>
        /// 权限设置
        /// </summary>
        public string 权限设置 { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_PersonnelDocumentsClass model = obj as Model.C_PersonnelDocumentsClass;
            if (model != null && model.PERSONNELDOCUMENTSCLASSID == this.PERSONNELDOCUMENTSCLASSID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return PERSONNELDOCUMENTSCLASSID.GetHashCode();
        }
    }
}
    