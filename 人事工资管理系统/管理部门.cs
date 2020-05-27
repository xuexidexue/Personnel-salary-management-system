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
    public partial class 管理部门 : Form
    {
        管理员主界面 gl;
        department de=new department();
        string sql2 = null; 
        MyDB sqlHelper = new MyDB();
        public 管理部门()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!textBox1.Text.Equals("")&&!textBox2.Text.Equals(""))
                    {
              Dictionary<string, object> dic = new Dictionary<string, object>();
              string sql = "insert into department_info values(null, @name, @basis)";
               
                            dic.Add("@name", textBox1.Text);
                            dic.Add("@basis", Convert.ToInt16(textBox2.Text));
                            MyDB sqlHelper = new MyDB();
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
                        label3.Text = "添加内容不允许为空!";
                    }
          
        }
        public void setGuanli(管理员主界面 gl) {
            this.gl = gl;

        }
        public void setVisible(int a) {
            bool t = false;
            bool f = true;
            if (a == 1)//为1时改删
            {
                t = true;
                f = false;
            }
            else if(a==0) {//为0时增加
                t = false;
                f = true;
            }
                button3.Visible = t;
                button4.Visible = t;
                label4.Visible = t;
                comboBox1.Visible = t;
                button1.Visible = f;
                textBox1.Text = "";
                textBox2.Text = "";
        }
        public void setId(int a) {
            de.setId(a);
            setDepartment();
        }
        private void setDepartment() {
            string sql1 = "select * from department_info where id=@id ";
           
            Dictionary<string, Object> dic = new Dictionary<string, Object>();
            dic.Add("@id", de.getId());
            ArrayList al = new ArrayList();
            al = sqlHelper.SelectInfo(sql1, dic);           
            if (al != null && al.Count > 0)//判断是有该数据
            {
                     foreach (Object[] obj in al)
                    {	//得到几行数据就能产生多少个对象
                        de.setId((int)obj[0]);
                        de.setName((string)obj[1]);
                        de.setBasis((int)obj[2]);
                    }
                     comboBox1.Text = Convert.ToString(de.getId());
                     textBox1.Text = de.getName();
                     textBox2.Text = Convert.ToString(de.getBasis());
                     if (sql2 == null)
                     {
                         sql2 = "select id from department_info ";
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
            else
            {
                MessageBox.Show("该部门可能已被删除!", "提示");

                gl.myclos();
                sql2 = null;
                comboBox1.Items.Clear();
            }
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gl.myclos();
            sql2 = null;
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            setId(Convert.ToInt16(comboBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string update_sql = "update department_info  set  name=@name , basis=@basis where id=@id";

                    dic.Add("@name", textBox1.Text);
                    dic.Add("@basis",textBox2.Text );
                    dic.Add("@id",de.getId() );
                    MyDB sqlHelper = new MyDB();
                    if (sqlHelper.SqlPour(update_sql, dic))
                    {

                        MessageBox.Show("成功", "提示");

                       
                    }
                    else
                    {
                        MessageBox.Show("失败 ", "提示");
                    }
              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string update_sql = "DELETE FROM department_info where id=@id";
            dic.Add("@id", de.getId());
            MyDB sqlHelper = new MyDB();
            if (MessageBox.Show("你确定要删除此记录吗？！", "提示信息！", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (sqlHelper.SqlPour(update_sql, dic))
                {

                    MessageBox.Show("成功并关闭", "提示");
                    button2_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("失败 ", "提示");
                }
            }
        }





     
    }
}
