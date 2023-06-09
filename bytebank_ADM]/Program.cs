﻿using bytebank_ADM_.Funcionarios;
using bytebank_ADM_.Parceria;
using bytebank_ADM_.SistemaInterno;
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

//CalcularBonificacao();
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

void usarSistema()
{
    SistemaInterno sistema = new();

    Diretor ingrid = new("5546464");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Login = "ingrid.novaes";
    ingrid.Senha = "wow";

    GerenteDeContas ursula = new("6654646");
    ursula.Nome = "Ursula Souza";
    ursula.Login = "ursula.souza";
    ursula.Senha = "123";

    Auxiliar henrrrique = new("365641");
    henrrrique.Nome = "Henrrique Silva";

    sistema.logar(ingrid, "ingrid.novaes", "wow");
    sistema.logar(ursula, "", "miau");

    ParceirosComerciais caio = new();
    caio.Senha = "auau";

    sistema.logar(caio, "", "auau");
}

usarSistema();