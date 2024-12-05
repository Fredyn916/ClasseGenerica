namespace cmd;

public class ClasseGenerica<T>
{
    public T _Valor;

	public ClasseGenerica(T valor)
	{
        _Valor = valor;
    }

    public T ObterValor()
    {
        return _Valor;
    }

    public void MostrarTipo()
    {
        Console.WriteLine($"O tipo da minha classe é: {typeof(T)}");
    }
}