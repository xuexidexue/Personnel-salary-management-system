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
    public partial class 工资管理 : Form
    {    工资管理 gz;
        string sql2;
         管理员主界面 gl;
         Wage wa=new Wage();
         ArrayList list = new ArrayList();
         Staff st = new Staff();
         department de = new department();
         MyDB sqlHelper = new MyDB();
      

        public 工资管理()
        {
            InitializeComponent();
        }
        public void setGzandGl(工资管理 gz,管理员主界面 gl) {
            this.gz = gz;
            this.gl = gl;
        }
        public void setVisible(int a) {
            bool t;
            bool f;
            if (a == 1)
            {
                t = false;
                f = true;
            }
            else
            {
                t = true;
                f = false;
            }
           textBox5.Visible=button4.Visible = button3.Visible = comboBox1.Visible = label7.Visible = label8.Visible = label9.Visible = label10.Visible = label1.Visible = f;
            button2.Visible =comboBox2.Visible= t;
          
        }
        public void setId(int id) {
            wa.setId(id);
            selectAllIsId(id);
            setStaff_idAndBasis(1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gl.myclos();
            sql2 = null;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";

        }
        public void selectAllIsId(int id) {

            string sql1 = "select * from wage_info where id=@id ";

            Dictionary<string, Object> dic = new Dictionary<string, Object>();
            dic.Add("@id", wa.getId());
            ArrayList al = new ArrayList();
            al = sqlHelper.SelectInfo(sql1, dic);
            if (al != null && al.Count > 0)//判断是有该数据
            {
                foreach (Object[] obj in al)
                {	//得到几行数据就能产生多少个对象
                    wa.setId((int)obj[0]);
                    wa.setStaff_id((int)obj[1]);
                    wa.setBasis((int)obj[2]);
                    wa.setAttendance((int)obj[3]);
                    wa.setPeformance((int)obj[4]);
                    wa.setOther((int)obj[5]);
                    
                    wa.setReason((string)obj[6]);
                    wa.setTotal((int)obj[7]);
                    wa.setTime((DateTime)obj[8]);
                }
                comboBox1.Text = Convert.ToString(wa.getId());
                textBox2.Text = Convert.ToString(wa.getAttendance());
                textBox3.Text = Convert.ToString(wa.getPeformance());
               textBox4.Text = Convert.ToString(wa.getOther());
               textBox6.Text = Convert.ToString(wa.getReason());
               label10.Text = Convert.ToString(wa.getTotal());
               label9.Text = wa.getTime();
                foreach (ComboxItem c in comboBox2.Items)
                {
                    if (c.Values == st.getDepartment_id())
                    {
                        comboBox2.Text = c.Text;
                        break;
                    }

                }
                if (sql2 == null)
                {
                    sql2 = "select id from  wage_info  ";
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
                comboBox2.Items.Clear();
            }
 
        
        }
        public void setStaff_idAndBasis(int a)//查询员工表和部门表
        {
            string sql = "SELECT staff_info.id ,staff_info.name,basis FROM staff_info,department_info WHERE staff_info.department_id=department_info.id";
            string sql1 = "SELECT staff_info.id ,staff_info.name,basis FROM staff_info,department_info WHERE staff_info.department_id=department_info.id and  staff_info.id=@id";
            Dictionary<string, Object> dic = new Dictionary<string, Object>();
            dic.Add("@id",wa.getStaff_id());
            ArrayList al = new ArrayList();
            if (a == 0)
            {
                al = sqlHelper.SelectInfo(sql, dic);
                if (al != null && al.Count > 0)//判断是有该数据
                {
                    foreach (Object[] obj in al)
                    {	//得到几行数据就能产生多少个对象
                        comboBox2.Items.Add(new ComboxItem((string)obj[1], (int)obj[0]));
                        list.Add(obj[2]);

                    }
                }
                else
                {
                    MessageBox.Show("先添加部门 ", "提示");
                }
            }
            else if (a == 1) {
                al = sqlHelper.SelectInfo(sql1, dic);
                if (al != null && al.Count > 0)//判断是有该数据
                {
                    
                    foreach (Object[] obj in al)
                    {	//得到几行数据就能产生多少个对象
                        textBox5.Text = (string)obj[1];
                        textBox1.Text=obj[2].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("先添加员工 ", "提示");
                }
            }
        
        }
        private void button4_Click(object sender, EventArgs e)//修改
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") &&
              !textBox3.Text.Equals("") && !textBox4.Text.Equals("")){
                  Dictionary<string, object> dic = new Dictionary<string, object>();
                string sql = "update wage_info  set  attendance=@attendance ,performance=@performance ,other=@other,reason=@reason,total=@total,createdate=DEFAULT where id=@id";
                dic.Add("@id", wa.getId());
                dic.Add("@attendance", textBox2.Text);
                dic.Add("@performance", textBox3.Text);
                dic.Add("@other", textBox4.Text);
                dic.Add("@reason", textBox6.Text);
                dic.Add("@total", Convert.ToInt16(textBox2.Text) + Convert.ToInt16(textBox3.Text) + Convert.ToInt16(textBox4.Text) + Convert.ToInt16(textBox1.Text));
                if (sqlHelper.SqlPour(sql, dic))
                {

                    MessageBox.Show("成功并退出", "提示");
                    button1_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("失败 ", "提示");
                }
            }
            else
            {
                MessageBox.Show("添加内容不能为空 ", "提示");
            }
        }

        private void button3_Click(object sender, EventArgs e)//删除
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            string update_sql = "DELETE FROM wage_info where id=@id";
            dic.Add("@id", wa.getId());
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

        private void button2_Click(object sender, EventArgs e)//插入
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") &&
               !textBox3.Text.Equals("") && !textBox4.Text.Equals(""))
            {
                string sql = "INSERT INTO wage_info VALUES(NULL,@staff_id,@basis,@attendance,@performance,@other,@reason,@total,DEFAULT);";
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("@staff_id", ((ComboxItem)comboBox2.SelectedItem).Values);
                dic.Add("@basis", textBox1.Text);
                dic.Add("@attendance", textBox2.Text);
                dic.Add("@performance", textBox3.Text);
                dic.Add("@other", textBox4.Text);
                dic.Add("@reason", textBox6.Text);
                dic.Add("@total", Convert.ToInt16(textBox2.Text) + Convert.ToInt16(textBox3.Text) + Convert.ToInt16(textBox4.Text) + Convert.ToInt16(textBox1.Text));
                if (sqlHelper.SqlPour(sql, dic))
                {

                    MessageBox.Show("成功并提出", "提示");
                    button1_Click( sender, e);
                }
                else
                {
                    MessageBox.Show("失败 ", "提示");
                }
            }
            else
            {
                MessageBox.Show("添加内容不能为空 ", "提示");
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {

            if (comboBox2.Items.Count <= 0)
            {

                setStaff_idAndBasis(0);

            }
            
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.Items.Count > 0)
            {
                if (comboBox2.SelectedItem != null)
                {

                    textBox1.Text = list[comboBox2.SelectedIndex].ToString();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setId(Convert.ToInt16(comboBox1.Text));
        }
       
    }
}
