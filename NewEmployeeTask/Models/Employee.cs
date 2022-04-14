using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee
    {
        private int _id;
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
            _id++;
            Id = _id;
        }
        public int Id { get;}
        public string Name { get; set; }
        public double Salary { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }
}
