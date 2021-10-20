using System;

namespace questão_3
{
    class Program
    {
        static void Main(string[] args)
        {
           



            
            double nu;
            
            Console.WriteLine("Digite um numero: ");
            nu = double.Parse(Console.ReadLine());
            if (nu >= 0)
            {
                nu = Convert.ToSingle(Math.Sqrt(nu));
                Console.WriteLine("A raiz do numero é: {0}", nu);
            }
            else if (nu < 0)
            {
                nu = Math.Pow(nu, 2);
                Console.WriteLine("O quadrado do numero é: " + nu);

            }
        }
    }
}
