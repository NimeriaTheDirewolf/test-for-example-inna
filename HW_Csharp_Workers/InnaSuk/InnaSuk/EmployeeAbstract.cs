using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    abstract public class Employee
    {
        
        abstract public string Name();
        abstract public string Position();
        abstract public int Subordinate();
        abstract public double Salary();
        abstract public string ResponsibilityLevel();

    }
}
