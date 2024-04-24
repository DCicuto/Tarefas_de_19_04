using System.Globalization;
int size = 20, aux = 0;
int[] vetor1 = new int[size];
int[] vetor2 = new int[size];
int[] vetor3 = new int[size];


for(int i = 0; i < size; i++)
{
        vetor1[i] = new Random().Next(0, 100);
}

for (int i = 0; i < size; i++)
{
    vetor2[i] = vetor1[i];
    vetor3[i] = vetor2[i];
}
for (int i = 0; i < size; i++)
{
    int j = i + 1;
    while (j < size)
    {
        if (vetor2[i] > vetor2[j])
        {
            aux = vetor2[i];
            vetor2[i] = vetor2[j];
            vetor2[j] = aux;
            
        }
        
        else if (vetor2[i] == vetor2[j])
            {
                vetor2[j] = 0;
            }
        j++;
    }
}

for(int i = 0; i < size; i++)
{
    Console.WriteLine(vetor1[i] + " ");
}

Console.WriteLine("");

for (int i = 0; i < size; i++)
{
    Console.WriteLine (vetor2[i] + " ");
}

Console.WriteLine("");

int a = size - 1;
for (int i = 0; i < size; i++)
{
    vetor3[a] = vetor2[i];
    a--;
    Console.WriteLine(vetor3[i] + " ");
}




