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
    class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            try
            {
                /*
                 * IMPLEMENTANDO A EXPRESSÃO LAMBDA - 06/01/2020
                 
                
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

                 */

                int[] vect = new int[] { 3, 4, 5 };
                ChangeOddValues(vect);
                Console.WriteLine(string.Join(" ", vect));

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
    }
}
