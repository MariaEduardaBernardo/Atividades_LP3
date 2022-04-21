class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Entre com sua altura em metros: (ex: 1,65)");
        float altura = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Entre com seu peso em Kg: (ex: 57,5)");
        float peso = Convert.ToSingle(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("{0}, sua altura é {1} e seu peso é {2}", nome, altura, peso);
        Console.WriteLine("Seu IMC é: {0}", imc);
    }
}