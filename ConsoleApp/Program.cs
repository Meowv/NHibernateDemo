using Shop.Business;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制台会输出SQL语句

            CustomersBusiness customersBusiness = new CustomersBusiness();
            var result = customersBusiness.GetCustomersList(c => 1 == 1);
            foreach (var v in result)
            {
                Console.WriteLine(v.CompanyName);
            }
            Console.ReadLine();
        }
    }
}
