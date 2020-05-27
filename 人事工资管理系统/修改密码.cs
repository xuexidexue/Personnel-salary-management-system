using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 人事工资管理系统
{
   
    public partial class 修改密码 : Form
    {   public User user;
        管理员主界面 guanli=null;
        public 修改密码()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Dictionary<string, object> dic = new Dictionary<string, object>();
            string update_sql = "update user set  password=@password where id=@id";
            if (user.getPassword().Equals(textBox1.Text))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    dic.Add("@password", textBox2.Text);
                    dic.Add("@id", user.getId());
                    MyDB sqlHelper = new MyDB();
                    if (sqlHelper.SqlPour(update_sql, dic))
                    {

                        MessageBox.Show("成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("失败 " , "提示");
                    }
                }
                else {
                    label4.Text = "两次密码输入不一致";
                }
            }
            else
            {
                label4.Text = "旧密码错误";
            }
        }
        public void setUseandGuanli(User user, 管理员主界面 guanli)
        {
            this.user = user;
            this.guanli = guanli;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guanli.myclos();
        }
        }
    }

