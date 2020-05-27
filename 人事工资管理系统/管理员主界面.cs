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
    public partial class 管理员主界面 : Form
    {   public login log;
        修改密码 mima = null;
        数据显示 sjshou = null;
        public User user;
        管理部门 bmtj;
        管理员工 glyg;
        工资管理 gzgl;
        管理管理员 glgly;
        public 管理员主界面(login log)
        {
            this.log = log;
            InitializeComponent();

        }

        private void 部门管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmtj == null)
            {
                bmtj = new 管理部门();
                bmtj.MdiParent = this;
                bmtj.setGuanli(this);
            }
            if (sjshou == null) {
                sjshou = new 数据显示();
                sjshou.MdiParent = this;
                sjshou.setBmtj(bmtj);
            }
            sjshou.setBmtj(bmtj);
            sjshou.setWz(1);
            string sql = "select id as '部门号',name as '部门名称',basis as '基本工资' from department_info";
            sjshou.show(sql);
            sjshou.BringToFront();
            sjshou.Show();
            
          
        }
        public void setUser(User user){
            this.user = user;
            if (user.getId() == 1)
            {
                label1.Text = "当前用户为：超级管理员，欢迎使用本系统。";
            }
            else
            {
                label1.Text = "当前用户为：" + user.getName() + "，欢迎使用本系统。";
            }
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            log.Close();
        }
        private void 退出ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            log.Close();
        }
   
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
         
                if (mima == null)
                {
                    mima = new 修改密码();
                    mima.MdiParent = this;
                    mima.setUseandGuanli(user, this);
                }
                mima.BringToFront();
                mima.Show();
           
    
        }
        public void myclos() {

            if (mima != null)
            {
                mima.Hide();
            }
            if (bmtj != null)
            {
                bmtj.Hide();
            }
            if (sjshou != null) {
                sjshou.Hide();
            }
            if (glyg != null) {
                glyg.Hide();
            }
            if(gzgl!=null){
                gzgl.Hide();
            }
            if (glgly!= null)
            {
                glgly.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ControlBox = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            时间.Text = "时间：" + DateTime.Now.ToString();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (glyg == null)
            {
                glyg = new 管理员工();
                glyg.MdiParent = this;
                glyg.setGl(this);
            }
            if (sjshou == null)
            {
                sjshou = new 数据显示();
                sjshou.MdiParent = this;
            }
            sjshou.setWz(2);
            sjshou.setGlyg(glyg);
            string sql = "SELECT id as 员工号, name as 姓名,department_id as 部门号,password as 查询密码,sex as 性别,age as 年龄,createdate as 更新时间,post as 职位 FROM staff_info ";
            sjshou.show(sql);
            sjshou.BringToFront();
            sjshou.Show();
            
        }

        private void 薪酬管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gzgl == null)
            {
                gzgl = new 工资管理();
                gzgl.MdiParent = this;
                gzgl.setGzandGl(gzgl, this);
            }
            if (sjshou == null)
            {
                sjshou = new 数据显示();
                sjshou.MdiParent = this;
            }
            sjshou.setWz(3);
            sjshou.setGzgl(gzgl);
            string sql = "SELECT id as 工资号,staff_id as 员工号,basis as 基础工资,attendance as 出勤,performance as 效绩,other as 其他,reason as 原因,total as 总额,createdate as 更新时间 FROM wage_info ";
            sjshou.show(sql);
            sjshou.BringToFront();
            sjshou.Show();
        }

  

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmtj == null)
            {
                bmtj = new 管理部门();
                bmtj.MdiParent = this;
                bmtj.setGuanli(this);
            }
            bmtj.setVisible(0);//设置为添加页面
            bmtj.BringToFront();
            bmtj.Show();  
    
        }

        private void 添加员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (glyg == null) {
                glyg = new 管理员工();
                glyg.MdiParent = this;
                glyg.setGl(this);
            }
            glyg.setVisible(0);
            glyg.BringToFront();
            glyg.Show();
        }

        private void 添加薪酬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gzgl == null) {
                gzgl = new 工资管理();
                gzgl.MdiParent = this;
                gzgl.setGzandGl(gzgl, this);
            }
           
            gzgl.setVisible(0);
            gzgl.BringToFront();
            gzgl.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (user.getId() == 1)
            {
                if (glgly== null)
                {
                    glgly = new 管理管理员();
                    glgly.MdiParent = this;
                    glgly.getGl(this);
                }
                glgly.BringToFront();
                glgly.Show();
            }
            else
            {
                MessageBox.Show("对不起,非超级管理员不能使用该功能!", "提示");
            }              
        }


       // DELETE FROM user where id=@id
    



      

  
    }
}
