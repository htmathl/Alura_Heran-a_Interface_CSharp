using bytebank_ADM_.Funcionarios;
using bytebank_ADM_.Utilitario;

#region
//Funcionario pedro = new("65454447", 2000);

//pedro.Nome = "Pedrinho";
////pedro.Salario = 2000;

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.Cpf);
//Console.WriteLine(pedro.Salario);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor diretor = new("5484544");

//diretor.Nome = "Robertinha";
////diretor.Salario = 5000;

//Console.WriteLine(diretor.Nome);
//Console.WriteLine(diretor.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new();

////polimorfismo
//gerenciador.registrar(pedro);
//gerenciador.registrar(diretor);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.aumentarSalario();
//diretor.aumentarSalario();

//Console.WriteLine("Novo salário de Pedro: " + pedro.Salario);
////pedro.Salario = 100;
////Console.WriteLine("Novo salário de Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salário de Roberta: " + diretor.Salario);
#endregion

CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new("526466");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new("3655464");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new("5857585");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new("36565468");
    camila.Nome = "Camila Oliveira";

    gerenciador.registrar(camila);
    gerenciador.registrar(paula);
    gerenciador.registrar(ulisses);
    gerenciador.registrar(igor);

    Console.WriteLine("Total de bonificação: " + gerenciador.TotalDeBonificacao);

    //Funcionario pedro = new("2564998", 852);
}