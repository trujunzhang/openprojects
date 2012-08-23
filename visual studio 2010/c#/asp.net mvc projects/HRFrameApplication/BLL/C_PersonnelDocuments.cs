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
    /// 业务逻辑类 C_PersonnelDocuments
    /// </summary>
    public class C_PersonnelDocuments : BLHelper
    {
        private readonly DAL.C_PersonnelDocuments dal = new DAL.C_PersonnelDocuments();
      
        public C_PersonnelDocuments()
            : base("C_PersonnelDocuments_")
        { }
      
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_PersonnelDocuments model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_PersonnelDocuments model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.PERSONNELDOCUMENTSID);
            }
        }
      
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? PERSONNELDOCUMENTSID)
        {
            int count = dal.Delete(PERSONNELDOCUMENTSID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(PERSONNELDOCUMENTSID.ToString());
            }
        }      
      
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? PERSONNELDOCUMENTSID)
        {
            return dal.Exists(PERSONNELDOCUMENTSID);
        }
      
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.C_PersonnelDocuments GetModel(int? PERSONNELDOCUMENTSID)
        {
            Model.C_PersonnelDocuments model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONNELDOCUMENTSID);
            }
            else
            {
                string key = PERSONNELDOCUMENTSID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_PersonnelDocuments)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(PERSONNELDOCUMENTSID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_PersonnelDocuments> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_PersonnelDocuments> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    