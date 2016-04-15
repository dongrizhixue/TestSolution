using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq.TestLinqSyntax
{
    public static class LinqDelete
    {

        /// <summary>
        /// 匿名对象的删除
        /// </summary>
        public static void Delete1()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A" }, new UserInfo { ID = 2, Name = "B" } };  //实例化集合
            listUserInfo.Remove(listUserInfo.Where(p => p.ID == 1).FirstOrDefault());   //从集合中删除实体
            foreach (UserInfo item in listUserInfo)
            {
                Console.WriteLine("ID:" + item.ID + " Name:" + item.Name);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 实体对象的删除
        /// </summary>
        public static void Delete2()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>();
            UserInfo user = new UserInfo();   //实体1
            user.ID = 1;
            user.Name = "A";
            listUserInfo.Add(user);
            UserInfo user2 = new UserInfo();  //实体2
            user2.ID = 2;
            user2.Name = "B";
            listUserInfo.Add(user2);
            UserInfo user3 = new UserInfo();   //模仿实体1
            user3.ID = 1;
            user3.Name = "A";
            listUserInfo.Remove(user3);   // 试图用实体3模仿的实体1来删除实体1
            listUserInfo.ForEach(p => Console.WriteLine("ID:" + p.ID + " Name:" + p.Name));
            Console.ReadKey();
        }
    }
}
