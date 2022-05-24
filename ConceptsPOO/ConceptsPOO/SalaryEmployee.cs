using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }


        public override string ToString()
        {
            return $"{base.ToString()}" +
            $"\n\tValue to Pay.........: {$"{GetValueToPay():C2}", 20}";
        }

        public override decimal GetValueToPay()
        {
            return Salary;
        }
    }
}