/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2011 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2011/9/2 10:11:37
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Caching;

namespace BLL
{
    /// <summary>
    /// �����������
    /// </summary>
    public class BLHelper
    {
        private static readonly string CACHEHEADER_MODEL = "Model_";
        private static readonly string CACHEHEADER_EXISTS = "Exists_";
        private static readonly string CACHEHEADER_COUNTS = "Count_";
        private static readonly string CACHEHEADER_LIST = "List_";

        /// <summary>
        /// �Ƿ����û���
        /// </summary>
        protected static readonly bool EnableCache = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableCache"]);

        public BLHelper() { }

        /// <summary>
        /// ����key��ͷ��
        /// </summary>
        protected string basicKey;

        /// <summary>
        /// ���캯��,�봫��basicKey
        /// </summary>
        public BLHelper(string basicKey)
        {
            this.basicKey = basicKey;
        }

        #region ���ڻ���
        /// <summary>
        /// ����һ��Model����
        /// </summary>
        protected void TryAddModelCache(object modelKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_MODEL + modelKey.ToString();
            TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// ��ȡһ��Model����
        /// </summary>
        protected object GetModelCache(object modelKey)
        {
            return GetCache(basicKey + CACHEHEADER_MODEL + modelKey.ToString());
        }

        /// <summary>
        /// ɾ��һ��Model����
        /// </summary>
        protected void RemoveModelCache(object modelKey)
        {
            TryRemoveCache(basicKey + CACHEHEADER_MODEL + modelKey.ToString());
        }

        /// <summary>
        /// ����һ��Exist����
        /// </summary>
        protected void TryAddExistCache(object existKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_EXISTS + existKey.ToString();
            TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// ��ȡһ��Exist����
        /// </summary>
        protected object GetExistCache(object existKey)
        {
            return GetCache(basicKey + CACHEHEADER_EXISTS + existKey.ToString());
        }

        /// <summary>
        /// ɾ��һ��Exist����
        /// </summary>
        protected void RemoveExistCache(object existKey)
        {
            TryRemoveCache(basicKey + CACHEHEADER_EXISTS + existKey.ToString());
        }

        /// <summary>
        /// ����һ��Count����
        /// </summary>
        protected void TryAddCountCache(object countKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_MODEL + countKey.ToString();
            TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// ��ȡһ��Count����
        /// </summary>
        protected object GetCountCache(object countKey)
        {
            return GetCache(basicKey + CACHEHEADER_MODEL + countKey.ToString());
        }

        /// <summary>
        /// ɾ��һ��Count����
        /// </summary>
        protected void RemoveCountCache(object countKey)
        {
            TryRemoveCache(basicKey + CACHEHEADER_MODEL + countKey.ToString());
        }

        /// <summary>
        /// ����һ��List����
        /// </summary>
        protected void TryAddListCache(object listKey, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            string key = basicKey + CACHEHEADER_LIST + listKey.ToString();
            TryAddCache(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
        }

        /// <summary>
        /// ��ȡһ��List����
        /// </summary>
        protected object GetListCache(object listKey)
        {
            return GetCache(basicKey + CACHEHEADER_LIST + listKey.ToString());
        }

        /// <summary>
        /// ɾ��һ��List����
        /// </summary>
        protected void RemoveListCache(object listKey)
        {
            TryRemoveCache(basicKey + CACHEHEADER_LIST + listKey.ToString());
        }

        /// <summary>
        /// ɾ��key�д�"Counts"�Ļ���
        /// </summary>
        protected void RemoveCountCache()
        {
            RemoveMultiCache(basicKey + CACHEHEADER_COUNTS);
        }

        /// <summary>
        /// ɾ��key�д�"List"�Ļ���
        /// </summary>
        protected void RemoveListCache()
        {
            RemoveMultiCache(basicKey + CACHEHEADER_LIST);
        }
        #endregion

        #region �����������
        /// <summary>
        /// ��ȡ����
        /// </summary>
        public static object GetCache(string key)
        {
            return HttpRuntime.Cache[key];
        }

        /// <summary>
        /// ��������
        /// </summary>
        public static object TryAddCache(string key, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemovedCallback)
        {
            if (GetCache(key) == null && value != null)
                return HttpRuntime.Cache.Add(key, value, dependencies, absoluteExpiration, slidingExpiration, priority, onRemovedCallback);
            else
                return null;
        }

        /// <summary>
        /// �Ƴ�����
        /// </summary>
        public static object TryRemoveCache(string key)
        {
            if (GetCache(key) != null)
                return HttpRuntime.Cache.Remove(key);
            else
                return null;
        }

        /// <summary>
        /// �Ƴ����д�ĳ�ؼ��ֵĻ���
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
        /// �Ƴ����л���
        /// </summary>
        public static void RemoveAllCache()
        {
            RemoveMultiCache(null);
        }
        #endregion
    }
}