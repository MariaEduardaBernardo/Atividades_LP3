Console.WriteLine("Entre com a base maior");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com a base menor");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com o lado 1");
double l1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com o lado 2");
double l2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com a altura");
double altura = Convert.ToDouble(Console.ReadLine());


Trapezio t1 = new Trapezio(b1, b2, l1, l2, altura);
Console.WriteLine(t1.AreaPerimetro);