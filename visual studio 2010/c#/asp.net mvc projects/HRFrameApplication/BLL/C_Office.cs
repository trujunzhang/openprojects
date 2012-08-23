/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/2 10:11:38
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
    /// 业务逻辑类 C_Office
    /// </summary>
    public class C_Office : BLHelper
    {
        private readonly DAL.C_Office dal = new DAL.C_Office();

        public C_Office()
            : base("C_Office_")
        { }

        /// <summary>
        /// TODO [CUSTOM]{2011-09-16}
        /// 增加一条数据
        /// </summary>
        public int Add(Model.C_Office model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_Office model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.OFFICEID);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? OFFICEID)
        {
            int count = dal.Delete(OFFICEID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(OFFICEID.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? OFFICEID)
        {
            return dal.Exists(OFFICEID);
        }

        /// <summary>
        /// TODO [Custom]{2011-09-23}
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Office GetModel(string whereSql)
        {
            return dal.GetModel(whereSql);
        }

        /// <summary>        
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Office GetModel(int? OFFICEID)
        {
            Model.C_Office model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(OFFICEID);
            }
            else
            {
                string key = OFFICEID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Office)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(OFFICEID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_Office> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_Office> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
