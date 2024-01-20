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
        public static string Port = "6379";
        public static string Pwd = "";
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
                Port = 1,
                Password = Pwd
            });
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
