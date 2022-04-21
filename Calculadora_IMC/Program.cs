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

        if (imc < 17)
        {
            Console.WriteLine("Muito abaixo do peso");
        }else
        
        if ((imc >= 17) && (imc < 18.49))
        {
            Console.WriteLine("Abaixo do peso");
        }else

        if ((imc >= 18.5) && (imc < 25))
        {
            Console.WriteLine("Peso normal");
        }else

        if ((imc >= 25) && (imc < 30))
        {
            Console.WriteLine("Acima do peso");
        }else

        if ((imc >= 30) && (imc < 35))
        {
            Console.WriteLine("Obesidade I");
        }else

        if ((imc >= 35) && (imc < 40))
        {
            Console.WriteLine("Obesidade II (Severa)");
        }else

        if (imc >= 40)
        {
            Console.WriteLine("Obesidade III (Mórbida)");
        }
    }
}