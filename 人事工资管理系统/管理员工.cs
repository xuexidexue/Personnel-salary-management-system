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
    public partial class 管理员工 : Form
    {   string sql2=null;
        Staff st=new Staff();
        管理员主界面 gl;
         MyDB sqlHelper = new MyDB();
 
        public 管理员工()
        {
            InitializeComponent();
        }
        public void setGl(管理员主界面 gl) {
            this.gl = gl;
        
        }
        public void setId(int a) {
            st.setId(a);

            if (comboBox2.Items.Count <= 0)
            {
                getbmh();
            }
            setDepartment();
         
        }
        public void setVisible(int a) { //设置页面隐藏
            bool t ;
            bool f ;
            if (a == 1)
            {
                t = false;
                f = true;
            }
            else {
                 t = true;
                f = false;
            }
           button4.Visible=button2.Visible=comboBox1.Visible=  label8.Visible =  label1.Visible=label9.Visible = f;
           button3.Visible = t;
           textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text  = "";
        }
        public void getbmh()//查找部门
        {

            string sql1 = "select id ,name from department_info ";

            Dictionary<string, Object> dic = new Dictionary<string, Object>();
            ArrayList al = new ArrayList();
            al = sqlHelper.SelectInfo(sql1, dic);
            if (al != null && al.Count > 0)//判断是有该数据
            {
                foreach (Object[] obj in al)
                {	//得到几行数据就能产生多少个对象
                    comboBox2.Items.Add(new ComboxItem((string)obj[1],(int)obj[0]));       
                }
            }
            else
            {
                MessageBox.Show("先添加部门 ", "提示");
            }
        }
        private void button3_Click(object sender, EventArgs e)//添加
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") &&
                !textBox3.Text.Equals("")&&!textBox4.Text.Equals(""))
            {

                string sql = "INSERT INTO staff_info VALUES(NULL,@name,@department,@password,@sex,@age,DEFAULT,@post);";
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("@name", textBox1.Text);
                dic.Add("@password",textBox2.Text);
                dic.Add("@age", textBox3.Text);
                dic.Add("@post", textBox4.Text);
                dic.Add("@department", ((ComboxItem)comboBox2.SelectedItem).Values);
                dic.Add("@sex",comboBox3.Text);

                //comboBox2.SelectedValue;
              
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
                MessageBox.Show("添加内容不允许为空! ", "提示");
            }
        }
        private void setDepartment()
        {//
            string sql1 = "select * from staff_info where id=@id ";

            Dictionary<string, Object> dic = new Dictionary<string, Object>();
            dic.Add("@id", st.getId());
            ArrayList al = new ArrayList();
            al = sqlHelper.SelectInfo(sql1, dic);
            if (al != null && al.Count > 0)//判断是有该数据
            {
                foreach (Object[] obj in al)
                {	//得到几行数据就能产生多少个对象
                    st.setId((int)obj[0]);
                    st.setName((string)obj[1]);
                    st.setDepartment_id((int)obj[2]);
                    st.setPassword((String)obj[3]);
                    st.setSex((string)obj[4]);
                    st.setAge((int)obj[5]);
                    st.setTime((DateTime)obj[6]);
                    st.setPost((string)obj[7]);
                }
                comboBox1.Text = Convert.ToString(st.getId());
                textBox1.Text = st.getName();
                textBox2.Text = st.getPassword();
                textBox3.Text = Convert.ToString(st.getAge());
                textBox4.Text = st.getPost();
                comboBox3.Text = st.getSex();
                label9.Text = st.getTime();
                foreach (ComboxItem c in comboBox2.Items) {
                    if (c.Values==st.getDepartment_id()) {
                        comboBox2.Text = c.Text;
                        break;
                    }

                } 
                if (sql2 == null)
                {
                    sql2 = "select id from staff_info ";
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
                MessageBox.Show("该员工可能已被删除!", "提示");

                gl.myclos();
                sql2 = null;
                comboBox1.Items.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gl.myclos();
            sql2 = null;
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
           
            if (comboBox2.Items.Count <=0) {
                getbmh();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setId(Convert.ToInt16(comboBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string update_sql = "update staff_info  set  name=@name , department_id=@department ,password=@password,sex=@sex,age=@age,post=@post,createdate=DEFAULT where id=@id";

            dic.Add("@name", textBox1.Text);
            dic.Add("@password", textBox2.Text);
            dic.Add("@age", textBox3.Text);
            dic.Add("@post", textBox4.Text);
            dic.Add("@department", ((ComboxItem)comboBox2.SelectedItem).Values);
            dic.Add("@sex", comboBox3.Text);
            dic.Add("@id", comboBox1.Text);
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
            string update_sql = "DELETE FROM staff_info where id=@id";
            dic.Add("@id", st.getId());
            MyDB sqlHelper = new MyDB();
            if (MessageBox.Show("你确定要删除此记录吗？！", "提示信息！", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (sqlHelper.SqlPour(update_sql, dic))
                {

                    MessageBox.Show("成功并关闭", "提示");
                    button1_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("失败 ", "提示");
                }
            }
        }

    }
}
