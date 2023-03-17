using bytebank_ADM_.Funcionarios;
using bytebank_ADM_.Utilitario;

Funcionario pedro = new();

pedro.Nome = "Pedrinho";
pedro.Cpf = "65454447";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.Cpf);
Console.WriteLine(pedro.Salario);
Console.WriteLine(pedro.GetBonificacao());

Diretor diretor = new();

diretor.Nome = "Robertinha";
diretor.Cpf = "5484544";
diretor.Salario = 5000;

Console.WriteLine(diretor.Nome);
Console.WriteLine(diretor.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new();


//polimorfismo
gerenciador.registrar(pedro);
gerenciador.registrar(diretor);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);