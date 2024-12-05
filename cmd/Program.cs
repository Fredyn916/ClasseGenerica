using cmd;

ClasseGenerica<int> classe1 = new ClasseGenerica<int>(1);

ClasseGenerica<string> classe2 = new ClasseGenerica<string>("pau");

Console.WriteLine(classe1.ObterValor());
classe1.MostrarTipo();
Console.WriteLine(classe2.ObterValor());
classe2.MostrarTipo();

ListaGenerica<Pessoa> listadePessoas = new ListaGenerica<Pessoa>();
listadePessoas.Adicionar(new Pessoa(1, "Fred"));
listadePessoas.Adicionar(new Pessoa(2, "Guilherme"));
listadePessoas.Adicionar(new Pessoa(3, "Paulo"));

listadePessoas.Listar();