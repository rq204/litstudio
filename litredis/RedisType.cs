using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litredis
{
    public enum RedisType
    {
        /// <summary>
        /// 设置key值 
        /// </summary>
        set = 0,
        /// <summary>
        /// 获取key值
        /// </summary>
        get = 1,
        /// <summary>
        /// 将一个或多个值 value 插入到列表 key 的表头
        /// </summary>
        lpush = 2,
        /// <summary>
        /// 将一个或多个值 value 插入到列表 key 的表尾(最右边)
        /// </summary>
        rpush = 3,
        /// <summary>
        /// 移除并返回列表 key 的头元素
        /// </summary>
        lpop = 4,
        /// <summary>
        /// 移除并返回列表 key 的尾元素
        /// </summary>
        rpop = 5,
        /// <summary>
        /// 添加集合，返回大于0为成功，0为已存在
        /// </summary>
        sadd = 6,
        /// <summary>
        /// 查看是否存在，0不存在1存在
        /// </summary>
        sismember=7
    }
}
