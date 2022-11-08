// На вход программы подаются три целых положительных числа. Определить ,
// является ли это сторонами треугольника. Если да, то вывести всю информацию
// по нему - площадь, периметр, значения углов треугольника в градусах,
// является ли он прямоугольным, равнобедренным, равносторонним.
void triangleProperties(double a, double b, double c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Треугольник существует");
        double perimetr = a + b + c;
        Console.WriteLine($"Периметр треугольника: {perimetr}");
        double polperimetr = (a + b + c) / 2;
        double ploshad = Math.Sqrt(polperimetr * (polperimetr - a) * (polperimetr - b) * (polperimetr - c));
        Console.WriteLine($"Площадь треугольника: {ploshad}");
        double alpha = GetBaseDegreeAngle(Math.Acos((b * b + c * c - (a * a)) / (2d * b * c)));
        Console.WriteLine($"Угол альфа: {alpha}");
        double beta = GetBaseDegreeAngle(Math.Acos((a * a + c * c - (b * b)) / (2d * a * c)));
        Console.WriteLine($"Угол бета: {beta}");
        double gamma = GetBaseDegreeAngle(Math.Acos((a * a + b * b - (c * c)) / (2d * a * b)));
        Console.WriteLine($"Угол гамма: {gamma}");
        if (alpha == 90 || beta == 90 || gamma == 90)
        {
            Console.WriteLine("Треугольник прямоугольный");
        }
        if (a == b || a == c || c == b)
        {
            Console.WriteLine("Треугольник равнобедренный");
        }
        if (a == b && b == c)
        {
            Console.WriteLine("Треугольник равносторонний");
        }
    }
    else
    {
        Console.WriteLine("Треугольник не существует");
    }
}
double GetBaseDegreeAngle(double number)
{
    double x = number * 180 / Math.PI;
    return Math.Round(x, 2);
}
Console.Write("Введите сторону A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите сторону B: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите сторону C: ");
double c = Convert.ToDouble(Console.ReadLine());
triangleProperties(a, b, c);
