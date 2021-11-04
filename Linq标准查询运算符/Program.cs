using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq标准查询运算符
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sources = new int[] { 4,5,6,7,8,9, 3, 6, 5, 2, 8, 1, 9, 11, 15, 3, 7, 8, 11 };
            int[] sources1 = new int[] { 14, 13, 16, 15, 12, 18, 11, 19, 3, 6 };

            // 1. 基础查询
            //var res = from s in sources select s;
            //var res = sources;

            // 2. 条件查询
            //var res = from s in sources where s > 3 select s;
            //var res = sources.Where(s => s > 3);

            // 3. 排序--正序
            //var res = from s in sources orderby s select s;
            //var res = sources.OrderBy(s => s);

            // 4. 排序--倒序
            //var res = from s in sources orderby s descending select s;
            //var res = sources.OrderByDescending(s => s);

            // 5. 联合查询
            //var res = from s in sources from s1 in sources1 where s == s1 select new { first = s, second = s1 };
            //var res = from s in sources join s1 in sources1 on s equals s1 select new { first = s, second = s1 };


            // 6. 分组            
            //var res = from s in sources group s by s into s1 select new { key = s1.Key, count = s1.Count() };
            //var res = sources.GroupBy(s => s).
            //    SelectMany(g => g, (g1, c1) => new { key = g1.Key, count = g1.Count() });

            // 7. Set
            //var res = sources.Distinct();//去重

            // 跳过指定数量取后面的所有
            //var res = sources.Skip(3);
            // 从头开始判断当前值是否满足条件，直到不满足位置开始取值
            //var res = sources.SkipWhile(s => s > 3);
            // 从头开始取指定数量的值
            //var res = sources.Take(5);
            // 从头开始取符合条件的值，直到条件不满足
            //var res = sources.TakeWhile(s => s > 3);
            //var res = sources.Zip(sources1, (s, s1) => s +" "+ s1);
            //var res = sources.All(s => s % 2 == 0);
            //Console.WriteLine(res);

            //System.Collections.ArrayList fruits = new System.Collections.ArrayList
            //{
            //    "mango",
            //    "apple",
            //    "lemon"
            //};
            //var res = fruits.Cast<string>().OrderBy(f => f).Select(f => f);

            //IEnumerable sequence = Enumerable.Range(0, 10);
            //var res = from int item in sequence
            //              select (double)item;

            //var res = sources.Concat(sources1);

            //var res = sources.Contains(3);
            //Console.WriteLine(res);

            //var res = sources.Except(sources1);

            //var res = sources.OfType<int>();

            //var res = sources.SequenceEqual(sources1);

            //IEnumerable res = Enumerable.Repeat(1230_0000_0000_0000_0000, 10);

            

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item + " " + item.GetType());
            //}

            Console.ReadKey();
        }
    }
}
