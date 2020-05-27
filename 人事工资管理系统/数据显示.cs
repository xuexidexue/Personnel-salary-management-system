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
    public partial class 数据显示 : Form
    {
        工资管理 gzgl;
        管理员工 glyg;
        管理部门 bmtj;
        int wz;
        Mysql mysql = null;
        public 数据显示()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;//没有最后的空行
        }
        public void show(string sql) {
            if (mysql == null)
            {
                mysql = new Mysql();
            }
            dataGridView1.DataSource = mysql.select(sql);
        }
    

        public void setWz(int wz) {//设置在哪个部门
            this.wz = wz;
        }
        public void setGzgl(工资管理 gzgl) {
            this.gzgl = gzgl;
        }
        public void setBmtj(管理部门 bmtj)
        {
            this.bmtj = bmtj;
        }
        public void setGlyg(管理员工 glyg) {
            this.glyg = glyg;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;//获取选中行指定列
            if (wz == 1) {//管理部门页面
                bmtj.setVisible(1);//设置为修改页面
                bmtj.setId(a);
                bmtj.BringToFront();
                bmtj.Show();
            }
            else if (wz == 2) {
                glyg.setVisible(1);
                glyg.setId(a);
                glyg.BringToFront();
                glyg.Show();
            }
            else if (wz == 3) {
                gzgl.setVisible(1);
                gzgl.setId(a);
                gzgl.BringToFront();
                gzgl.Show();
            }
          
        }
        }

   
    }

