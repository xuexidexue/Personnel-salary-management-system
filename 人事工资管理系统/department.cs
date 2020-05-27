using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 人事工资管理系统
{
    /**
  * 部门
  */
    class department
    {
        int id;
        String name;//部门名称
        int basis;//基础工资
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public int getBasis()
        {
            return basis;
        }
        public void setBasis(int basis)
        {
            this.basis = basis;
        }
     
    }
}
