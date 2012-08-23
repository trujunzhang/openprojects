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
    /// 业务逻辑类 C_Position
    /// </summary>
    public class C_Position : BLHelper
    {
        private readonly DAL.C_Position dal = new DAL.C_Position();

        public C_Position()
            : base("C_Position_")
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_Position model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_Position model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.POSITIONID);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? POSITIONID)
        {
            int count = dal.Delete(POSITIONID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(POSITIONID.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? POSITIONID)
        {
            return dal.Exists(POSITIONID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Position GetModel(int? POSITIONID)
        {
            Model.C_Position model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(POSITIONID);
            }
            else
            {
                string key = POSITIONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Position)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(POSITIONID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        /// <param name="wheresql"> </param>
        public List<Model.C_Position> GetList(string wheresql)
        {
            return dal.GetList(wheresql);
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_Position> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
