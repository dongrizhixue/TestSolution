using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollectionWhereNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Select2();
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
    }
    class UserInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
