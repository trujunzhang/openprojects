/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/7 9:53:22
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
    /// 业务逻辑类 C_PersonInCharge
    /// </summary>
    public class C_PersonInCharge : BLHelper
    {
        private readonly DAL.C_PersonInCharge dal = new DAL.C_PersonInCharge();

        public C_PersonInCharge()
            : base("C_PersonInCharge_")
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_PersonInCharge model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_PersonInCharge model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.PERSONINCHARGEID);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? PERSONINCHARGEID)
        {
            int count = dal.Delete(PERSONINCHARGEID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(PERSONINCHARGEID.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? PERSONINCHARGEID)
        {
            return dal.Exists("PERSONINCHARGEID", PERSONINCHARGEID);
        }

        /// <summary>
        /// TODO [Custom][2011-09-08]
        /// 是否存在该记录
        /// </summary>
        public bool ExistsPersionID(int? PERSONID)
        {
            return dal.Exists("PERSONID", PERSONID);
        }

        /// <summary>
        /// TODO [Custom][2011-09-08]
        /// 得到一个对象实体
        /// </summary>
        public Model.C_PersonInCharge GetModel(string tableColumnName, int? PERSONINCHARGEID)
        {
            Model.C_PersonInCharge model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(tableColumnName,PERSONINCHARGEID);
            }
            else
            {
                string key = PERSONINCHARGEID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_PersonInCharge)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(tableColumnName,PERSONINCHARGEID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// TODO [Custom][2011-09-08]
        /// 得到一个对象实体
        /// </summary>
        public Model.C_PersonInCharge GetModel( int? PERSONINCHARGEID)
        {
            Model.C_PersonInCharge model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONINCHARGEID);
            }
            else
            {
                string key = PERSONINCHARGEID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_PersonInCharge)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(PERSONINCHARGEID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_PersonInCharge> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_PersonInCharge> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }


    }
}
