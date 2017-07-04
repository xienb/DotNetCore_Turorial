using System;
using Dapper;
using MySql.Data.MySqlClient;

namespace DotNetTurorial.Common
{
    public class SQLHelper
    {
        public const string _conStr="server=127.0.0.1;port=3306;user id=root;password=123456;database=dotnetcore;pooling=false";
        public static int AddStudent(string name,int gender,string phone)
        {
            MySqlConnection connect=new MySqlConnection(_conStr);
            var ret = connect.Execute("insert into student(name,gender,phone) values(@name,@gender,@phone)",new {name=name,gender=gender,phone=phone});
            return ret;
        }
    }
}
