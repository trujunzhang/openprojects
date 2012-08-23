/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/2 10:11:37
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
    /// 业务逻辑类 C_Mechanism
    /// </summary>
    public class C_Mechanism : BLHelper
    {
        private readonly DAL.C_Mechanism dal = new DAL.C_Mechanism();

        public C_Mechanism()
            : base("C_Mechanism_")
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_Mechanism model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_Mechanism model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.MECHANISMID);
            }
        }

        /// <summary>
        /// TODO [CHANGE]{2011-09-14}
        /// 删除一条数据
        /// </summary>
        public int Delete(int? MECHANISMID)
        {
            int count = dal.Delete(MECHANISMID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(MECHANISMID.ToString());
            }
            return count;
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? MECHANISMID)
        {
            return dal.Exists(MECHANISMID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Mechanism GetModel(int? MECHANISMID)
        {
            Model.C_Mechanism model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(MECHANISMID);
            }
            else
            {
                string key = MECHANISMID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Mechanism)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(MECHANISMID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_Mechanism> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_Mechanism> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }

        public System.Data.DataSet GetDataSet()
        {
            return dal.GetDataSet();
        }


    }
}
