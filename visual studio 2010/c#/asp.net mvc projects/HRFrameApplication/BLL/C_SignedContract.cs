/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/26 9:33:02
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// 业务逻辑类 C_SignedContract
    /// </summary>
    public class C_SignedContract : BLHelper
    {
        private readonly DAL.C_SignedContract dal = new DAL.C_SignedContract();

        public C_SignedContract()
            : base("C_SignedContract_")
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_SignedContract model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_SignedContract model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.SIGNDCONTRACTID);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? SIGNDCONTRACTID)
        {
            int count = dal.Delete(SIGNDCONTRACTID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(SIGNDCONTRACTID.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? SIGNDCONTRACTID)
        {
            return dal.Exists(SIGNDCONTRACTID);
        }

        /// <summary>
        /// TODO [Custom][2011-09-08]
        /// 得到一个对象实体
        /// </summary>
        public Model.C_SignedContract GetModel(string tableColumnName, int? SIGNDCONTRACTID)
        {
            Model.C_SignedContract model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(tableColumnName, SIGNDCONTRACTID);
            }            
            return model;
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_SignedContract> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_SignedContract> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
