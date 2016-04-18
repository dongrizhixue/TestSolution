using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq.TestLinqSyntax
{
    public static class LinqSelect
    {
        public static void Select1()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A", Age = 20 }, new UserInfo { ID = 2, Name = "B", Age = 20 } };  //实例化集合
            UserInfo user = listUserInfo.Where(p => p.ID == 2).FirstOrDefault();
            Console.WriteLine("ID:" + user.ID + " Name:" + user.Name + " Age:" + user.Age);
            Console.ReadKey();
        }
        public static void Select2()
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
        /// 测试c# linq.Where+Func筛选数据
        /// </summary>
        public static void Select3()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A", Age = 20 }, new UserInfo { ID = 2, Name = "B", Age = 20 }, new UserInfo { ID = 3, Name = "C", Age = 20 } };  //实例化集合
            Func<UserInfo, bool> filterID = x => true, filterName = x => true;
            filterID = x => x.Age == 20;
            filterName = x => x.Name != "C";
            List<UserInfo> listWhere = listUserInfo.Where(filterID).Where(filterName).ToList();
            listWhere.ForEach(p => Console.WriteLine("ID:" + p.ID + " Name:" + p.Name + " Age:" + p.Age));
            Console.ReadKey();
        }
        /// <summary>
        /// 测试c# linq.Where+Func筛选数据
        /// </summary>
        public static void Select4()
        {
            List<UserInfo> listUserInfo = new List<UserInfo>() { new UserInfo { ID = 1, Name = "A", Age = 20 }, new UserInfo { ID = 2, Name = "B", Age = 20 }, new UserInfo { ID = 3, Name = "C", Age = 20 } };  //实例化集合
            Func<UserInfo, bool> filterID = x => true, filterName = x => true;
            filterID = x => x.Age > 20;
            filterName = x => x.Name != "C";
            var varlist = from n in listUserInfo.Where(filterID).Where(filterName)
                          orderby n.ID descending
                          select n;
            varlist.ToList().ForEach(p => Console.WriteLine("ID:" + p.ID + " Name:" + p.Name + " Age:" + p.Age));
            Console.ReadKey();
        }

        public static void Select5()
        {
            string strContons = "先生";
            Console.WriteLine(strContons.Length.ToString());
            Console.ReadKey();
        }
    }
}
