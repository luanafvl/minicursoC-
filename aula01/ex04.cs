Console.WriteLine("A");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("B");
double B = double.Parse(Console.ReadLine());

Console.WriteLine("C");
double C = double.Parse(Console.ReadLine());

Console.WriteLine($"Area do triangulo retangulo de base A e C de altura = {A*C/2}");
Console.WriteLine($"Area do circulo de raio C. (pi = 3.14159) = {Math.PI*Math.Pow(C,2)}");
Console.WriteLine($"Area do trapézio que tem A e B por bases e C por altura = {(A+B)*C/2}");
Console.WriteLine($"Area do quadrado de lado B = {Math.Pow(B,2)}");
Console.WriteLine($"Area do retangulo de lados A e B = {A*B}");
