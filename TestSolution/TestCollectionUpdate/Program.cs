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
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A", Age = 20 }, new UserInfo { ID = 2, Name = "B", Age = 20 } };  //实例化集合
            int index = listUserInfo.IndexOf(listUserInfo.Where(p => p.ID == 1).FirstOrDefault());
            if (index > -1)
            {
                listUserInfo[index].Age += 1;
            }

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
