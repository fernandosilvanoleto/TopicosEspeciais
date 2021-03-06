﻿using System;
using System.IO;
using System.Collections.Generic;
using TopicosEspeciais.Entities;
using TopicosEspeciais.Services;
using System.Globalization;
using TopicosEspeciais.Model.Entities_Her_Inter;
using TopicosEspeciais.Model.Entities_Her_Multipla;
using TopicosEspeciais.Model.Entities_IComparable;
using TopicosEspeciais.Model.Enums;
using TopicosEspeciais.LAMBDA.Entities;
//using TopicosEspeciais.Extensions;
using System.Linq;

namespace TopicosEspeciais
{
    // declaração de um delegate
    delegate double BinaryNumericOperationSimple(double n1, double n2);

    //Multiple Delegate só trabalha com VOID
    delegate void BinaryNumericOperationMultiple(double n1, double n2);

    public delegate bool Predicate<in T>(T obj);
    class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            try
            {
                /*
                 * IMPLEMENTANDO A EXPRESSÃO LAMBDA - 06/01/2020
                 * using TopicosEspeciais.LAMBDA.Entities;
                 
                
                List<ProductLAMBDA> list = new List<ProductLAMBDA>();
                list.Add(new ProductLAMBDA("TV", 900.00));
                list.Add(new ProductLAMBDA("Notebook", 1200.00));
                list.Add(new ProductLAMBDA("Tablet", 450.00));

                // EXPRESSÃO LAMBDA - uma função anônima, só passa os modificadores

                // Comparison<ProductLAMBDA> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

                // USO EXPRESSÃO LAMBDA AQUI - NA REFERÊNCIA DO SORT (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())

                list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
                // nesse caso, o SORT só funciona no ProductLAMBDA se tiver a CLASSE IComparable
                // referência para uma função - chama-se DELEGATE        


                foreach (ProductLAMBDA item in list)
                {
                    Console.WriteLine(item);
                }

                 
                 
                // CÁLCULO LAMBDA

                int[] vect = new int[] { 3, 4, 5 };
                ChangeOddValues(vect);
                Console.WriteLine(string.Join(" ", vect));

                */

                /*
                 * Trabalhando com a DELEGATES - 07/01/2020
                 * DELEGATE -> uma referência (com type safety para um ou mais métodos), ou seja, é um tipo referência
                 * using TopicosEspeciais.LAMBDA.Entities;
                 
                
                double a = 10;
                double b = 12;

                //objeto op é uma referência agora para a função CalculationService
                BinaryNumericOperationSimple op = CalculationService.Sum;
                //PODE USAR A FUNÇÃO INVOKE - CHAMA A FUNÇÃO DO "SUM"

                double result = op(a, b);
                //double result = op.Invoke(a, b);
                Console.WriteLine("SIMPLE DELEGATE: " + result);


                MULTICAST DELEGATES
                 * 
                 * Delegates que guardam a referência para mais de um método
                 * Para adicionar uma referência, pode-se usar o operador +=
                 * A chamada Invoke (ou sintaxe reduzida) executa todos os métodos na ordem em que foram adicionados
                 * Seu uso faz sentido para métodos VOID
                

                double aa = 10;
                double bb = 12;

                //objeto op é uma referência agora para a função CalculationService
                BinaryNumericOperationMultiple opMultiple = CalculationService.ShowSum;

                opMultiple += CalculationService.ShowMax;

                opMultiple.Invoke(aa, bb);
                //opMultiple(aa, bb);
                */

                /*
                 * IMPLEMENTANDO PREDICATE (SYSTEM) - 07/01/2020
                 * Representa um método que recebe um objeto do tipo T e retorna um valor booleano
                 

                List<ProductLAMBDA> list = new List<ProductLAMBDA>();

                list.Add(new ProductLAMBDA("TV", 900.00));
                list.Add(new ProductLAMBDA("Mouse", 50.00));
                list.Add(new ProductLAMBDA("Tablet", 350.50));
                list.Add(new ProductLAMBDA("HD Case", 80.90));

                list.RemoveAll(ProductTest);

                foreach (ProductLAMBDA item in list)
                {
                    Console.WriteLine(item);
                }
                */

                /*
                 * Action (System) - 07/01/2020
                 * Representa um método void que recebe zero ou mais argumentos

                  

                List<ProductLAMBDA> list = new List<ProductLAMBDA>();

                list.Add(new ProductLAMBDA("TV", 900.00));
                list.Add(new ProductLAMBDA("Mouse", 50.00));
                list.Add(new ProductLAMBDA("Tablet", 350.50));
                list.Add(new ProductLAMBDA("HD Case", 80.90));

                // // função lambda que aumenta os preços dos produtos em 10% os valores das coisas de cada produto
                Action<ProductLAMBDA> action = p => { p.Price += p.Price * 0.1; };

                list.ForEach(action);
                // list.ForEach(p => { p.Price += p.Price * 0.1; });
                // função específica para aumentar os valores

                foreach (ProductLAMBDA item in list)
                {
                    Console.WriteLine(item);
                }
                */

