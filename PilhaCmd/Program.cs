using cmd;
using PilhaCmd;

Pilha<Pessoa> pilhaDePessoa = new Pilha<Pessoa>();

pilhaDePessoa.Push(new Pessoa(1, "pau1"));
pilhaDePessoa.Push(new Pessoa(2, "pau2"));
pilhaDePessoa.Push(new Pessoa(3, "pau3"));

pilhaDePessoa.Listar();

Console.WriteLine("<---- REMOVENDO O ÚLTIMO ITEM (PRIMEIRO DA PILHA) ---->");

pilhaDePessoa.Pop();

pilhaDePessoa.Listar();