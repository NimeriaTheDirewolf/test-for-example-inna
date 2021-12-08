using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    class MakeNew
    {
        static public void MakeNewEmployee(int selected, string name, int subordinateQuantity, List <Employee> new_employees )
        {
            switch (selected)
            {
                case 1:
                    new_employees.Add(new Chairman(name, subordinateQuantity));
                    break;
                case 2:
                    new_employees.Add(new Accountant(name, subordinateQuantity));
                    break;
                case 3:
                    new_employees.Add(new Assistant(name, subordinateQuantity));
                    break;
                case 4:
                    new_employees.Add(new Secretary(name, subordinateQuantity));
                    break;
                case 5:
                    new_employees.Add(new SalesManager(name, subordinateQuantity));
                    break;
                case 6:
                    new_employees.Add(new CallOperator(name, subordinateQuantity));
                    break;



            }
        }

    }
}
