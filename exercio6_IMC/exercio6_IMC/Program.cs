double peso, altura, imc;
string situacao = "";
char sexo;

Console.WriteLine("digite o peso:");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("digite a altura:");
altura = double.Parse(Console.ReadLine());

Console.WriteLine("digite o sexo (M/F):");
sexo = char.Parse(Console.ReadLine().ToUpper());

imc = peso / (altura * altura);

if (sexo == 'M')
{
    if (imc < 20.7)
        situacao = "abaixo do peso";
    else if (imc < 26.4)
        situacao = "peso normal";
    else if (imc < 27.8)
        situacao = "um pouco acima do peso";
    else if (imc < 31.1)
        situacao = "acima do peso";
    else
        situacao = "obeso";
}
else if (sexo == 'F')
{
    if (imc < 19.1)
        situacao = "Abaixo do peso";
    else if (imc < 25.8)
        situacao = "peso normal";
    else if (imc < 27.3)
        situacao = "um pouco acima do peso";
    else if (imc < 32.3)
        situacao = "acima do peso";
    else
        situacao = "obesa";
}

Console.WriteLine("O IMC é: " + imc);
Console.WriteLine("A situação é: " + situacao);