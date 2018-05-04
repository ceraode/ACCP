using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li6
{
    class Program
    {
        class CompSalary
        {
            public static void Pay(PM pm)
            {
                float money = pm.BasePay + pm.MgrPrize + pm.Bonus;
                Console.WriteLine("项目经理的薪水:" + money);
            }
            public static void Pay(SE se)
            {
                float money = se.BasePay + se.MeritPay;
                Console.WriteLine("程序员薪水:" + money);
            }
        }
        static void Main(string[] args)
        {
            SE se = new SE("乔布斯");
            se.BasePay = 4000;
            se.MeritPay = 3000;

            PM pm = new PM();
            pm.BasePay = 4000;
            pm.Bonus = 4000;
            pm.MgrPrize = 4000;

            CompSalary.Pay(se);
            CompSalary.Pay(pm);

            Console.ReadLine();
        }
    }
}
