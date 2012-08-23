/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/6 9:56:56
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
    /// 实体类 C_Person，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class C_Person : ICloneable
    {
        public C_Person()
        { }
        
        /// <summary>
        /// 构造函数 C_Person
        /// </summary>
        /// <param name="pERSONID">PERSONID</param>
        /// <param name="删除标识">删除标识</param>
        /// <param name="创建者">创建者</param>
        /// <param name="创建人时间">创建人时间</param>
        /// <param name="修改者">修改者</param>
        /// <param name="修改人时间">修改人时间</param>
        /// <param name="姓名">姓名</param>
        /// <param name="证件号码">证件号码</param>
        /// <param name="籍贯">籍贯</param>
        /// <param name="登录帐号">登录帐号</param>
        /// <param name="员工编号">员工编号</param>
        /// <param name="曾用名">曾用名</param>
        /// <param name="性别">性别</param>
        /// <param name="出生日期">出生日期</param>
        /// <param name="年龄">年龄</param>
        /// <param name="出生地">出生地</param>
        /// <param name="民族">民族</param>
        /// <param name="户口">户口</param>
        /// <param name="户口性质">户口性质</param>
        /// <param name="婚姻状况">婚姻状况</param>
        /// <param name="员工身份">员工身份</param>
        /// <param name="国籍">国籍</param>
        /// <param name="证件类型">证件类型</param>
        /// <param name="政治面貌">政治面貌</param>
        /// <param name="健康状况">健康状况</param>
        /// <param name="身高">身高</param>
        /// <param name="体重">体重</param>
        /// <param name="视力">视力</param>
        /// <param name="最高学历">最高学历</param>
        /// <param name="最高学位">最高学位</param>
        /// <param name="专业">专业</param>
        /// <param name="职称">职称</param>
        /// <param name="毕业院校">毕业院校</param>
        /// <param name="备注">备注</param>
        /// <param name="在职状态">在职状态</param>
        public C_Person(int? pERSONID, bool? 删除标识, string 创建者, DateTime? 创建人时间, string 修改者, DateTime? 修改人时间, string 姓名, string 证件号码, string 籍贯, string 登录帐号, string 员工编号, string 曾用名, string 性别, DateTime? 出生日期, string 年龄, string 出生地, string 民族, string 户口, string 户口性质, bool? 婚姻状况, string 员工身份, string 国籍, string 证件类型, string 政治面貌, string 健康状况, double? 身高, double? 体重, double? 视力, string 最高学历, string 最高学位, string 专业, string 职称, string 毕业院校, string 备注, string 在职状态)
        {
            this.PERSONID = pERSONID;
            this.删除标识 = 删除标识;
            this.创建者 = 创建者;
            this.创建人时间 = 创建人时间;
            this.修改者 = 修改者;
            this.修改人时间 = 修改人时间;
            this.姓名 = 姓名;
            this.证件号码 = 证件号码;
            this.籍贯 = 籍贯;
            this.登录帐号 = 登录帐号;
            this.员工编号 = 员工编号;
            this.曾用名 = 曾用名;
            this.性别 = 性别;
            this.出生日期 = 出生日期;
            this.年龄 = 年龄;
            this.出生地 = 出生地;
            this.民族 = 民族;
            this.户口 = 户口;
            this.户口性质 = 户口性质;
            this.婚姻状况 = 婚姻状况;
            this.员工身份 = 员工身份;
            this.国籍 = 国籍;
            this.证件类型 = 证件类型;
            this.政治面貌 = 政治面貌;
            this.健康状况 = 健康状况;
            this.身高 = 身高;
            this.体重 = 体重;
            this.视力 = 视力;
            this.最高学历 = 最高学历;
            this.最高学位 = 最高学位;
            this.专业 = 专业;
            this.职称 = 职称;
            this.毕业院校 = 毕业院校;
            this.备注 = 备注;
            this.在职状态 = 在职状态;
        }
        
        #region 实体属性
        /// <summary>
        /// PERSONID
        /// </summary>
        public int? PERSONID { get; set; }
        
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
        /// 姓名
        /// </summary>
        public string 姓名 { get; set; }
        
        /// <summary>
        /// 证件号码
        /// </summary>
        public string 证件号码 { get; set; }
        
        /// <summary>
        /// 籍贯
        /// </summary>
        public string 籍贯 { get; set; }
        
        /// <summary>
        /// 登录帐号
        /// </summary>
        public string 登录帐号 { get; set; }
        
        /// <summary>
        /// 员工编号
        /// </summary>
        public string 员工编号 { get; set; }
        
        /// <summary>
        /// 曾用名
        /// </summary>
        public string 曾用名 { get; set; }
        
        /// <summary>
        /// 性别
        /// </summary>
        public string 性别 { get; set; }
        
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? 出生日期 { get; set; }
        
        /// <summary>
        /// 年龄
        /// </summary>
        public string 年龄 { get; set; }
        
        /// <summary>
        /// 出生地
        /// </summary>
        public string 出生地 { get; set; }
        
        /// <summary>
        /// 民族
        /// </summary>
        public string 民族 { get; set; }
        
        /// <summary>
        /// 户口
        /// </summary>
        public string 户口 { get; set; }
        
        /// <summary>
        /// 户口性质
        /// </summary>
        public string 户口性质 { get; set; }
        
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public bool? 婚姻状况 { get; set; }
        
        /// <summary>
        /// 员工身份
        /// </summary>
        public string 员工身份 { get; set; }
        
        /// <summary>
        /// 国籍
        /// </summary>
        public string 国籍 { get; set; }
        
        /// <summary>
        /// 证件类型
        /// </summary>
        public string 证件类型 { get; set; }
        
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string 政治面貌 { get; set; }
        
        /// <summary>
        /// 健康状况
        /// </summary>
        public string 健康状况 { get; set; }
        
        /// <summary>
        /// 身高
        /// </summary>
        public double? 身高 { get; set; }
        
        /// <summary>
        /// 体重
        /// </summary>
        public double? 体重 { get; set; }
        
        /// <summary>
        /// 视力
        /// </summary>
        public double? 视力 { get; set; }
        
        /// <summary>
        /// 最高学历
        /// </summary>
        public string 最高学历 { get; set; }
        
        /// <summary>
        /// 最高学位
        /// </summary>
        public string 最高学位 { get; set; }
        
        /// <summary>
        /// 专业
        /// </summary>
        public string 专业 { get; set; }
        
        /// <summary>
        /// 职称
        /// </summary>
        public string 职称 { get; set; }
        
        /// <summary>
        /// 毕业院校
        /// </summary>
        public string 毕业院校 { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        public string 备注 { get; set; }
        
        /// <summary>
        /// 在职状态
        /// </summary>
        public string 在职状态 { get; set; }
        #endregion
    
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    
        public override bool Equals(object obj)
        {
            Model.C_Person model = obj as Model.C_Person;
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
    