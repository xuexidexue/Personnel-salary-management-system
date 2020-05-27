using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 人事工资管理系统
{
    class ComboxItem
    {
        private string text;
        private int values;

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public int Values
        {
            get { return this.values; }
            set { this.values = value; }
        }

        public ComboxItem(string _Text, int _Values)
        {
            Text = _Text;
            Values = _Values;
        }


        public override string ToString()
        {
            return Text;
        }
    }
}
