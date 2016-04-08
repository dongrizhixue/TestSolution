using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollectionDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A" }, new UserInfo { ID = 2, Name = "B" } };  //实例化集合
            listUserInfo.Remove(listUserInfo.Where(p => p.ID == 1).FirstOrDefault());   //从集合中删除实体
            foreach (UserInfo item in listUserInfo)
            {
                Console.WriteLine("ID:" + item.ID + " Name:" + item.Name);
            }
            Console.ReadKey();
        }
    }
    class UserInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
