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
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// 缓存操作基类
    /// </summary>
    public class BLHelper
    {
        private static readonly string CACHEHEADER_MODEL = "Model_";
        private static readonly string CACHEHEADER_EXISTS = "Exists_";
        private static readonly string CACHEHEADER_COUNTS = "Count_";
        private static readonly string CACHEHEADER_LIST = "List_";

        /// <summary>
        /// 是否启用缓存
        /// </summary>
        protected static readonly bool EnableCache = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableCache"]);

        public BLHelper() { }

        /// <summary>
        /// 缓存key的头部
        /// </summary>
        protected string basicKey;

        /// <summary>
        /// 构造函数,请传入basicKey
        /// </summary>
        public BLHelper(string basicKey)
        {
            this.basicKey = basicKey;
        }

        #region 关于缓存
        /// <summary>
        /// 建立一个Model缓存
        /// </summary>
        protected void TryAddModelCache(object modelKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_MODEL + modelKey.ToString();
            TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// 获取一个Model缓存
        /// </summary>
        protected object GetModelCache(object modelKey)
        {
            return GetCache(basicKey + CACHEHEADER_MODEL + modelKey.ToString());
        }

        /// <summary>
        /// 删除一个Model缓存
        /// </summary>
        protected void RemoveModelCache(object modelKey)
        {
            TryRemoveCache(basicKey + CACHEHEADER_MODEL + modelKey.ToString());
        }

        /// <summary>
        /// 建立一个Exist缓存
        /// </summary>
        protected void TryAddExistCache(object existKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_EXISTS + existKey.ToString();
            TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// 获取一个Exist缓存
        /// </summary>
        protected object GetExistCache(object existKey)
        {
            return GetCache(basicKey + CACHEHEADER_EXISTS + existKey.ToString());
        }

        /// <summary>
        /// 删除一个Exist缓存
        /// </summary>
        protected void RemoveExistCache(object existKey)
        {
            TryRemoveCache(basicKey + CACHEHEADER_EXISTS + existKey.ToString());
        }

        /// <summary>
        /// 建立一个Count缓存
        /// </summary>
        protected void TryAddCountCache(object countKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_MODEL + countKey.ToString();
            TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// 获取一个Count缓存
        /// </summary>
        protected object GetCountCache(object countKey)
        {
            return GetCache(basicKey + CACHEHEADER_MODEL + countKey.ToString());
        }

        /// <summary>
        /// 删除一个Count缓存
        /// </summary>
        protected void RemoveCountCache(object countKey)
        {
            TryRemoveCache(basicKey + CACHEHEADER_MODEL + countKey.ToString());
        }

        /// <summary>
        /// 建立一个List缓存
        /// </summary>
        protected void TryAddListCache(object listKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_LIST + listKey.ToString();
            TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// 获取一个List缓存
        /// </summary>
        protected object GetListCache(object listKey)
        {
            return GetCache(basicKey + CACHEHEADER_LIST + listKey.ToString());
        }

        /// <summary>
        /// 删除一个List缓存
        /// </summary>
        protected void RemoveListCache(object listKey)
        {
            TryRemoveCache(basicKey + CACHEHEADER_LIST + listKey.ToString());
        }

        /// <summary>
        /// 删除key中带"Counts"的缓存
        /// </summary>
        protected void RemoveCountCache()
        {
            RemoveMultiCache(basicKey + CACHEHEADER_COUNTS);
        }

        /// <summary>
        /// 删除key中带"List"的缓存
        /// </summary>
        protected void RemoveListCache()
        {
            RemoveMultiCache(basicKey + CACHEHEADER_LIST);
        }
        #endregion

        #region 缓存基础操作
        /// <summary>
        /// 获取缓存
        /// </summary>
        public static object GetCache(string key)
        {
            return HttpRuntime.Cache[key];
        }

        /// <summary>
        /// 建立缓存
        /// </summary>
        public static object TryAddCache(string key, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            if (GetCache(key) == null && value != null)
                return HttpRuntime.Cache.Add(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
            else
                return null;
        }

        /// <summary>
        /// 移除缓存
        /// </summary>
        public static object TryRemoveCache(string key)
        {
            if (GetCache(key) != null)
                return HttpRuntime.Cache.Remove(key);
            else
                return null;
        }

        /// <summary>
        /// 移除键中带某关键字的缓存
        /// </summary>
        public static void RemoveMultiCache(string keyInclude)
        {
            IDictionaryEnumerator CacheEnum = HttpRuntime.Cache.GetEnumerator();
            while (CacheEnum.MoveNext())
            {
                if (string.IsNullOrEmpty(keyInclude))
                {
                    HttpRuntime.Cache.Remove(CacheEnum.Key.ToString());
                    continue;
                }

                if (CacheEnum.Key.ToString().IndexOf(keyInclude) >= 0)
                    HttpRuntime.Cache.Remove(CacheEnum.Key.ToString());
            }
        }

        /// <summary>
        /// 移除所有缓存
        /// </summary>
        public static void RemoveAllCache()
        {
            RemoveMultiCache(null);
        }
        #endregion
    }
}