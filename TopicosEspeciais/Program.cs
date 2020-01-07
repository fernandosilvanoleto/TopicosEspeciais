using System;
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

                  */

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

    }
}
