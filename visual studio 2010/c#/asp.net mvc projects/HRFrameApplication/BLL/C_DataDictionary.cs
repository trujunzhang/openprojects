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
    /// 业务逻辑类 C_DataDictionary
    /// </summary>
    public class C_DataDictionary : BLHelper
    {
        private readonly DAL.C_DataDictionary dal = new DAL.C_DataDictionary();

        public C_DataDictionary()
            : base("C_DataDictionary_")
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_DataDictionary model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_DataDictionary model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.DATADICTIONARY_ID);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? DATADICTIONARY_ID)
        {
            int count = dal.Delete(DATADICTIONARY_ID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(DATADICTIONARY_ID.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? DATADICTIONARY_ID)
        {
            return dal.Exists(DATADICTIONARY_ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.C_DataDictionary GetModel(int? DATADICTIONARY_ID)
        {
            Model.C_DataDictionary model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(DATADICTIONARY_ID);
            }
            else
            {
                string key = DATADICTIONARY_ID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_DataDictionary)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(DATADICTIONARY_ID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        /// <summary>
        /// TODO [CUSTOM]{2011-09-30}
        /// 得到一个对象实体
        /// </summary>
        public Model.C_DataDictionary GetModel(String weresql)
        {
            Model.C_DataDictionary model = null;

            model = dal.GetModel(weresql);

            return model;
        }
        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_DataDictionary> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_DataDictionary> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
