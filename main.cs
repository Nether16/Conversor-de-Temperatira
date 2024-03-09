internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escolha qual temperatura devera ser convertida");
        Console.WriteLine("1 - Celsius -> Farenheits");
        Console.WriteLine("2 - Farenheits -> Celsius");
        int escolha = int.Parse(Console.ReadLine());

        float resultado = 0;
        if (escolha == 1){
            Console.Write("Escreva o numero de Graus Celsuis : ");
            float graus = float.Parse(Console.ReadLine());

            resultado = (graus * 9/5) + 32;

            Console.WriteLine($"{graus} graus celsius fica igual a {resultado} graus farenheits");
        }else{
            Console.Write("Escreva o numero de Graus Celsuis : ");
            float graus = float.Parse(Console.ReadLine());

            resultado = (graus - 32)* 5/9;

            Console.WriteLine($"{graus} graus farenheits fica igual a {resultado} graus celsius");
        }
    }
}