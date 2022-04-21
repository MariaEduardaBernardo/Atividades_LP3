Quadrado q1 = new Quadrado(10.0);
Quadrado q2 = new Quadrado(4.5);

q1.Lado = 15;

Console.WriteLine("\n--- Quadrado 1 ---\n");
Console.WriteLine("Lado: " +q1.Lado);
Console.WriteLine("Area: " +q1.Area);
Console.WriteLine("Perimetro: " +q1.Perimetro);

Console.WriteLine("\n--- Quadrado 2 ---\n");
Console.WriteLine("Lado: " +q2.Lado);
Console.WriteLine("Area: " +q2.Area);
Console.WriteLine("Perimetro: " +q2.Perimetro);

Retangulo r1 = new Retangulo(10, 4);
Retangulo r2 = new Retangulo(20, 8);

Console.WriteLine("\n--- Retangulo 1 ---\n");
Console.WriteLine("Area: " +r1.Area);
Console.WriteLine("Perimetro: " +r1.Perimetro);

Console.WriteLine("\n--- Retangulo 2 ---\n");
Console.WriteLine("Area: "+r2.Area);
Console.WriteLine("Perimetro: " +r2.Perimetro);