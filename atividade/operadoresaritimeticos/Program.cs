/*
  
+ = adição
- = subtração
* = multiplicação
/ = divisão

*/

int soma = 2 + 2;
int subtracao = 10 - 5;
int multiplicacao = 3 * 7;
double divisao = 3 / 2.5;

Console.WriteLine($"2 +2 = {soma}");
Console.WriteLine($"10 - 5 = {subtracao}");
Console.WriteLine($"3 * 7 = {multiplicacao}");
Console.WriteLine($"3 / 2.5 = {divisao}");

int num1, num2,  resultado;
Console.WriteLine("insira a primeira nota");
num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("insira a segunda nota");
num2 = Convert.ToInt16(Console.ReadLine());

resultado = num1 + num2;
Console.WriteLine($"a soma das notas é: {resultado}");