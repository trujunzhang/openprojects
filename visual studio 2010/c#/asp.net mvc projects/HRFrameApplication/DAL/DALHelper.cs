/*******************************************************************************
* 创建标识: Copyright (C) 2007-2011 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2011/9/2 10:11:36
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Web;
using DBUtility;

namespace DAL
{
    public class DALHelper
    {
        #region WinForm请使用这部分代码，并注释下面的代码，上层调用此方法以赋连接参数
        //public static DBHelper dbHelper;
        //public static void SetHelper(DBHelper.DatabaseTypes type, string connectionString)
        //{
        //    dbHelper = new DBHelper(type, connectionString);
        //} 
        #endregion

        #region WebForm请使用这部分代码，并注释上面的代码，WebConfig中须配置对应的数据库连接
        protected static DBHelper dbHelper = GetHelper("DB");

        /// <summary>
        /// 从Web.config从读取数据库的连接以及数据库类型
        /// </summary>
        private static DBHelper GetHelper(string connectionStringName)
        {
            DBHelper dbHelper = new DBHelper();

            // 从Web.config中读取数据库类型
            string providerName = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName].ProviderName;
            switch (providerName)
            {
                case "System.Data.OracleClient":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.Oracle;
                    break;
                case "MySql.Data.MySqlClient":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.MySql;
                    break;
                case "System.Data.OleDb":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.OleDb;
                    break;
                case "System.Data.SQLite":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.SQLite;
                    break;
                case "System.Data.SqlClient":
                default:
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.Sql;
                    break;
            }

            // 从Web.config中读取数据库连接
            dbHelper.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            return dbHelper;
        }
        #endregion

        #region 由Object取值
        /// <summary>
        /// 取得Int16值
        /// </summary>
        public static Int16? GetInt16(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                short result;
                if (Int16.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得UInt16值
        /// </summary>
        public static UInt16? GetUInt16(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                ushort result;
                if (UInt16.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得Int值
        /// </summary>
        public static int? GetInt(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                int result;
                if (int.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得UInt值
        /// </summary>
        public static uint? GetUInt(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                uint result;
                if (uint.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得UInt64值
        /// </summary>
        public static ulong? GetULong(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                ulong result;
                if (ulong.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得byte值
        /// </summary>
        public static byte? GetByte(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                byte result;
                if (byte.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得sbyte值
        /// </summary>
        public static sbyte? GetSByte(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                sbyte result;
                if (sbyte.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得Long值
        /// </summary>
        public static long? GetLong(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                long result;
                if (long.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得Decimal值
        /// </summary>
        public static decimal? GetDecimal(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                decimal result;
                if (decimal.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得float值
        /// </summary>
        public static float? GetFloat(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                float result;
                if (float.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null; ;
            }
        }

        /// <summary>
        /// 取得double值
        /// </summary>
        public static double? GetDouble(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                double result;
                if (double.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得Guid值
        /// </summary>
        public static Guid? GetGuid(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                try
                {
                    Guid result = new Guid(obj.ToString());
                    return result;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得DateTime值
        /// </summary>
        public static DateTime? GetDateTime(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                DateTime result;
                if (DateTime.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得bool值
        /// </summary>
        public static bool? GetBool(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                bool result;
                if (bool.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得byte[]
        /// </summary>
        public static byte[] GetBinary(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                return (byte[])obj;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 取得string值
        /// </summary>
        public static string GetString(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                return obj.ToString().Trim();//TODO by wanghao
            }
            else
            {
                return null;
            }
        }
        #endregion

        //TODO [Custom]{important}
        #region Customize Methods

        /// <summary>
        /// 获得字典类
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="hasNull"></param>
        /// <param name="wheresql"></param>
        /// <returns></returns>
        public Dictionary<string, int?> GetParentDirectionary(string tableName, string keyName, string valueName, bool hasNull, string wheresql)
        {
            Dictionary<string, int?> directionary = new Dictionary<string, int?>();
            if (hasNull)
            {
                directionary.Add("", null);
            }

            StringBuilder strSql = new StringBuilder(string.Format("SELECT {0},{1} FROM  {2} {3} {4}", keyName, valueName, tableName, wheresql, " ORDER BY " + valueName));
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                while (dr.Read())
                {
                    string key = GetString(dr[keyName]);
                    int? value = GetInt(dr[valueName]);
                    if (!directionary.ContainsKey(key))
                    {
                        directionary.Add(key, value);
                    }
                }
            }
            return directionary;
        }
        #endregion
    }
}