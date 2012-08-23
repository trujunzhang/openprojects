/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.5.0.0 自动创建于 2012/6/22 9:14:52
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
    /// 业务逻辑类 PersonInChargeView
    /// </summary>
    public class PersonInChargeView : BLHelper
    {
        private readonly DAL.PersonInChargeView dal = new DAL.PersonInChargeView();
      
        public PersonInChargeView()
            : base("PersonInChargeView_")
        { }
      
      
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
        public Model.PersonInChargeView GetModel(int? PERSONID)
        {
            Model.PersonInChargeView model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONID);
            }
            else
            {
                string key = PERSONID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.PersonInChargeView)GetModelCache(key);
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
        public List<Model.PersonInChargeView> GetList(string wheresql)
        {
            List<Model.PersonInChargeView> lst = dal.GetList(wheresql);
            return lst;
        }
      
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.PersonInChargeView> GetPageList(PageInfo pi)
        {
            PageList<Model.PersonInChargeView> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
    