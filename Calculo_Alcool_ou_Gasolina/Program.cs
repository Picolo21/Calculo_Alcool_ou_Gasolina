internal class Program
{
    private static void Main(string[] args)
    {
        double alcool;
        double gasolina;

        Console.Write("Informe o valor do Álcool: R$ ");
        alcool = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor do Gasolina: R$ ");
        gasolina = double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("A relação entre o Álcool e a Gasolina é de " + (alcool / gasolina).ToString("F2"));
        Console.WriteLine();

        if ((alcool / gasolina) <= 0.72)
        {
            Console.WriteLine("O Álcool é mais vanjatoso");
        }
        else
        {
            Console.WriteLine("A Gasolina é mais vanjatosa");
        }
    }
}