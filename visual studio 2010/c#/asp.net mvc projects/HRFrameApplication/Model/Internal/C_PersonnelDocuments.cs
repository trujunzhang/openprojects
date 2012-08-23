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
    /// 实体类 C_PersonnelDocuments，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_PersonnelDocuments : ICloneable
    {
        public C_PersonnelDocuments()
        { }
        
        /// <summary>
        /// 构造函数 C_PersonnelDocuments
        /// </summary>
        /// <param name="pERSONNELDOCUMENTSID">PERSONNELDOCUMENTSID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="类别">类别</param>
        /// <param name="主标题">主标题</param>
        /// <param name="副标题">副标题</param>
        /// <param name="关键字">关键字</param>
        /// <param name="资料简介">资料简介</param>
        /// <param name="附件">附件</param>
        public C_PersonnelDocuments(int? pERSONNELDOCUMENTSID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, string 类别, string 主标题, string 副标题, string 关键字, string 资料简介, string 附件)
        {
            this.PERSONNELDOCUMENTSID = pERSONNELDOCUMENTSID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.类别 = 类别;
            this.主标题 = 主标题;
            this.副标题 = 副标题;
            this.关键字 = 关键字;
            this.资料简介 = 资料简介;
            this.附件 = 附件;
        }
        
        #region 实体属性
        /// <summary>
        /// PERSONNELDOCUMENTSID
        /// </summary>
        public int? PERSONNELDOCUMENTSID { get; set; }
        
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
        /// 类别
        /// </summary>
        public string 类别 { get; set; }
        
        /// <summary>
        /// 主标题
        /// </summary>
        public string 主标题 { get; set; }
        
        /// <summary>
        /// 副标题
        /// </summary>
        public string 副标题 { get; set; }
        
        /// <summary>
        /// 关键字
        /// </summary>
        public string 关键字 { get; set; }
        
        /// <summary>
        /// 资料简介
        /// </summary>
        public string 资料简介 { get; set; }
        
        /// <summary>
        /// 附件
        /// </summary>
        public string 附件 { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_PersonnelDocuments model = obj as Model.C_PersonnelDocuments;
            if (model != null && model.PERSONNELDOCUMENTSID == this.PERSONNELDOCUMENTSID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return PERSONNELDOCUMENTSID.GetHashCode();
        }
    }
}
    