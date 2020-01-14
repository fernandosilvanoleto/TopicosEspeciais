using System;
using System.Collections.Generic;
using System.Text;

namespace TopicosEspeciais.LAMBDA.Entities
{
    class Funcionario
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Funcionario(string name, string email, double salary)
        {
            this.Name = name;
            this.Email = email;
            this.Salary = salary;
        }
    }
}
