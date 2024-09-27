using Newtonsoft.Json;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using yylcha.pub.model.nugetM;

namespace yylcha.pub.common
{
    public class redisTools
    {
        private static RedisClient Client;
        public static string Host = "";
        public static int Port = 6379;
        public static string Pwd = "";
        public static long Db = 0;
        public static string UserName = "";
        public redisTools()
        {
            Init();
        }

        /// <summary>
        /// 初始化redis client
        /// </summary>
        public static void Init() {
            Client = new RedisClient(new RedisEndpoint()
            {
                Host = Host,
                Port = Port,
                Password = Pwd,
                Db = Db,
                Username = UserName,
                SendTimeout = 50000,
            });
        }

        /// <summary>
        /// 通过连接串与redis服务器握手
        /// </summary>
        /// <param name="uri"></param>
        public static void Init(Uri uri) {
            Client = new RedisClient(uri);
        }

        /// <summary>
        /// redis 是否连接成功
        /// </summary>
        /// <returns></returns>
        public static bool RedisConnectionIsOk() {
            using (Client)
            {
                return Client.IsSocketConnected();
            }
            return false;
        }

        /// <summary>
        /// 通过key获取value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValueByKey(string key) {
            using (Client)
            {
                return Client.GetValue(key);
            }
        }

        /// <summary>
        /// 写key value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetValueByKey(string key, string value) {
            using (Client)
            {
                Client.Set(key, value);
            }
        }

        /// <summary>
        /// 写入list,从头部写入
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetPrependList(string key,string value) {
            using (Client)
            {
                Client.PrependItemToList(key,value);
            }
        }

        /// <summary>
        /// 写入list,从尾部写入
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetPushList(string key, string value)
        {
            using (Client)
            {
                Client.PushItemToList(key, value);
            }
        }

        /// <summary>
        /// 添加list
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddList(string key,string value) {
            using (Client)
            {
                Client.AddItemToList(key,value);
            }
        }
        public static void AddList(string key, List<string> value)
        {
            using (Client)
            {
                foreach (var single in value)
                {
                    Client.AddItemToList(key, single);
                }
            }
        }
        /// <summary>
        /// 删除list中的元素
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="value"></param>
        public static bool RemoveListItem(string listId,string value) {
            using (Client)
            {
                return Client.RemoveItemFromList(listId,value) == 1;
            }
        }

        /// <summary>
        /// 删除list中的所有元素
        /// </summary>
        /// <param name="listId"></param>
        /// <returns></returns>
        public static void RemoveAllList(string listId) {
            using (Client)
            {
                Client.RemoveAllFromList(listId);
            }
        }
        /// <summary>
        /// 获取list所有明细
        /// </summary>
        /// <param name="key"></param>
        public static List<string> GetList(string key) {
            using (Client)
            {
                return Client.GetAllItemsFromList(key);
            }
        }

        /// <summary>
        /// 获取执行命令的集合
        /// </summary>
        /// <param name="key"></param>
        /// <returns>redis有配置则返回集合，没有则返回null</returns>
        public static List<ExecuteCommandModel> GetCommandModels(string key="PushNuget")
        {
            string getValue = GetValueByKey(key);
            if (string.IsNullOrEmpty(getValue))
                return null;

            return JsonConvert.DeserializeObject<List<ExecuteCommandModel>>(getValue) ?? null;
        }
    }
}
