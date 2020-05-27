using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 人事工资管理系统
{
    class Staff
    {

        int id;
        String name;
        int department_id;//部门编号
        String password;
        String sex;
        int age;
        String post;//职位
        DateTime date;

        public void setTime(DateTime date)
        {
            this.date=date;
        }
        public string getTime() {
            return date.ToString();
        }
        public String getPost() {
            return post;
        }
        public void setPost(String post)
        {
            this.post = post;
        }
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

        public int getDepartment_id()
        {
            return department_id;
        }

        public void setDepartment_id(int department_id)
        {
            this.department_id = department_id;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getSex()
        {
            return sex;
        }

        public void setSex(String sex)
        {
            this.sex = sex;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

    }
}
