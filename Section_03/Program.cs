namespace Section_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise_01();
            // Exercise_02();
            // Exercise_03();
            // Exercise_04();
            // Exercise_05();
        }

        static void Exercise_01()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("SOMA = {0}", result);
        }

        static void Exercise_02()
        {
            double raio = double.Parse(Console.ReadLine());
            double area = 3.14159 * Math.Pow(raio, 2.0);
            Console.WriteLine("A={0}", area.ToString("F4"));
        }

        static void Exercise_03()
        {
            int a, b, c, d, diferenca;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            diferenca = a * b - c * d;
            Console.WriteLine("DIFERENCA = {0}", diferenca);
        }

        static void Exercise_04()
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorPorHora, salario;
            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine());
            salario = valorPorHora * horasTrabalhadas;
            Console.WriteLine("NUMBER = {0}", numeroFuncionario);
            Console.WriteLine("SALARY = U$ {0}", salario.ToString("F2"));
        }

        static void Exercise_05()
        {
            int codigoPeca1, numeroPeca1, codigoPeca2, numeroPeca2;
            double valorUnitarioPeca1, valorUnitarioPeca2, valorTotal;
            string[] vet = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vet[0]);
            numeroPeca1 = int.Parse(vet[1]);
            valorUnitarioPeca1 = double.Parse(vet[2]);
            vet = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vet[0]);
            numeroPeca2 = int.Parse(vet[1]);
            valorUnitarioPeca2 = double.Parse(vet[2]);
            valorTotal = numeroPeca1 * valorUnitarioPeca1 + numeroPeca2 * valorUnitarioPeca2;
            Console.WriteLine("VALOR A PAGAR: R$ {0}", valorTotal.ToString("F2"));
        }
    }
}
