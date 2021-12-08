using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    class Assistant:Employee
    {
        private string _name;
        private int _subordinateQuantity;

        public Assistant(string name, int subordinateQuantity)
        {
            _name = name;
            _subordinateQuantity = subordinateQuantity;
        }

        public override string Position()
        {
            return "Assistan";
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
            return 10000.00;
        }
        public override string ResponsibilityLevel()
        {
            return "A low level of responsibility";
        }
    }
}
