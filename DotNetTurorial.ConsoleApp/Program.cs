using System;
using DotNetTurorial.Common;

namespace DotNetTurorial.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {  
            //Console.OutputEncoding = Encoding.UTF8; // 设置控制台编码
            AddUser();
            while(Console.ReadLine()!="exit"){
                AddUser();
            }
        } 
        static void AddUser()
        {
            Console.WriteLine("please enter name:");
            var name=Console.ReadLine();
            Console.WriteLine("please enter gender,1 for male and 0 for female.");
            var gender = Console.ReadLine();
            Console.WriteLine("please enter phone:");
            var phone = Console.ReadLine();

            var ret = SQLHelper.AddStudent(name,Convert.ToInt32(gender),phone);
            if(ret>0)
            {
                 Console.WriteLine("success");
            }
        }
    }
}
