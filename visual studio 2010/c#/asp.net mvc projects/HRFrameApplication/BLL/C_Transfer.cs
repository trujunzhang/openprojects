/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/23 8:38:39
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
    /// 业务逻辑类 C_Transfer
    /// </summary>
    public class C_Transfer : BLHelper
    {
        private readonly DAL.C_Transfer dal = new DAL.C_Transfer();
      
        public C_Transfer()
            : base("C_Transfer_")
        { }
      
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_Transfer model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_Transfer model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.TRANSFERID);
            }
        }
      
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? TRANSFERID)
        {
            int count = dal.Delete(TRANSFERID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(TRANSFERID.ToString());
            }
        }      
      
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? TRANSFERID)
        {
            return dal.Exists(TRANSFERID);
        }
      
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Transfer GetModel(int? TRANSFERID)
        {
            Model.C_Transfer model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(TRANSFERID);
            }
            else
            {
                string key = TRANSFERID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Transfer)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(TRANSFERID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_Transfer> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_Transfer> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    