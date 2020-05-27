using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace 人事工资管理系统
{
    public partial class 管理管理员 : Form
    {
        MyDB sqlHelper = new MyDB();
       管理员主界面 gl;
       User user;
       ArrayList list = new ArrayList();
       int index=-1;
        public 管理管理员()
        {
            InitializeComponent();
        }
        public void getGl(管理员主界面 gl)
        {
            this.gl = gl;
        }

        private void button2_Click(object sender, EventArgs e)//添加
        {
            if (!textBox1.Text.Equals("root"))
            {
                if (!textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
                {

                    string sql = "INSERT INTO user VALUES(NULL,@name,@password)";
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("@name", textBox1.Text);
                    dic.Add("@password", textBox2.Text);

                    if (sqlHelper.SqlPour(sql, dic))
                    {

                        MessageBox.Show("成功", "提示");
                        setzt();
                    }
                    else
                    {
                        MessageBox.Show("失败 ", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("添加内容不允许为空! ", "提示");
                }
            }
            else
            {
                MessageBox.Show("不能在此设置超级管理员! ", "提示");
            }
        }
        

        private void button3_Click(object sender, EventArgs e)//修改
        {
            if (!textBox1.Text.Equals("root"))
            {
                if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !comboBox1.Text.Equals(""))
                {
                    string sql = "update user set  name=@name , password=@password where id=@id";
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("@name", textBox1.Text);
                    dic.Add("@password", textBox2.Text);
                    dic.Add("@id", comboBox1.Text);
                    if (sqlHelper.SqlPour(sql, dic))
                    {
                        MessageBox.Show("成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("失败 ", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("修改内容不允许为空! ", "提示");
                }
            }
            else {
                MessageBox.Show("不能在此设置超级管理员! ", "提示");
            }
        }

        private void button4_Click(object sender, EventArgs e)//删除
        {
            if (!textBox1.Text.Equals("root"))
            {
                if (!comboBox1.Text.Equals(""))
                {
                    string sql = "delete from user where id=@id";
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("@id", comboBox1.Text);
                    if (sqlHelper.SqlPour(sql, dic))
                    {
                        MessageBox.Show("成功", "提示");
                        setzt();
                    }
                    else
                    {
                        MessageBox.Show("失败 ", "提示");

                    }
                }
                else
                {
                    MessageBox.Show("选择管理员号! ", "提示");
                }
            }
            else {
                MessageBox.Show("不能在此删除超级管理员! ", "提示");
            }
        }

        private void button1_Click(object sender, EventArgs e)//关闭
        {
            gl.myclos();
            setzt();
        }
        public void setcomboBox1(int a)
        {
            if (a ==0)
            {
                Dictionary<string, Object> dic = new Dictionary<string, Object>();
                ArrayList al = new ArrayList();
                string sql2 = "select * from user ";
                al = sqlHelper.SelectInfo(sql2, dic);
                if (al != null && al.Count > 0)
                {
                    foreach (Object[] obj in al)
                    {	//得到几行数据就能产生多少个对象
                        comboBox1.Items.Add((int)obj[0]);
                    }
                }
                else
                {
                    MessageBox.Show("没有数据,请添加!", "提示");
                }
            }
        }
        public void setzt() {//设置初始状态
            textBox1.Text = textBox2.Text = comboBox1.Text = "";
            comboBox1.Items.Clear();
            index = -1;

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, Object> dic = new Dictionary<string, Object>();
            ArrayList al = new ArrayList();
            string sql2 = "select * from user where id=@id ";
            dic.Add("@id", comboBox1.Text);
            al = sqlHelper.SelectInfo(sql2, dic);
            if (al != null && al.Count > 0)
            {
                foreach (Object[] obj in al)
                {	//得到几行数据就能产生多少个对象
                    textBox1.Text = (string)obj[1];
                    textBox2.Text = (string)obj[2];
                }
            }
            else
            {
                MessageBox.Show("没有数据,请添加!", "提示");
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            setcomboBox1(index++);
        }
 }
        
   
    }

