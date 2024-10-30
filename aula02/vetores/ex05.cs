Console.WriteLine("Informe a quantidade de pessoas: ");
int qnt = int.Parse(Console.ReadLine());
String [] pessoas = new String [qnt];
int [] idades = new int [qnt];
int velha = 0;
int posVelha = 0;

for (int i = 0; i < qnt; i++){
    Console.WriteLine($"Pessoa pos. {i}");
    pessoas[i] = Console.ReadLine();

    Console.WriteLine($"Idade de {pessoas[i]}");
    idades[i] = int.Parse(Console.ReadLine());

    if (i == 0)
        velha = idades[0];
    else if (velha < idades[i]){
        velha = idades[i];
        posVelha = i;
    }
}

Console.WriteLine($"{pessoas[posVelha]} é a pessoa mais velha");
