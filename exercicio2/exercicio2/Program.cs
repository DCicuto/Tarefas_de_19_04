int idade, contador;
contador = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("digite a idade");
    idade = int.Parse(Console.ReadLine());
    if (idade >= 18)
    {
        contador++;
    }
}

Console.WriteLine(contador + " pessoas sao maiores de idade ");

