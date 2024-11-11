using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_SalesEmployeeApp
{
    class SalesEmployee
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double basicSalary;
        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        private double sales;
        public double Sales
        {
            get { return sales; }
            set { sales = value; }
        }

        public SalesEmployee(int i, string n, double b, double s)
        {
            Id = i;
            Name = n;
            BasicSalary = b;
            Sales = s;
        }
    }
}
