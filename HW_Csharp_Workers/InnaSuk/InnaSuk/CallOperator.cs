using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    class CallOperator:Employee
    {
        private string _name;
        private int _subordinateQuantity;

        public CallOperator(string name, int subordinateQuantity)
        {
            _name = name;
            _subordinateQuantity = subordinateQuantity;
        }

        public override string Position()
        {
            return "CallOperator";
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
            return 20500.00;
        }
        public override string ResponsibilityLevel()
        {
            return "The level of responsibility above average";
        }

    }
}
