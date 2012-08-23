/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/6 13:43:55
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
    /// 业务逻辑类 C_Contract
    /// </summary>
    public class C_Contract : BLHelper
    {
        private readonly DAL.C_Contract dal = new DAL.C_Contract();

        public C_Contract()
            : base("C_Contract_")
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_Contract model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_Contract model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.CONTRACTID);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? CONTRACTID)
        {
            int count = dal.Delete(CONTRACTID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(CONTRACTID.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? CONTRACTID)
        {
            return dal.Exists(CONTRACTID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Contract GetModel(int? CONTRACTID)
        {
            Model.C_Contract model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(CONTRACTID);
            }
            else
            {
                string key = CONTRACTID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Contract)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(CONTRACTID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_Contract> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_Contract> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
