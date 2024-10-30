using System.Globalization;

String product1 = "Computer";
String product2 = "Office desk";

int age = 30;
int code = 5290;
char gender = 'F';

double price1 = 2100.0;
double price2 = 650.5;
double measure = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine($"{product1}, cujo preco eh R${price1}");
Console.WriteLine($"{product2} cujo preco eh R${price2}");
Console.WriteLine($"Registro: {age} anos, codigo {code} e genero: {gender}");
Console.WriteLine($"Medida com oito casas decimais: {Convert.ToDecimal(measure).ToString("0.00000000")} metros");
Console.WriteLine($"Cercado (tres casas decimais: {Convert.ToDecimal(measure).ToString("0.000")} metros");
Console.WriteLine($"Ponto decimal dos EUA: {measure.ToString("F3", CultureInfo.InvariantCulture)} metros");
