using ExemploFundamentos.Models;

//data e hora
DateTime dataAtual = DateTime.Now; //pega data e hora atual
DateTime outraData = DateTime.Now.AddDays(5); //adiciona dias à data atual
Console.WriteLine(dataAtual);
Console.WriteLine(outraData);
Console.WriteLine(outraData.ToString("dd/MM/yyyy")); // imprimindo só a data
Console.WriteLine(outraData.ToString("dd/MM/yy")); // mudando formato da data


Console.WriteLine("-------------------------------------------");
// exemplo de variáveis
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M; //esse é recomendável para valores (dinheiro)
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
// abaixo, quando a variável é to tipo double e se quiser uma quantidade correta de casas decimais, é preciso utilizar o ToString, mas quando a variável é do tipo decimal, não precisa fazer isso
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

Console.WriteLine("-------------------------------------------");

// instanciando um objeto
// acessando propriedades e método
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Sergio";
pessoa1.Idade = 51;
pessoa1.Apresentar();

// declaração de variável é sempre no padrão camelCase
// declaração do restante é sempre no padrão PascalCase