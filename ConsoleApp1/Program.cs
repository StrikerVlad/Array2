using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i;
            }

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(num.Max());

            int max=0;
            for (int i = 0; i < num.Length; i++)
            {
                if(max>num[i]&& num[i]%2==0)
                {
                    max = num[i];
                }
            }
            Console.WriteLine(max);

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Введите индекс элемента для удаления");
            int c = Convert.ToInt32(Console.ReadLine());
            List<int> temp = num.ToList();
            temp.RemoveAt(c);
            num = temp.ToArray();
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Введите значение элемента для удаления");
            int d = Convert.ToInt32(Console.ReadLine());
            List<int> temp2 = num.ToList();
            temp2.Remove(c);
            num = temp2.ToArray();
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Куда нужно вставить");
            int dc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Что нужно вставить");
            int val = Convert.ToInt32(Console.ReadLine());
            List<int> temp3 = num.ToList();
            temp3.Insert(dc, val);
            num = temp3.ToArray();
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            string a = null;
        }
    }
}
