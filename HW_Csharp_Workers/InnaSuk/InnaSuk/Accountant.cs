using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    class Accountant:Employee
    {
        private string _name;
        private int _subordinateQuantity;

        public Accountant(string name, int subordinateQuantity)
        {
            _name = name;
            _subordinateQuantity = subordinateQuantity;
        }

        public override string Position()
        {
            return "Accountant";
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
            return 45500.00;
        }
        public override string ResponsibilityLevel()
        {
            return "A high level of responsibility ";
        }



    }
}
