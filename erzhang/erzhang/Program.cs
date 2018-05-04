using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erzhang
{
    class Program
    {   
        //static void Main(string[] args)
        //{
        //    //int[] heightZhang = new int[] {170,60};
        //    //int[] heightLi = new int[2];
        //    //Console.WriteLine("复制前:"+heightLi[0]+"与:"+heightLi[1]);
        //    //for (int i = 0; i < heightZhang.Length; i++)
        //    //{
        //    //    heightLi[i] = heightZhang[i];
        //    //}
        //    //Console.WriteLine("去年"+heightZhang[0]+"与"+heightZhang[1]+"李"+heightLi[0]+"体"+heightLi[1]);
        //    //heightLi[0] = 180;
        //    //heightLi[1] = 70;
        //    //Console.WriteLine("今年" + heightZhang[0] + "与" + heightZhang[1] + "李" + heightLi[0] + "体" + heightLi[1]);
        //    //Console.ReadLine();

        //}




        //public struct Student
        //{
        //    public int _id;
        //    public int _age;

        //    public void Show()
        //    {
        //        Console.WriteLine("ID:{0}\n年龄：{1}", _id, _age);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Student stu;
        //    stu._id = 1001;
        //    stu._age = 20;
        //    stu.Show();
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{
        //    int[] points = new int[5];
        //    int[] newPoints = new int[5];
        //    Console.WriteLine("请输入会员的积分");
        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        Console.WriteLine("第"+(i+1)+"位会员");
        //        points[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        newPoints[i] = points[i];
        //        newPoints[i] = points[i] + 500;
        //    }
        //    Console.WriteLine("\n年号 历史积分 新年积分");
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine(" "+i+" "+points[i]+" "+newPoints[i]);
        //    }
        //    Console.ReadLine();
        //}




        //static void Main(string[] args)
        //{
        //    int i = 123;
        //    object o = i;    //装箱
        //    i = 456;
        //    Console.WriteLine(i);
        //    Console.WriteLine(o);
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{
        //    int i = 123;
        //    object o = i;      //装箱
        //    int j = (int)o;    //拆箱
        //}



        static void ChangeNum(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("交换方法内部{0}\t{1}", num1, num2);
        }
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            ChangeNum(num1, num2);
            Console.WriteLine("{0}\t{1}", num1, num2);
            Console.ReadLine();
        }
    }
}
