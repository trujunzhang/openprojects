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
using System.Data;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// 业务逻辑类 C_Department
    /// </summary>
    public class C_Department : BLHelper
    {
        private readonly DAL.C_Department dal = new DAL.C_Department();

        public C_Department()
            : base("C_Department_")
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_Department model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_Department model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.DEPARTMENTID);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? DEPARTMENTID)
        {
            int count = dal.Delete(DEPARTMENTID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(DEPARTMENTID.ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? DEPARTMENTID)
        {
            return dal.Exists(DEPARTMENTID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.C_Department GetModel(int? DEPARTMENTID)
        {
            Model.C_Department model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(DEPARTMENTID);
            }
            else
            {
                string key = DEPARTMENTID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_Department)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(DEPARTMENTID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_Department> GetList(string wheresql)
        {
            return dal.GetList(wheresql);
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_Department> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }


    }
}
