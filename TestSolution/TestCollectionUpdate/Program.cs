using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollectionUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Update1();
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
    }
    class UserInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
