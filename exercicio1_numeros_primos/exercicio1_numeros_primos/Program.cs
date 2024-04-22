using System.ComponentModel;

int n,divisor;
Console.WriteLine("Digite um numero");
n = int.Parse(Console.ReadLine());
divisor = 0;

for (int i = 1; i <= n; i++)
{
    if (n % n == 0)
    {
        divisor++;
    }
}
if (divisor == 2)
{
    Console.WriteLine("Numero primo");
}
else
{
    Console.WriteLine("numero nao primo"); 
}
  
