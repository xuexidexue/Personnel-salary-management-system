using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace 人事工资管理系统
{
    /**
     * 数据库连接处理
     */
    class MyDB
    {

        MySqlConnection conn = null;
        MySqlCommand com = null;
        MySqlDataReader rd = null;
        string constr = "Database=hr;Data Source=localhost;User Id=root;Password=root;pooling=false;CharSet=utf8;Port=3306";

        public bool ConnectSql()
        {   // 连接数据库
            try
            {
                conn = new MySqlConnection(constr);
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SqlPour(string sql, Dictionary<string, object> dic)
        {   //可完成增删改
            try
            {
                ConnectSql();   //打开连接
                com = new MySqlCommand(sql, conn);
                if (dic != null)
                {
                    foreach (var item in dic)
                    {
                        com.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                com.ExecuteNonQuery();
                closeConn();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
            finally //关闭连接
            {
                closeConn();
            }
        }
        public ArrayList SelectInfo(string sql, Dictionary<string, Object> dic)
        {   //可完成查找操作，以Object存取放入ArrayList返回
            try
            {
                ConnectSql();   //打开连接
                com = new MySqlCommand(sql, conn);


                ArrayList al = new ArrayList();
                if (dic != null)
                {
                    foreach (var item in dic)
                    {   //遍历参数并进行赋值，防止sql注入
                        com.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                rd = com.ExecuteReader();
                int clumn = 0;  //得到数据的列数
                if (rd.Read())
                {
                    clumn = rd.FieldCount;
                }
                else
                {
                    return null;
                }
                do
                {   //读取每行每列的数据并放入Object数组中
                    Object[] obj = new object[clumn];
                    for (int i = 0; i < clumn; i++)
                    {
                        obj[i] = rd[i];
                    }
                    al.Add(obj);    //将一行数据放入数组中
                } while (rd.Read());
                closeConn();
                return al;
            }
            catch
            {
               
                return null;
            }
            finally
            {
                closeConn();
            }

        }
        public void closeConn()
        {   //关闭数据库连接
            try
            {
                if (conn != null) { conn.Close(); }
                if (rd != null) { rd.Close(); }
            }
            catch
            {
                return;
            }

        }
    }
}
