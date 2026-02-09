using System;
using System.Collections.Generic;

namespace Lambdaa1
{
    static class EmployeeService
    {
        public static void Filter()
        {
            
            List<Employee> emp = new List<Employee>
            {
              
                new Employee { Name = "sai", Department = "cse", JoiningDate = DateTime.Now.AddMonths(-6) },
                new Employee { Name = "charan", Department = "ece", JoiningDate = DateTime.Now.AddMonths(-2) },
                new Employee { Name = "muchakarla", Department = "eee", JoiningDate = DateTime.Now.AddMonths(-8) }
            };

     
            List<Employee> result = emp.FindAll(
                e => e.JoiningDate >= DateTime.Now.AddMonths(-9)
                  && e.Department == "eee"
            );

          
            foreach (Employee e in result)
            {
                Console.WriteLine(e.Name);
            }
        }
    }
}
