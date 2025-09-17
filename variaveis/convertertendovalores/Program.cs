//variáveis sem valor inicial
string nome;
int idade;
char sexo;
double salario;

Console.WriteLine ("digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine ("digite sua idade:");
idade = Convert.ToInt16 (Console.ReadLine());

Console.WriteLine("qual é o seu genêro: M OU F");
sexo = Convert.ToChar(Console.ReadLine().ToUpper());

Console.WriteLine("digite sua salário:");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($" seu nome é {nome}, você tem {idade} anos, seu sexo é {sexo}, e seu salário é: R$ {salario},00");