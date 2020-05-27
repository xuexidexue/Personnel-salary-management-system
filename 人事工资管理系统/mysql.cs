using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace 人事工资管理系统
{
    public class Mysql
    {
        private string MySqlCon = "Database=hr;Data Source=localhost;User Id=root;Password=root;pooling=false;CharSet=utf8;Port=3306";
        public DataTable select(String sqlStr)
        {
            //查
            MySqlCommand cmd; //定义命令对象；
            MySqlConnection con;
            MySqlDataAdapter msda;
            con = new MySqlConnection(MySqlCon);
            con.Open();
            Console.WriteLine("已经建立连接");
            cmd = new MySqlCommand(sqlStr, con);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            msda = new MySqlDataAdapter(cmd);
            msda.Fill(dt);
            con.Close();
            return dt;
        }
        public int update(string sqlStr)
        {
            //增加删除改
            MySqlCommand cmd;
            MySqlConnection con;
            con = new MySqlConnection(MySqlCon);
            con.Open();
            cmd = new MySqlCommand(sqlStr, con);
            cmd.CommandType = CommandType.Text;
            int iud = 0;
            iud = cmd.ExecuteNonQuery();
            return iud;
        }
    }
}
