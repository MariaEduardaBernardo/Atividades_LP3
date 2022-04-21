public class Trapezio
{
    public double B1 { get; set; }
    public double B2 { get; set; }
    public double L1 { get; set; }
    public double L2 { get; set; }
    public double Altura { get; set; }
    public double Area { get => ((B1+B2)*Altura)/2; }
    public double Perimetro { get => B1+B2+L1+L2; }

    public string AreaPerimetro{ get => "Trapezio: area " +Area+ ", perimetro "+Perimetro;}
    public Trapezio(double b1,double b2,double l1,double l2,double altura)
    {
        B1 = b1;
        B2 = b2;
        L1 = l1;
        L2 = l2;
        Altura = altura;
    }
}
