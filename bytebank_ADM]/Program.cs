using bytebank_ADM_.Funcionarios;
using bytebank_ADM_.Utilitario;

Funcionario pedro = new("65454447", 2000);

pedro.Nome = "Pedrinho";
//pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.Cpf);
Console.WriteLine(pedro.Salario);
Console.WriteLine(pedro.GetBonificacao());

Diretor diretor = new("5484544", 5000);

diretor.Nome = "Robertinha";
//diretor.Salario = 5000;

Console.WriteLine(diretor.Nome);
Console.WriteLine(diretor.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new();

//polimorfismo
gerenciador.registrar(pedro);
gerenciador.registrar(diretor);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

pedro.aumentarSalario();
diretor.aumentarSalario();

Console.WriteLine("Novo salário de Pedro: " + pedro.Salario);
//pedro.Salario = 100;
//Console.WriteLine("Novo salário de Pedro: " + pedro.Salario);
Console.WriteLine("Novo salário de Roberta: " + diretor.Salario);