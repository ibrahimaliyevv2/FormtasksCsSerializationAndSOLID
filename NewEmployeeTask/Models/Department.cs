using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Department
    {
        private int _id;
        public Department()
        {
            _id++;
            Id = _id;
        }
        public int Id { get; }
        public string Name { get; set; }
        public List<Employee> Employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            return Employees.Find(x => x.Id == id);
        }

        public void RemoveEmployee(int id)
        {
            Employees.Remove(Employees.Find(x => x.Id == id));
        }
    }
}
