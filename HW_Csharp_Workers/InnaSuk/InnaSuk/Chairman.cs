using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    class Chairman:Employee
    {
        private string _name;
        private int _subordinateQuantity;

        public Chairman(string name, int subordinateQuantity)
        {
            _name = name;
            _subordinateQuantity = subordinateQuantity;
        }

        public override string Position()
        {
            return "Chairman";
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
            return 100500.00;
        }
        public override string ResponsibilityLevel()
        {
            return "The highest level of responsibility!";
        }
    }
}
