namespace cmd;

public class ListaGenerica<T> where T : class
{
    private List<T> _Itens = new List<T>();

	public void Adicionar(T item)
	{
		_Itens.Add(item);
	}

	public void Listar()
	{
		switch (_Itens)
		{
			case Pessoa:
				foreach(T i in _Itens)
				{
					i.ToString();
				}
				break;
			default:
				break;
		}
	}
}