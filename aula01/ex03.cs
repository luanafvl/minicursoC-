Console.WriteLine("Informe o numero de funcionarios: ");
int funcionarios = int.Parse(Console.ReadLine());

Console.WriteLine("Horas trabalhadas: ");
int horas = int.Parse(Console.ReadLine());

Console.WriteLine("Valor recebido por hora: ");
double valorHora = double.Parse(Console.ReadLine());

double salario = horas * valorHora;

Console.WriteLine($"Funcionarios = {funcionarios}");
Console.WriteLine($"Salario = U$ {Convert.ToDecimal(salario).ToString("0.00")}");
