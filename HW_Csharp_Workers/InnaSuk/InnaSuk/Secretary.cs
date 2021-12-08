using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    class Secretary:Employee
    {
        private string _name;
        private int _subordinateQuantity;

        public Secretary(string name, int subordinateQuantity)
        {
            _name = name;
            _subordinateQuantity = subordinateQuantity;
        }

        public override string Position()
        {
            return "Secretary";
        }
        public override string Name()
        {
            return _name;
        }
        public override int Subordinate()
        {
            return _subordinateQuantity;
        }
        public override double Salary()
        {
            return 17500.00;
        }
        public override string ResponsibilityLevel()
        {
            return "A middle level of responsibility";
        }
    }
}
