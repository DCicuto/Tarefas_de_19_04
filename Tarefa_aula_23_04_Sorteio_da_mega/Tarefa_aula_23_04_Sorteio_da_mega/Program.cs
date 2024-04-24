int[] numeros = new int[6];
Random numerosgerados = new Random();
int aleatorios;

for (int contador = 0; contador < 6; contador++)
{
    aleatorios =  numerosgerados.Next(1, 61); //coloca 61 pq ele ignora o ultimo numero 
    while (numeros.Contains(aleatorios))
        // O Contains verifica se numero repetido no vetor
    {
        aleatorios = numerosgerados.Next(1, 61); 
    }// Condição que verfica se há numeros repetidos, tratamento de erros.

    numeros[contador] = aleatorios;
    Console.Write(aleatorios + " ");
   
}