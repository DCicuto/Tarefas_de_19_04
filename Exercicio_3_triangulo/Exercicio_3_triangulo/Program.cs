// Programa leia os 3 lados de um triangulo e diga seu tipo 
//Equilátero: todos os lados são iguais
//Isósceles: apenas dois lados são iguais
//Escaleno: todos os lados são diferentes

using System.ComponentModel.Design;

double a = 0, b = 0, c = 0;
Console.WriteLine("Digite lado a do triangulo"); 
a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite lado a do triangulo");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite lado a do triangulo");
c = double.Parse(Console.ReadLine());

if ((a + b <= c || a + c <= b || b + c <= a))
{
    Console.WriteLine("Nao eh um triangulo");
}
else if (a == b && a == c)
{
  Console.WriteLine("Equilátero");
}
else if (a == b || a == c || b == c)
{
    Console.WriteLine("Isósceles");
}
else
{
    Console.WriteLine("Escaleno");
}

//if ((a == b) && (b == c))
//{
   // Console.WriteLine("Equilátero");
     //   else if (a != b) && (a != c) && (b != c);
      //  Console.WriteLine("Escaleno");
       // {
       //     else;
         //  Console.WriteLine("Isósceles"); 
       // }
   // }
//