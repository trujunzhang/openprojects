/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/30 15:07:38
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
    /// 实体类 C_DataDictionary，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_DataDictionary : ICloneable
    {
        public C_DataDictionary()
        { }
        
        /// <summary>
        /// 构造函数 C_DataDictionary
        /// </summary>
        /// <param name="dATADICTIONARY_ID">DATADICTIONARY_ID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="主菜单编号">主菜单编号</param>
        /// <param name="子菜单编号">子菜单编号</param>
        /// <param name="字典类型">字典类型</param>
        /// <param name="字典内容">字典内容</param>
        public C_DataDictionary(int? dATADICTIONARY_ID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, string 主菜单编号, string 子菜单编号, string 字典类型, byte[] 字典内容)
        {
            this.DATADICTIONARY_ID = dATADICTIONARY_ID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.主菜单编号 = 主菜单编号;
            this.子菜单编号 = 子菜单编号;
            this.字典类型 = 字典类型;
            this.字典内容 = 字典内容;
        }
        
        #region 实体属性
        /// <summary>
        /// DATADICTIONARY_ID
        /// </summary>
        public int? DATADICTIONARY_ID { get; set; }
        
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
        /// 主菜单编号
        /// </summary>
        public string 主菜单编号 { get; set; }
        
        /// <summary>
        /// 子菜单编号
        /// </summary>
        public string 子菜单编号 { get; set; }
        
        /// <summary>
        /// 字典类型
        /// </summary>
        public string 字典类型 { get; set; }
        
        /// <summary>
        /// 字典内容
        /// </summary>
        public byte[] 字典内容 { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_DataDictionary model = obj as Model.C_DataDictionary;
            if (model != null && model.DATADICTIONARY_ID == this.DATADICTIONARY_ID)
                return true;
                
            return false;
        }
        
        public override int GetHashCode()
        {
            return DATADICTIONARY_ID.GetHashCode();
        }
    }
}
    