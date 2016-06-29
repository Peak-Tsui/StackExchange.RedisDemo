using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo
{
    class Program
    {
        //static RedisClient redisClient = new RedisClient("127.0.0.1", 6379);//redis服务IP和端口 6379默认端口
        static void Main(string[] args)
        {
            //字符串
            //RedisDemo.StringTest();

            //Hash
            //RedisDemo.HashTest();

            //List
            RedisDemo.ListTest();

            //Set
            //RedisDemo.SetTest();

            //SortedSet
            //RedisDemo.SortedSet();
        }


    }
}
