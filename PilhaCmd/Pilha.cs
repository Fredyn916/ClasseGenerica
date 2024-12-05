namespace PilhaCmd;

public class Pilha<T> where T : class
{
    private List<T> _Pilha = new List<T>();

    public void Push(T item)
    {
        _Pilha.Add(item);
    }

    public void Pop()
    {
        _Pilha.RemoveAt(_Pilha.Count - 1);
    }

    public void Listar()
    {
        foreach (T item in _Pilha)
        {
            Console.WriteLine(item);
        }
    }
}