                /*
                 * IMPLEMENTANDO FUNÇÕES DO FUNC (System) - 08/01/2020
                 * representa um método que recebe zero ou mais argumentos, e retorna um valor
                 

                List<ProductLAMBDA> list = new List<ProductLAMBDA>();

                list.Add(new ProductLAMBDA("TV", 900.00));
                list.Add(new ProductLAMBDA("Mouse", 50.00));
                list.Add(new ProductLAMBDA("Tablet", 350.50));
                list.Add(new ProductLAMBDA("HD Case", 80.90));

                // converter as strings em letras maiusculas
                // fazer importe do using System.Linq;

                // criando um DELEGATE

                Func<ProductLAMBDA, string> func = NameUpper;

                // agora com expressões lambdas
                Func<ProductLAMBDA, string> funcLambda = p => p.Name.ToUpper();

               // Func<ProductLAMBDA, string> funcLambda = { return p => p.Name.ToUpper(); }
                            

                List<string> result = list.Select(funcLambda).ToList();

                // agora em INLINE

                List<string> resultinline = list.Select(p => p.Name.ToUpper()).ToList();

                // retornando em maiusculas
                foreach (string item in result)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("----------------------------------");
                foreach (string item in resultinline)
                {
                    Console.WriteLine(item);
                }
                */

                /*
                 * CONCEITOS DE LINQ - Language Integrated Query - 08/01/2020
                 * 
                 * É um conjunto de tecnologias baseads na integração de funcionalidades de consulta diretamente na linguagem C#
                 * Namespace: System.Linq
                 * Possui diversas operações de consulta, cujos parâmetros tipicamente são expressões lambda ou expressões de sintaxe similiar à SQL
                 * 
                 * TRABALHANDO COM LINQ
                 * TRÊS PASSOS
                        - Criar um data source (coleção, array, recurso de E/S, etc)
                        - Definir a query
                        - Executa a query (foreach ou alguma operação terminal)
                            Execução Tardia                 

                // especificar um data source
                int[] numeros = new int[] { 2, 3, 4, 5 };

                // define uma query expression
                // tem que importar o System.Linq;

                // IEnumerable - coleção mais genérica, LINQ gosta dele

                IEnumerable<int> result = numeros
                                .Where(x => x % 2 == 0) // selecionando e usando condições
                                .Select(x => x * 10); // usando expressão a lambda para processamento

                // executando a query
                foreach (int x in result)
                {
                    Console.WriteLine(x);
                }
                */

                /*
                 * Implementando LINQ com LAMBDA - Parte 01 e PARTE 02
                 * 
                

                Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
                Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
                Category c3 = new Category() { Id = 3, Name = "All", Tier = 1 };

                List<Produto> produtos = new List<Produto>()
                {
                    new Produto() { Id = 1, Name = "Computador", Price = 1100.0, Category = c2 },
                    new Produto() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                    new Produto() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                    new Produto() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                    new Produto() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                    new Produto() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                    new Produto() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                    new Produto() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                    new Produto() { Id = 9, Name = "MacBok", Price = 1800.0, Category = c2 },
                    new Produto() { Id = 10, Name = "SoudBar", Price = 700.0, Category = c3 },
                    new Produto() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
                };

                // var r1 = produtos.Where(p => p.Category.Tier == 1 && p.Price < 900.0); // sintaxe através do lambda
                var r1 =
                    from p in produtos
                    where p.Category.Tier == 1 && p.Price < 900.00
                    select p;
                Print("TIER 1 AND PRICE < 900: ", r1);

                // var r2 = produtos.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
                var r2 =
                    from p in produtos
                    where p.Category.Name == "Tools"
                    select p.Name;
                Print("NAMES OF PRODUCTS FROM TOOLS = ", r2);

                // criando um objeto anônimo no SELECT
                // OBJETO ANÔNIMO - objeto que não está declarado
                //var r3 = produtos.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name } );
                var r3 =
                    from p in produtos
                    where p.Name[0] == 'C'
                    select new
                    {
                        p.Name,
                        p.Price,
                        CategoryName = p.Category.Name
                    };
                Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT = ", r3);

                //var r4 = produtos.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
                var r4 =
                    from p in produtos
                    where p.Category.Tier == 1
                    orderby p.Name
                    orderby p.Price
                    select p;
                Print("TIER 1 ORDER BY PRICE THEN BY NAME = ", r4);

                // paginação
                //var r5 = r4.Skip(2).Take(4);
                var r5 =
                    (from p in r4
                     select p).Skip(2).Take(4);
                Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

                //var r6 = produtos.FirstOrDefault();
                var r6 = (from p in produtos select p).FirstOrDefault();
                Console.WriteLine("First Or Default Test 1: " + r6);

                //var r7 = produtos.Where(p => p.Price > 3000.0).FirstOrDefault();
                var r7 =
                    (from p in produtos
                     where p.Price > 3000.0
                     select p).FirstOrDefault();
                Console.WriteLine("First Or Default Test 2: " + r7);
                Console.WriteLine();

                var r8 = produtos.Where(p => p.Id == 3).SingleOrDefault();
                Console.WriteLine("Single Or Default: " + r8);

                var r9 = produtos.Where(p => p.Id == 30).SingleOrDefault();
                Console.WriteLine("Single Or Default: " + r9);

                Console.WriteLine();

                var r10 = produtos.Max(p => p.Price);
                Console.WriteLine("Max Price of r10: " + r10);

                var r101 =
                    (from p in produtos
                     select p.Price).Max();
                Console.WriteLine("Max Price of r101: " + r101);

                var r11 = produtos.Min(p => p.Price);
                Console.WriteLine("Min Price: " + r11);

                var r12 = produtos.Where(p => p.Category.Id == 1).Sum(p => p.Price);

                Console.WriteLine("Category 1 Sum Price: " + r12);

                var r13 = produtos.Where(p => p.Category.Id == 1).Average(p => p.Price);

                Console.WriteLine("Category 1 Average Price: " + r13);

                var r14 = produtos.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0).Average();

                Console.WriteLine("Category 5 Average with DefaultIfEmpty Price: " + r14);

                var r15 = produtos.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate( (x, y) => x + y );

                Console.WriteLine("Category 1 Aggregate Sum Price: " + r15);

                var r16 = produtos.GroupBy(p => p.Category);

                Console.WriteLine();
                Console.WriteLine("Using GroupBy with Lambda");

                foreach (IGrouping<Category, Produto> group in r16)
                {
                    Console.WriteLine("Category " + group.Key.Name + ":");
                    foreach (Produto item in group)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Using GroupBy with SQL");

                var r17 =
                    from p in produtos
                    group p by p.Category;

                foreach (IGrouping<Category, Produto> group in r17)
                {
                    Console.WriteLine("Category " + group.Key.Name + ":");
                    foreach (Produto item in group)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                }
             
                  // Explicação da Álgebra Relacional e SQL - Nivelamento
                  // 11/01/2020           
                 
              */

