//Programa que le o salario de uma pessoa e o valor com acrescimo e informa a porcentagem do acrescimo. 

double sal, salacrescimo, diferenca, porcentagem;
Console.WriteLine("Digite o salario");
sal = double.Parse (Console.ReadLine());
Console.WriteLine ("Digite o salario com acrescimo");
salacrescimo = double.Parse(Console.ReadLine());

diferenca = salacrescimo - sal;
porcentagem = (diferenca / sal) * 100;

Console.WriteLine($"A porcentagem de acrescimo salarial é de: % " + porcentagem);
    

