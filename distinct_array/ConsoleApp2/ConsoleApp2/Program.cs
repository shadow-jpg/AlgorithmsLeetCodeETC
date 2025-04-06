

namespace a
{
    public class Program
    {
        public static T[] Distinct<T>(T[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            HashSet<T> seen = new HashSet<T>();
            List<T> result = new List<T>();

            foreach (T item in array)
            {
                if (seen.Add(item)) 
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
        public static void Main()
        {
            int[] data = new int[10] { 1,2,1,5,7,8,10,12,10,2};
            data =Distinct(data);
            foreach(int res in data)
            {
                Console.Write(res + " ");
            }

        }

    }
}
    
    