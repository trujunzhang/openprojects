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
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// 业务逻辑类 C_Person
    /// </summary>
    public class C_Person : BLHelper
    {
        private readonly DAL.C_Person dal = new DAL.C_Person();

        public C_Person()
            : base("C_Person_")
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_Person model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_Person model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.PERSONID);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? PERSONID)
        {
            int count = dal.Delete(PERSONID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(PERSONID.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? PERSONID)
        {
            return dal.Exists(PERSONID);
        }

        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Person GetModel(string tableColumnName, int? PERSONID)
        {
            Model.C_Person model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(tableColumnName, PERSONID);
            }
            else
            {
                string key = PERSONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Person)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(tableColumnName, PERSONID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// TODO [Custom]{2011-09-16}
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Person GetModel(string tableColumnName, string PERSONID)
        {
            Model.C_Person model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(tableColumnName, PERSONID);
            }
            else
            {
                string key = PERSONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Person)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(tableColumnName, PERSONID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_Person> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_Person> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }

    }
}
