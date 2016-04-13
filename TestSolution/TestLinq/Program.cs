using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Select1()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A", Age = 20 }, new UserInfo { ID = 2, Name = "B", Age = 20 } };  //实例化集合
            UserInfo user = listUserInfo.Where(p => p.ID == 2).FirstOrDefault();
            Console.WriteLine("ID:" + user.ID + " Name:" + user.Name + " Age:" + user.Age);
            Console.ReadKey();
        }
        private static void Select2()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A", Age = 20 }, new UserInfo { ID = 2, Name = "B", Age = 20 } };  //实例化集合
            listUserInfo.Select(p => p.ID == 1);
            listUserInfo = (from n in listUserInfo
                            where n.ID == 2
                            select n).ToList();
            listUserInfo.ForEach(p => Console.WriteLine("ID:" + p.ID + " Name:" + p.Name + " Age:" + p.Age));
            Console.ReadKey();
        }

        /// <summary>
        /// 采用找元素的方法更新集合
        /// </summary>
        private static void Update1()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A", Age = 20 }, new UserInfo { ID = 2, Name = "B", Age = 20 } };  //实例化集合
            int index = listUserInfo.IndexOf(listUserInfo.Where(p => p.ID == 2).FirstOrDefault());
            if (index > -1)
            {
                listUserInfo[index].Age += 1;
            }
            listUserInfo.ForEach(p => Console.WriteLine("ID:" + p.ID + " Name:" + p.Name + " Age:" + p.Age));
            Console.ReadKey();
        }

        private static void Update2()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A", Age = 20 }, new UserInfo { ID = 2, Name = "B", Age = 20 } };  //实例化集合

            listUserInfo.ForEach(p => Console.WriteLine("ID:" + p.ID + " Name:" + p.Name + " Age:" + p.Age));
            Console.ReadKey();
        }

        /// <summary>
        /// 匿名对象的删除
        /// </summary>
        private static void Delete1()
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
        private static void Delete2()
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
    class UserInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
