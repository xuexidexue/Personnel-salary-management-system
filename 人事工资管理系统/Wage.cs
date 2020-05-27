using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 人事工资管理系统
{
   /*工资
    *
    * 
   */
    class Wage
    {
        int id;
        int staff_id;//职员编号
        int basis;//基础工资
        int attendance;//考勤工资
        int peformance;//效绩工资
        int other;//其它
        string reason;//原因
        int total;//综合
        DateTime date;//时间

        public void setTime(DateTime date)
        {
            this.date = date;
        }
        public string getTime()
        {
            return date.ToString();
        }
        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getStaff_id()
        {
            return staff_id;
        }

        public void setStaff_id(int staff_id)
        {
            this.staff_id = staff_id;
        }

        public int getBasis()
        {
            return basis;
        }

        public void setBasis(int basis)
        {
            this.basis = basis;
        }

        public int getAttendance()
        {
            return attendance;
        }

        public void setAttendance(int attendance)
        {
            this.attendance = attendance;
        }

        public int getPeformance()
        {
            return peformance;
        }

        public void setPeformance(int peformance)
        {
            this.peformance = peformance;
        }

        public int getOther()
        {
            return other;
        }

        public void setOther(int other)
        {
            this.other = other;
        }

        public string getReason()
        {
            return reason;
        }

        public void setReason(string reason)
        {
            this.reason = reason;
        }

        public int getTotal()
        {
            return total;
        }

        public void setTotal(int total)
        {
            this.total = total;
        }

    }
}
