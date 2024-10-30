Console.WriteLine("Informe o tamanho do vetor: ");
int tam = int.Parse(Console.ReadLine());
double [] vetor = new double [tam];
double maior = 0;
int posMaior = 0;

for (int i = 0; i < tam; i++){
    Console.WriteLine($"Numero pos. {i}");
    vetor[i] = double.Parse(Console.ReadLine());
    if (i == 0)
        maior = vetor[0];
    else if (maior < vetor[i]){
        maior = vetor[i];
        posMaior = i;
    }
}

Console.WriteLine($"O maior numero eh {maior} e esta na posicao {posMaior} do vetor");
