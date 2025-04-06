internal class Program
{
    private static void Main(string[] args)
    {

    }
    public IEnumerable<T> FilterLast<T>(IEnumerable<T> source, int n)
    {
        var buffer = new Queue<T>();

        foreach (var item in source)
        {
            buffer.Enqueue(item);

            if (buffer.Count > n)
            {
                yield return buffer.Dequeue();
            }
        }
    }
}