/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/6 9:56:57
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DAL
{
    /// <summary>
    /// 数据访问类 C_Person ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class C_Person : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(Model.C_Person model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO C_Person(");
            strSql.Append("删除标识, 创建者, 创建人时间, 修改者, 修改人时间, 姓名, 证件号码, 籍贯, 登录帐号, 员工编号, 曾用名, 性别, 出生日期, 年龄, 出生地, 民族, 户口, 户口性质, 婚姻状况, 员工身份, 国籍, 证件类型, 政治面貌, 健康状况, 身高, 体重, 视力, 最高学历, 最高学位, 专业, 职称, 毕业院校, 备注, 在职状态)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_删除标识, @in_创建者, @in_创建人时间, @in_修改者, @in_修改人时间, @in_姓名, @in_证件号码, @in_籍贯, @in_登录帐号, @in_员工编号, @in_曾用名, @in_性别, @in_出生日期, @in_年龄, @in_出生地, @in_民族, @in_户口, @in_户口性质, @in_婚姻状况, @in_员工身份, @in_国籍, @in_证件类型, @in_政治面貌, @in_健康状况, @in_身高, @in_体重, @in_视力, @in_最高学历, @in_最高学位, @in_专业, @in_职称, @in_毕业院校, @in_备注, @in_在职状态)");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_姓名", DbType.String, model.姓名),
                dbHelper.CreateInDbParameter("@in_证件号码", DbType.String, model.证件号码),
                dbHelper.CreateInDbParameter("@in_籍贯", DbType.String, model.籍贯),
                dbHelper.CreateInDbParameter("@in_登录帐号", DbType.String, model.登录帐号),
                dbHelper.CreateInDbParameter("@in_员工编号", DbType.String, model.员工编号),
                dbHelper.CreateInDbParameter("@in_曾用名", DbType.String, model.曾用名),
                dbHelper.CreateInDbParameter("@in_性别", DbType.String, model.性别),
                dbHelper.CreateInDbParameter("@in_出生日期", DbType.DateTime, model.出生日期),
                dbHelper.CreateInDbParameter("@in_年龄", DbType.String, model.年龄),
                dbHelper.CreateInDbParameter("@in_出生地", DbType.String, model.出生地),
                dbHelper.CreateInDbParameter("@in_民族", DbType.String, model.民族),
                dbHelper.CreateInDbParameter("@in_户口", DbType.String, model.户口),
                dbHelper.CreateInDbParameter("@in_户口性质", DbType.String, model.户口性质),
                dbHelper.CreateInDbParameter("@in_婚姻状况", DbType.Boolean, model.婚姻状况),
                dbHelper.CreateInDbParameter("@in_员工身份", DbType.String, model.员工身份),
                dbHelper.CreateInDbParameter("@in_国籍", DbType.String, model.国籍),
                dbHelper.CreateInDbParameter("@in_证件类型", DbType.String, model.证件类型),
                dbHelper.CreateInDbParameter("@in_政治面貌", DbType.String, model.政治面貌),
                dbHelper.CreateInDbParameter("@in_健康状况", DbType.String, model.健康状况),
                dbHelper.CreateInDbParameter("@in_身高", DbType.Double, model.身高),
                dbHelper.CreateInDbParameter("@in_体重", DbType.Double, model.体重),
                dbHelper.CreateInDbParameter("@in_视力", DbType.Double, model.视力),
                dbHelper.CreateInDbParameter("@in_最高学历", DbType.String, model.最高学历),
                dbHelper.CreateInDbParameter("@in_最高学位", DbType.String, model.最高学位),
                dbHelper.CreateInDbParameter("@in_专业", DbType.String, model.专业),
                dbHelper.CreateInDbParameter("@in_职称", DbType.String, model.职称),
                dbHelper.CreateInDbParameter("@in_毕业院校", DbType.String, model.毕业院校),
                dbHelper.CreateInDbParameter("@in_备注", DbType.String, model.备注),
                dbHelper.CreateInDbParameter("@in_在职状态", DbType.String, model.在职状态)};
        }

        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(Model.C_Person model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE C_Person SET ");
            strSql.Append("删除标识=@in_删除标识,");
            strSql.Append("创建者=@in_创建者,");
            strSql.Append("创建人时间=@in_创建人时间,");
            strSql.Append("修改者=@in_修改者,");
            strSql.Append("修改人时间=@in_修改人时间,");
            strSql.Append("姓名=@in_姓名,");
            strSql.Append("证件号码=@in_证件号码,");
            strSql.Append("籍贯=@in_籍贯,");
            strSql.Append("登录帐号=@in_登录帐号,");
            strSql.Append("员工编号=@in_员工编号,");
            strSql.Append("曾用名=@in_曾用名,");
            strSql.Append("性别=@in_性别,");
            strSql.Append("出生日期=@in_出生日期,");
            strSql.Append("年龄=@in_年龄,");
            strSql.Append("出生地=@in_出生地,");
            strSql.Append("民族=@in_民族,");
            strSql.Append("户口=@in_户口,");
            strSql.Append("户口性质=@in_户口性质,");
            strSql.Append("婚姻状况=@in_婚姻状况,");
            strSql.Append("员工身份=@in_员工身份,");
            strSql.Append("国籍=@in_国籍,");
            strSql.Append("证件类型=@in_证件类型,");
            strSql.Append("政治面貌=@in_政治面貌,");
            strSql.Append("健康状况=@in_健康状况,");
            strSql.Append("身高=@in_身高,");
            strSql.Append("体重=@in_体重,");
            strSql.Append("视力=@in_视力,");
            strSql.Append("最高学历=@in_最高学历,");
            strSql.Append("最高学位=@in_最高学位,");
            strSql.Append("专业=@in_专业,");
            strSql.Append("职称=@in_职称,");
            strSql.Append("毕业院校=@in_毕业院校,");
            strSql.Append("备注=@in_备注,");
            strSql.Append("在职状态=@in_在职状态");
            strSql.Append(" WHERE PERSONID=@in_PERSONID");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_删除标识", DbType.Boolean, model.删除标识),
                dbHelper.CreateInDbParameter("@in_创建者", DbType.String, model.创建者),
                dbHelper.CreateInDbParameter("@in_创建人时间", DbType.DateTime, model.创建人时间),
                dbHelper.CreateInDbParameter("@in_修改者", DbType.String, model.修改者),
                dbHelper.CreateInDbParameter("@in_修改人时间", DbType.DateTime, model.修改人时间),
                dbHelper.CreateInDbParameter("@in_姓名", DbType.String, model.姓名),
                dbHelper.CreateInDbParameter("@in_证件号码", DbType.String, model.证件号码),
                dbHelper.CreateInDbParameter("@in_籍贯", DbType.String, model.籍贯),
                dbHelper.CreateInDbParameter("@in_登录帐号", DbType.String, model.登录帐号),
                dbHelper.CreateInDbParameter("@in_员工编号", DbType.String, model.员工编号),
                dbHelper.CreateInDbParameter("@in_曾用名", DbType.String, model.曾用名),
                dbHelper.CreateInDbParameter("@in_性别", DbType.String, model.性别),
                dbHelper.CreateInDbParameter("@in_出生日期", DbType.DateTime, model.出生日期),
                dbHelper.CreateInDbParameter("@in_年龄", DbType.String, model.年龄),
                dbHelper.CreateInDbParameter("@in_出生地", DbType.String, model.出生地),
                dbHelper.CreateInDbParameter("@in_民族", DbType.String, model.民族),
                dbHelper.CreateInDbParameter("@in_户口", DbType.String, model.户口),
                dbHelper.CreateInDbParameter("@in_户口性质", DbType.String, model.户口性质),
                dbHelper.CreateInDbParameter("@in_婚姻状况", DbType.Boolean, model.婚姻状况),
                dbHelper.CreateInDbParameter("@in_员工身份", DbType.String, model.员工身份),
                dbHelper.CreateInDbParameter("@in_国籍", DbType.String, model.国籍),
                dbHelper.CreateInDbParameter("@in_证件类型", DbType.String, model.证件类型),
                dbHelper.CreateInDbParameter("@in_政治面貌", DbType.String, model.政治面貌),
                dbHelper.CreateInDbParameter("@in_健康状况", DbType.String, model.健康状况),
                dbHelper.CreateInDbParameter("@in_身高", DbType.Double, model.身高),
                dbHelper.CreateInDbParameter("@in_体重", DbType.Double, model.体重),
                dbHelper.CreateInDbParameter("@in_视力", DbType.Double, model.视力),
                dbHelper.CreateInDbParameter("@in_最高学历", DbType.String, model.最高学历),
                dbHelper.CreateInDbParameter("@in_最高学位", DbType.String, model.最高学位),
                dbHelper.CreateInDbParameter("@in_专业", DbType.String, model.专业),
                dbHelper.CreateInDbParameter("@in_职称", DbType.String, model.职称),
                dbHelper.CreateInDbParameter("@in_毕业院校", DbType.String, model.毕业院校),
                dbHelper.CreateInDbParameter("@in_备注", DbType.String, model.备注),
                dbHelper.CreateInDbParameter("@in_在职状态", DbType.String, model.在职状态),
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, model.PERSONID)};
        }

        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? PERSONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM C_Person");
            strSql.Append(" WHERE PERSONID=@in_PERSONID");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }

        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? PERSONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM C_Person");
            strSql.Append(" WHERE PERSONID=@in_PERSONID");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }

        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(string tableColumnName, int? PERSONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Person");
            strSql.Append(string.Format(" WHERE {0}=@in_PERSONID", tableColumnName));

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_PERSONID", DbType.Int32, PERSONID)};
        }
        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(string tableColumnName, string PERSONID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM C_Person");
            strSql.Append(string.Format(" WHERE {0}='{1}'", tableColumnName, PERSONID));

            cmdParms = new DbParameter[]{
                //dbHelper.CreateInDbParameter("@in_PERSONID", DbType.String, PERSONID)
            };
        }
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(Model.C_Person model, DbDataReader dr)
        {
            model.PERSONID = GetInt(dr["PERSONID"]);
            model.删除标识 = GetBool(dr["删除标识"]);
            model.创建者 = GetString(dr["创建者"]);
            model.创建人时间 = GetDateTime(dr["创建人时间"]);
            model.修改者 = GetString(dr["修改者"]);
            model.修改人时间 = GetDateTime(dr["修改人时间"]);
            model.姓名 = GetString(dr["姓名"]);
            model.证件号码 = GetString(dr["证件号码"]);
            model.籍贯 = GetString(dr["籍贯"]);
            model.登录帐号 = GetString(dr["登录帐号"]);
            model.员工编号 = GetString(dr["员工编号"]);
            model.曾用名 = GetString(dr["曾用名"]);
            model.性别 = GetString(dr["性别"]);
            model.出生日期 = GetDateTime(dr["出生日期"]);
            model.年龄 = GetString(dr["年龄"]);
            model.出生地 = GetString(dr["出生地"]);
            model.民族 = GetString(dr["民族"]);
            model.户口 = GetString(dr["户口"]);
            model.户口性质 = GetString(dr["户口性质"]);
            model.婚姻状况 = GetBool(dr["婚姻状况"]);
            model.员工身份 = GetString(dr["员工身份"]);
            model.国籍 = GetString(dr["国籍"]);
            model.证件类型 = GetString(dr["证件类型"]);
            model.政治面貌 = GetString(dr["政治面貌"]);
            model.健康状况 = GetString(dr["健康状况"]);
            model.身高 = GetDouble(dr["身高"]);
            model.体重 = GetDouble(dr["体重"]);
            model.视力 = GetDouble(dr["视力"]);
            model.最高学历 = GetString(dr["最高学历"]);
            model.最高学位 = GetString(dr["最高学位"]);
            model.专业 = GetString(dr["专业"]);
            model.职称 = GetString(dr["职称"]);
            model.毕业院校 = GetString(dr["毕业院校"]);
            model.备注 = GetString(dr["备注"]);
            model.在职状态 = GetString(dr["在职状态"]);
        }
    }
}