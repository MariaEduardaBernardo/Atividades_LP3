Console.WriteLine("Digite a base maior do trapezio: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a base menor do trapezio: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o lado 1 do trapezio: ");
double l1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o lado 2 do trapezio: ");
double l2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura do trapezio: ");
double altura = Convert.ToDouble(Console.ReadLine());


Trapezio t1 = new Trapezio(b1, b2, l1, l2, altura);