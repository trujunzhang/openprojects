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
    /// 业务逻辑类 C_PersonnelDocumentsClass
    /// </summary>
    public class C_PersonnelDocumentsClass : BLHelper
    {
        private readonly DAL.C_PersonnelDocumentsClass dal = new DAL.C_PersonnelDocumentsClass();
      
        public C_PersonnelDocumentsClass()
            : base("C_PersonnelDocumentsClass_")
        { }
      
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.C_PersonnelDocumentsClass model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.C_PersonnelDocumentsClass model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.PERSONNELDOCUMENTSCLASSID);
            }
        }
      
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? PERSONNELDOCUMENTSCLASSID)
        {
            int count = dal.Delete(PERSONNELDOCUMENTSCLASSID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(PERSONNELDOCUMENTSCLASSID.ToString());
            }
        }      
      
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? PERSONNELDOCUMENTSCLASSID)
        {
            return dal.Exists(PERSONNELDOCUMENTSCLASSID);
        }
      
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.C_PersonnelDocumentsClass GetModel(int? PERSONNELDOCUMENTSCLASSID)
        {
            Model.C_PersonnelDocumentsClass model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(PERSONNELDOCUMENTSCLASSID);
            }
            else
            {
                string key = PERSONNELDOCUMENTSCLASSID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (Model.C_PersonnelDocumentsClass)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(PERSONNELDOCUMENTSCLASSID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        public List<Model.C_PersonnelDocumentsClass> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<Model.C_PersonnelDocumentsClass> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    