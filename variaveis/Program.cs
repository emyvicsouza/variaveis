
// string seve para armazenar texto
string nome = "emily souza";

// tipo de variavel para valores inteiros: 1, 2 e etc...
int idade = 16;

// tipo de variável para valores decimais: 1.5, 2.5 e etc...
float altura = 1.57f;
double preco = 15.7;
decimal saldo = 1000.57m;

// tipos de variáveis de valor lógico; true or false
bool estudante = true;

// tipo de variável para valores unicos 'A' , 'B'
char genero = 'F';

// tipo de variavel para valores constantes; PI = 3.14
const double pi = 3.14;

// forma 1
Console.WriteLine(nome);

// forma 2 - interpolação de string
Console.WriteLine($"0 {nome} tem {idade} anos");

// forma 3 - concatenação de string
Console.WriteLine("0" + "nome" + "tem" +idade + "anos");

// ultilizando \n para pular uma linha
// semelhante ao <br> do HTML que já ultilizamos
Console.WriteLine($"\n 0 valor de pi é: {pi}");