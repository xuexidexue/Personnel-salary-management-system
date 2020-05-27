using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 人事工资管理系统
{
   public  class User
    {
        int id;
        string name;
        string password;
        public void users(string name,string password)
        {
            this.name = name;
            this.password = password;
        }
        public int getId() {
            return id;
        }
        public void setId(int id) {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public void setName(string name) {
            this.name = name;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
