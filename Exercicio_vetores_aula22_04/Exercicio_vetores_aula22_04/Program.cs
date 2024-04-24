
//1 - Faça um programa que leia 10 numeros inteiros e imprima os seguintes itens:
//a) Somente os valores pares 
//b) Somente os valores impares 
//c) SOmente a primeira e a ultima posição


int[] numero = new int[10];
int[] par = new int[10];
int[] impar = new int[10];

//o new cria um novo objeto 
//não posso trabalhar com tipos de ddos diferentes dentro de um vetor
//vetor sempre inicia em 0

Console.WriteLine("Digite 10 numeros");
for (int i = 0; i < 10; i++)
{
    numero[0] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    if (par[i] % 2 == 0);
    {
        par[par[i]]++;
    }
    
}


//Console.WriteLine(par[i]);












