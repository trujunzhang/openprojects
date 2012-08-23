/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.5.0.0 自动创建于 2012/7/2 11:20:23
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
    /// 业务逻辑类 PersonInPositionView
    /// </summary>
    public class PersonInPositionView : BLHelper
    {
        private readonly DAL.PersonInPositionView dal = new DAL.PersonInPositionView();
      
        public PersonInPositionView()
            : base("PersonInPositionView_")
        { }
      
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.PersonInPositionView model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.PersonInPositionView model)
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
            bool bln = dal.Exists(PERSONID);
            return bln;
        }
      
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.PersonInPositionView GetModel(int? PERSONID)
        {
            Model.PersonInPositionView model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONID);
            }
            else
            {
                string key = PERSONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.PersonInPositionView)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(PERSONID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.PersonInPositionView> GetList(string wheresql)
        {
            List<Model.PersonInPositionView> lst = dal.GetList(wheresql);
            return lst;
        }
      
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.PersonInPositionView> GetPageList(PageInfo pi)
        {
            PageList<Model.PersonInPositionView> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
    