Console.WriteLine("Calculando a area de um trapezio...");
Console.WriteLine("\n\nInforme\nBase maior: ");
double B = double.Parse(Console.ReadLine());
Console.WriteLine("Base menor: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Altura: ");
double h = double.Parse(Console.ReadLine());

double area = (B + b) * h / 2;

Console.WriteLine(area);
