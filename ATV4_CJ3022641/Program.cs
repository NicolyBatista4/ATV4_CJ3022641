using System.Threading.Channels;

namespace ATV4_CJ3022641
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0, num1, num2, resultado;

            Console.WriteLine("Digite o primeiro número : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação: ");
            Console.WriteLine("1 adição");
            Console.WriteLine("2 subtração");
            Console.WriteLine("3 multiplicação");
            Console.WriteLine("4 divisão");
            Console.WriteLine("Digite o número da operação : ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine( resultado );
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine( resultado);
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine( resultado);
                    break;

                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine( resultado);
                    break;



            }
        }
    }
}