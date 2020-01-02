using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TopicosEspeciais.Model.Entities_IComparable
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');  // separar as colunas por vírgula no vetor
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            // objetc obj se refere a própria classe
            // comparar um funcionário com outro funcionário
            if (!(obj  is Employee))
            {
                throw new ArgumentException("Comparing Error: argument is not an Employee");
            }
            Employee other = obj as Employee;
            //return Salary.CompareTo(other.Salary);
            return Name.CompareTo(other.Name);
        }
    }
}
