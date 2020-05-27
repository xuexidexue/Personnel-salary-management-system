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
    
    public partial class login : Form
    {
        
        
        public login()
        {
            InitializeComponent();
        }

        private void iok_Click(object sender, EventArgs e)
        {
            管理员主界面 frma = new 管理员主界面(this);
            User user = new User();
            MyDB sqlHelper = new MyDB();
            string sql1 = "select * from user where name=@name ";
            string sql2 = "select * from user where name=@name and  password=@password ";
            Dictionary<string, Object> dic = new Dictionary<string, Object>();
            dic.Add("@name", texta.Text);
            dic.Add("@password", textb.Text);
            ArrayList al = new ArrayList();
            al = sqlHelper.SelectInfo(sql1, dic);
            if (al != null && al.Count > 0)//判断是否有用户名
            {   
                al = sqlHelper.SelectInfo(sql2, dic);
                if (al != null && al.Count > 0) {
                    foreach (Object[] obj in al)
                    {	//得到几行数据就能产生多少个对象
                        user.setId((int)obj[0]);
                        //强转成你需要的数据，强转很容易发生异常，所以数据库的约束性要强，对象类时要认真检查数据类型，多用try...catch
                        user.setName((string)obj[1]);
                        user.setPassword((string)obj[2]);

                    } 
                    frma.ControlBox = false;//设置窗体
                    frma.setUser(user);
                    frma.Show();
                    this.Hide();
                 
                }else{
                    label2.Text = "密码错误";
                }
            }
            else
            {
                label2.Text = "请检查用户名";
                MessageBox.Show("如果是员工请点击查询！", "帮助");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff sta = new Staff();
            MyDB sqlHelper = new MyDB();
            string sql1 = "select * from staff_info where name=@name ";
            string sql2 = "select * from staff_info where name=@name and  password=@password ";
            string sql3 = "select * from wage_info where staff_id=@staff_id";
            Dictionary<string, Object> dic = new Dictionary<string, Object>();
            dic.Add("@name", texta.Text);
            dic.Add("@password", textb.Text);
            ArrayList al = new ArrayList();
            al = sqlHelper.SelectInfo(sql1, dic);
            if (al != null && al.Count > 0)//判断是否有用户名
            {
                al = sqlHelper.SelectInfo(sql2, dic);
                if (al != null && al.Count > 0)
                {
                    foreach (Object[] obj in al)
                    {	//得到几行数据就能产生多少个对象
                        sta.setId((int)obj[0]);
                        //强转成你需要的数据，强转很容易发生异常，所以数据库的约束性要强，对象类时要认真检查数据类型，多用try...catch
                        sta.setName((string)obj[1]);
                        sta.setPassword((string)obj[3]);

                        sta.setDepartment_id((int)obj[2]);
                        sta.setSex((string)obj[4]);
                        sta.setAge((int)obj[5]);
                        sta.setTime((DateTime)obj[6]);
                        sta.setPost((string)obj[7]);
                    }
                    dic.Add("@staff_id", sta.getId());
                    al = sqlHelper.SelectInfo(sql3, dic);
                    if (al != null && al.Count > 0)
                    {
                        Wage wage = new Wage();
                        foreach (Object[] obj in al)
                        {	//得到几行数据就能产生多少个对象
                            wage.setId((int)obj[0]);
                            wage.setStaff_id((int)obj[1]);
                            wage.setBasis((int)obj[2]);
                            wage.setAttendance((int)obj[3]);
                            wage.setPeformance((int)obj[4]);
                            wage.setOther((int)obj[5]);
                            wage.setReason((string)obj[6]);
                            wage.setTotal((int)obj[7]);
                            wage.setTime((DateTime)obj[8]);
                        }
                        MessageBox.Show("用户" + sta.getName() + "您好,\n您最新的工资为:" + wage.getTotal() + "\n详细信息:\n\t基础工资：" + wage.getBasis() + "\n\t考勤工资：" + wage.getAttendance() + "\n\t效绩工资：" + wage.getPeformance() + "\n\t其他工资：" + wage.getOther() + "\n\t原因：" + wage.getReason() + "\n更新时间" + wage.getTime(), "工资条");
                    }
                    else {
                        MessageBox.Show(sta.getName() + "您好,您还没有工资哦!\n请继续努力吧!");
                    }
                }
                else
                {
                    label2.Text = "密码错误";
                }
            }
            else
            {
                label2.Text = "请检查用户名";
            }
        }
    }
}
