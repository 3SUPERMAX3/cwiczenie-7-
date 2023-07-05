// odcinek = sqrt((x2-x1)^2 + (y2-y1)^2)

double ZwrocDlugosc(
        double[] punkt1, //x1 y1 
        double[] punkt2  //x2 y2 
        )
{
    return Math.Sqrt(
            Math.Pow((punkt2[0] - punkt1[0]), 2) +
            Math.Pow((punkt2[1] - punkt1[1]), 2)
         );
}


Console.WriteLine("Podaj współrzędne punktu 1: ");
double[] punkt1 = new double[]
{
    double.Parse(Console.ReadLine()),
    double.Parse(Console.ReadLine())
};

Console.WriteLine("Podaj współrzędne punktu 2: ");
double[] punkt2 = new double[]
{
    double.Parse(Console.ReadLine()),
    double.Parse(Console.ReadLine())
};

Console.WriteLine($"Długość odcinka to: {ZwrocDlugosc(punkt1, punkt2)}");