                /*
                 * Resolvendo problema de Média - AVG - 14/01/2020
                 
                 

                Console.WriteLine("Enter full file path: ");
                string path = Console.ReadLine();

                List<Vendas> vendas = new List<Vendas>();

                // ler arquivo
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        // quando não chegar no final do arquivo, continuo lendo
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        vendas.Add(new Vendas(name, price));
                    }
                }

                var avg = vendas.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

                var names = vendas.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

                foreach (string item in names)
                {
                    Console.WriteLine(item);
                }
                */

                /*
                 * Resolvendo Problema Proposto - 14/01/2020
                 */

                Console.WriteLine("Enter full file path: ");
                string path = Console.ReadLine();

                Console.WriteLine("Enter Salary: ");
                double salaryCompare = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                List<Funcionario> funcionarios = new List<Funcionario>();

                // ler arquivo
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        // quando não chegar no final do arquivo, continuo lendo
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        funcionarios.Add(new Funcionario(name, email, salary));
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Email of people whose salary is more than " + salaryCompare.ToString("F2", CultureInfo.InvariantCulture));

                var orderEmail = funcionarios.Where(f => f.Salary > salaryCompare).OrderBy(f => f.Email).Select(f => f.Email);

                foreach (string emails in orderEmail)
                {
                    Console.WriteLine(emails);
                }

                var sumSalary = funcionarios.Where(f => f.Name[0] == 'M').Sum(f => f.Salary);

                Console.WriteLine("Sum of Salary of people whose name starts with 'M': 4900.00");

                Console.WriteLine("Removendo um email com contains!!!");

                var peoples = funcionarios.Where(f => f.Salary > salaryCompare).OrderBy(f => f.Email).Select(f => new { f.Name, f.Email, f.Salary }).ToList();

                Console.WriteLine();
                Console.WriteLine("Example 01");
                foreach (var item in peoples)
                {
                    Console.WriteLine(item);
                }

                // REMOVENDO UM CARACTERE DE UMA STRING DE UM ARRAY
                peoples.RemoveAll(p => p.Name.ToLower().Contains("bo"));
                
                Console.WriteLine();
                Console.WriteLine("Example 02 - removendo");
                foreach (var item in peoples)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }

        static int CompareProducts(ProductLAMBDA p1, ProductLAMBDA p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }

        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }

        public static bool ProductTest(ProductLAMBDA p)
        {
            // excluir da lista produtos menores que 100.00
            return p.Price >= 100.0;
        }

        static void UpdatePrice(ProductLAMBDA p)
        {
            // função simples que atualiza em 10% os valores das coisas de cada produto
            p.Price += p.Price * 0.1;
        }

        // retornar uma string em letras maiusculas
        static string NameUpper(ProductLAMBDA p)
        {
            return p.Name.ToUpper();
        }

        // função auxiliar

        static void Print<T>(String message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

    }
}
