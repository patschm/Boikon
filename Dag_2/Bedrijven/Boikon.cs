using System;
using System.Collections.Generic;
using System.Text;

namespace Bedrijven
{
    class Boikon
    {
        private List<IBoikonContract> employees = new List<IBoikonContract>();

        public void Hire(IBoikonContract emp)
        {
            employees.Add(emp);
        }

        public void Produceer()
        {
            Console.WriteLine("De stoomfluit gaat af en we produceren wat");
            foreach(IBoikonContract employee in employees)
            {
                employee.Produceer();
            }
        }
    }
}
